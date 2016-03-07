using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        Device device = null;
        public Form1()
        {
           // InitializeComponent();
            this.ClientSize = new Size(800, 600);
            this.Text = "第一个DirectX程序";
        }
        public bool InitializeDirect3D()
        {
            try
            {
                PresentParameters presentParams = new PresentParameters();
                presentParams.Windowed = true;
                presentParams.SwapEffect = SwapEffect.Discard;
                device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing,
                    presentParams);
                return true;
            }
            catch (Direct3DXException e)
            {
                MessageBox.Show(e.ToString(), "Error");
                return false;
            }
        }
        public void Render()
        {
            if (device == null)
            {
                return;
            }
            device.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f, 0);
            device.BeginScene();
            //在此添加渲染图形代码
            device.EndScene();
            device.Present();
        }
    }
}
