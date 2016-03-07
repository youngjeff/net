using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualC;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        Device device = null;
        private int x = 0;//定义当前动画帧
        private int y = 0;//定义动画帧数目
        private const int frameCount = 8;//定义动画帧数目
        private int currentFrame = 0;//定义当前动画帧
        private System.Windows.Forms.Timer aniTimer;//定义计时器
        private Sprite sprite; //定义Sprite对象
        private Texture showPicture;//定义图片对象
        public Form1()
        {
            InitializeComponent();
        }

        public bool InitializeDirect3D()
        {
            try
            {
                PresentParameters presentParams = new PresentParameters();
                presentParams.Windowed = true; //指定以Windows窗体形式显示
                presentParams.SwapEffect = SwapEffect.Discard; //当前屏幕绘制后它将自动从内存中删除
                device = new Device(0, DeviceType.Hardware, this,
                CreateFlags.SoftwareVertexProcessing, presentParams); //实例化device对象
                string imagePath = "./1.jpg";
                sprite = new Sprite(device);
                showPicture = TextureLoader.FromFile(device, imagePath);
                aniTimer = new Timer();
                aniTimer.Enabled = true;
                aniTimer.Interval = 20;
                aniTimer.Tick += new EventHandler(this.aniTimer_Tick);

                return true;


            }
            catch (DirectXException e)
            {
                MessageBox.Show(e.ToString(), "Error"); //处理异常
                return false;
            }
        }
        private void aniTimer_Tick(object sender,EventArgs e)
        {
            /*if(x > showPicture.GetLevelDescription(0).Width / 5 * 4)
            {
                if(y < showPicture.GetLevelDescription(0).Height / 3 * 2)
                {
                    x = 0;
                    y += showPicture.GetLevelDescription(0).Width / 3;
                }
                else
                {
                    x = 0;
                    y = 0;
                }
              
            }
            else
            {
                x = x + showPicture.GetLevelDescription(0).Width / 5;
            }*/
            if (currentFrame >= frameCount - 1)
            {
                currentFrame = 0;
            }
            else
            {
                currentFrame++;
            }
        }
        public void Render()
        {
            if (device == null) //如果device为空则不渲染
            {
                return;
            }
            device.Clear(ClearFlags.Target, Color.White, 1.0f, 0); // 清除windows界面为深蓝色
            device.BeginScene();
            //在此添加渲染图形代码
            sprite.Begin(SpriteFlags.AlphaBlend);
            //Rectangle originPicRect = new Rectangle(x,y,showPicture.GetLevelDescription(0).Width,showPicture.GetLevelDescription(0).Height);
            Rectangle originPicRect = new Rectangle(10 * currentFrame, 0,showPicture.GetLevelDescription(0).Width, showPicture.GetLevelDescription(0).Height);
            sprite.Draw(showPicture, originPicRect, Vector3.Empty, new Vector3(100, 50, 0), Color.White.ToArgb());
            sprite.End();
            device.EndScene();
            device.Present();
        }
    }
}
