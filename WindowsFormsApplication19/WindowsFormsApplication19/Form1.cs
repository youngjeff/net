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
namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        Device device = null;
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

            CustomVertex.TransformedColored[] vertices = new CustomVertex.TransformedColored[3];//定义顶点
            vertices[0].Position = new Vector4(150f, 400f, 0f, 1f);
            vertices[0].Color = Color.Red.ToArgb();
            vertices[1].Position = new Vector4(this.Width / 2, 100f, 0f, 1f);
            vertices[1].Color = Color.Green.ToArgb();
            vertices[2].Position = new Vector4(this.Width - 150f, 400f, 0f, 1f);
            vertices[2].Color = Color.Yellow.ToArgb();
            device.VertexFormat = CustomVertex.TransformedColored.Format;
            device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices);
            
            device.EndScene();
            device.Present();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MessageBox.Show("鼠标按下的位置:X=" + e.X.ToString() + ",Y=" + e.Y.ToString());
        }
    }
}
