using System;
using System.Collections.Generic;
using System.Text;

namespace Gysjjt
{
    class Program
    {
        static void Main(string[] args)
        {
            string strWeb = "http://e.gysjjt.com";  　//定义一个存放网址的字符串变量
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(strWeb);　//实例化系统启动信息的对象
            System.Diagnostics.Process.Start(strWeb);　　
        }
    }
}
