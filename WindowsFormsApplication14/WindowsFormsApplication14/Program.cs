using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           
            Form1 basicForm = new Form1();
            
            if (basicForm.InitializeDirect3D() == false)
            {
                MessageBox.Show("无法启动Direct3D！", "错误");
                return;
            }
            basicForm.Show();
            while (basicForm.Created)
            {
                basicForm.Render();
                Application.DoEvents();
            }
           // Application.Run(basicForm);
        }
    }
}
