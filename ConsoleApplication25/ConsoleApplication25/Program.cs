using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication25
{
    class Program
    {
        private int IntModify()
        {
            int intType = 0;
            Console.WriteLine("请指定操作种类: [1] 新建 [2] 删除 [3] 复制 [4] 移动");

            while(intType < 1 || intType > 4)
            {
                intType = int.Parse(Console.ReadLine());
                if (intType < 1 || intType > 4)
                    Console.WriteLine("输入数字不正确!!");
            }
            return intType;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                int intMaintain;
            string strDir;
            string strFile;
            string strResult = "";
            Program myMaintain = new Program();
            intMaintain = myMaintain.IntModify();

            Console.WriteLine("输入目录名称: ");
            strDir = Console.ReadLine();
            
                Console.WriteLine("输入文件名称: ");
                strFile = Console.ReadLine();


                switch (intMaintain)
                {
                    case 1:
                        myMaintain.CreateNewFile(strDir, strFile);
                        strResult = "文件新建完成";
                        break;
                    case 2:
                        myMaintain.DeleteFile(strDir, strFile);
                        strResult = "文件删除完成";
                        break;
                    case 3:
                        string strFileCopy;
                        Console.WriteLine("输入复制文件名称: ");
                        strFileCopy = Console.ReadLine();

                        myMaintain.CopyFile(strDir, strFile, strFileCopy);
                        strResult = "文件复制完成";
                        break;
                    case 4:
                        string strFileMove;
                        Console.WriteLine("输入移动文件名称: ");
                        strFileMove = Console.ReadLine();
                        myMaintain.MoveFile(strDir, strFile, strFileMove);
                        strResult = "文件移动完成";
                        break;
                }
                Console.WriteLine(strResult);

            }
            Console.ReadLine();
        }
        private void CreateNewFile(string strDir , string strFileName)
        {
            try
            {
                FileInfo myFileInfo = new FileInfo(strDir + strFileName);
                FileStream myFileStream = myFileInfo.Create();
                myFileStream.Close(); 
            }
            catch
            {
                Console.WriteLine("错误的文件格式!!");
            }
        }
        private void CopyFile(string strDir,string strFilename1,string strFilename2)
        {
            try
            {
                FileInfo myFileInfo = new FileInfo(strDir + strFilename1);
                myFileInfo.CopyTo(strDir + strFilename2);
               
            }
            catch
            {
                Console.WriteLine("文件复制错误！！！");
            }
        }
        private void DeleteFile(string strDir,string strFilename)
        {
            try
            {
                bool blnFileExist;
                blnFileExist = File.Exists(strDir + strFilename);
                if(!blnFileExist)
                {
                    Console.WriteLine("文件不存在!!");
                    return;
                }
                FileInfo myFileInfo = new FileInfo(strDir + strFilename);
                myFileInfo.Delete();
            }
            catch
            {
                Console.WriteLine("删除文件错误!!");
            }
        }
        private void MoveFile(string strDir, string strFilename1,string strFilename2)
        {
            try
            {
                FileInfo myFileInfo = new FileInfo(strDir + strFilename1);
                bool blnFileExist;
                blnFileExist = myFileInfo.Exists;
                if(!blnFileExist)
                {
                    Console.WriteLine("文件不存在!!");
                    return;
                }
                myFileInfo.MoveTo(strDir + strFilename2);
            }
            catch
            {
                Console.WriteLine("文件移动错误!!");
            }
        }
    }
}
