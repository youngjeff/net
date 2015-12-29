// ConsoleApplication50.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <stdio.h>

#define __STDC_CONSTANT_MACROS
#ifdef _WIN32
//windows
extern "C"
{
#include <libavcodec/avcodec.h>	//解码视频数据流
#include <libavformat\avformat.h> //获取视频数据流
#include <libswscale\swscale.h>	//图像像素转换	

};
#endif // _WIN32

int main(int argc,char* argv[])
{
	AVFormatContext *pFormatCtx;
	int	i, videoindex;
	AVCodecContext *pCodeCtx;
	AVCodec *pCodec;
	AVFrame *pFrame, *pFrameYUV;
	uint8_t *out_buffer;
	AVPacket *packet;
	int y_size;
	int ret, got_picture;
	struct SwsContext *img_convert_ctx;

	char filepath[] = "Titanic.mkv";
	FILE *fp_yuv = fopen("put.yuv", "wb+");

	av_register_all();
	avformat_network_init();
	pFormatCtx = avformat_alloc_context();

	if (avformat_open_input(&pFormatCtx, filepath, NULL, NULL) != 0)
	{
		printf("Couldn't open input stream.\n ");
		return -1;
	}
	videoindex = -1; // ？
	for (i = 0; i < pFormatCtx->nb_streams; i++)
	{
		if (pFormatCtx->streams[i]->codec->codec_type == AVMEDIA_TYPE_VIDEO)
		{
			videoindex = i;
			break;
		}
	}
		if (videoindex == -1)
		{
			printf("Didn't find a video stream. \n");
			return -1;
		}

		pCodeCtx = pFormatCtx->streams[videoindex]->codec;
		pCodec = avcodec_find_decoder(pCodeCtx->codec_id);
		if (pCodec == NULL)
		{
			printf("Codec not found.\n");
			return -1;
		}
		if (avcodec_open2(pCodeCtx, pCodec, NULL) < 0) {
			printf("Counld not open code .\n");
			return -1;
		}
		//以上在寻找文件和解码器
		pFrame = av_frame_alloc();
		pFrameYUV = av_frame_alloc();
		out_buffer = (uint8_t *)av_malloc(avpicture_get_size(AV_PIX_FMT_YUVJ420P, pCodeCtx->width, pCodeCtx->height));
		avpicture_fill((AVPicture *)pFrameYUV, out_buffer, PIX_FMT_YUV420P, pCodeCtx->width, pCodeCtx->height);
		packet = (AVPacket *)av_malloc(sizeof(AVPacket));
		//output info ---
		printf("------File information------");
		av_dump_format(pFormatCtx, 0, filepath, 0);
		printf("----------------------------");
		img_convert_ctx = sws_getContext(pCodeCtx->width, pCodeCtx->height, pCodeCtx->pix_fmt,
			pCodeCtx->width,pCodeCtx->height,PIX_FMT_YUV420P,SWS_BICUBIC,NULL,NULL,NULL);

		while (av_read_frame(pFormatCtx, packet) >= 0)
		{
			if (packet->stream_index == videoindex) {
				ret = avcodec_decode_video2(pCodeCtx, pFrame, &got_picture, packet);
				if (ret < 0)
				{
					printf("Decode Error.\n");
					return -1;
				}
				if (got_picture) {
					sws_scale(img_convert_ctx, (const uint8_t* const*)pFrame->data, pFrame->linesize, 0,
						pCodeCtx->height, pFrameYUV->data, pFrameYUV->linesize);

					y_size = pCodeCtx->width*pCodeCtx->height;
					fwrite(pFrameYUV->data[0], 1, y_size, fp_yuv); // Y
					fwrite(pFrameYUV->data[1], 1, y_size / 4, fp_yuv);
					fwrite(pFrameYUV->data[2], 1, y_size / 4, fp_yuv);
					printf(" succeed to decode 1 frame!\n");
				}
			}
			av_free_packet(packet);
		}
		//flush decoder
		//FIX: Flush Frames remained in Codec
		while (1)
		{
			ret = avcodec_decode_video2(pCodeCtx, pFrame, &got_picture, packet);
			if (ret < 0)
			{
				break;
			}
			if (!got_picture)
				break;
			sws_scale(img_convert_ctx, (const uint8_t* const*)pFrame->data, pFrame->linesize, 0, pCodeCtx->height,
				pFrameYUV->data, pFrameYUV->linesize);
			int y_size = pCodeCtx->width * pCodeCtx->height;
			fwrite(pFrameYUV->data[0], 1, y_size, fp_yuv); //Y
			fwrite(pFrameYUV->data[2], 1, y_size / 4, fp_yuv); //U
			fwrite(pFrameYUV->data[2], 1, y_size / 4, fp_yuv); // V
			printf("Flush Decoder : Succeed to decode 1 frame!\n");
		}
		sws_freeContext(img_convert_ctx);

		fclose(fp_yuv);
		av_frame_free(&pFrameYUV);
		av_frame_free(&pFrame);
		avcodec_close(pCodeCtx);
		avformat_close_input(&pFormatCtx);

		return 0;
	

}

