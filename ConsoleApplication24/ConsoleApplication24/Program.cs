using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入目录名称: ");
            string strDirectoryName = Console.ReadLine();

            Program myUsingDirInfo = new Program();
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(strDirectoryName);

            myUsingDirInfo.ShowDirectory(myDirectoryInfo);
            myUsingDirInfo.ShowFiles(myDirectoryInfo);
            Console.ReadLine();
        }
        private void ShowDirectory(DirectoryInfo dir)
        {
            Console.WriteLine("以下为" + dir.Name + "所有子目录名称:");
            DirectoryInfo[] myDirectoryInfo = dir.GetDirectories();

            foreach(DirectoryInfo subDir in myDirectoryInfo)
            {
                Console.WriteLine(subDir.Name + "\n" + "[最后修改日期:" + dir.LastAccessTime + "]\n" +
                    "[最后写入日期: " + dir.LastAccessTime + "]\n"
                    );
            }
        }
        private void ShowFiles(DirectoryInfo dir)
        {
            Console.WriteLine("以下为" + dir.Name + "所有文件名称: ");
            FileInfo[] myFileInfo = dir.GetFiles();//list
            foreach (FileInfo myFile in myFileInfo)
            {
                Console.WriteLine(myFile.Name + "\n" + "[文件扩展名: " + myFile.Extension + "]\n"+
                    "[最后修改日期: " + myFile.LastAccessTime + "]\n"+
                    "[最后写入日期: " + myFile.LastAccessTime + "]\n");
            }
        }
    }
   
}
