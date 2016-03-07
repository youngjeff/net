using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;
using Microsoft.VisualC;
namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        Device device = null;
        private  Texture showPicture; // 定义图片变量
        private Sprite sprite;
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
                sprite = new Sprite(device);
                string imagePath = @"./1.jpg";
                showPicture = TextureLoader.FromFile(device, imagePath);//初始化图片对象，导入图片
                return true;
            }
            catch (DirectXException e)
            {
                MessageBox.Show(e.ToString(), "Error"); //处理异常
                return false;
            }
        }
        public void Render()
        {
            if (device == null) //如果device为空则不渲染
            {
                return;
            }
            device.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f, 0); // 清除windows界面为深蓝色
            device.BeginScene();
            //在此添加渲染图形代码
            int spriteX = 10;
            //Sprite sprite;//定义Sprite对象
            //sprite = new Sprite(device);//实例化Sprite对象
            sprite.Begin(SpriteFlags.AlphaBlend);
            sprite.Draw(showPicture, Vector3.Empty, new Vector3(spriteX, 50, 0),
                Color.White.ToArgb());
            spriteX += showPicture.GetLevelDescription(0).Width + 10;
            sprite.Draw(showPicture, new Rectangle(4, 4, 200, 200), Vector3.Empty, new Vector3(spriteX, 50, 0), Color.Green);
            spriteX += showPicture.GetLevelDescription(1).Width;
            sprite.Draw(showPicture, Rectangle.Empty, Vector3.Empty, new Vector3(spriteX+100, 50, 0), Color.Yellow);
            /*System.Drawing.Point rotationPoint = new Point();
            System.Drawing.Point position = new Point();
            position.X = 100;
            position.Y = 150;
            sprite.Draw2D(showPicture, rotationPoint, 0f, position, Color.White);*/
            sprite.End();
            device.EndScene();
            device.Present();
        }
    }
}
