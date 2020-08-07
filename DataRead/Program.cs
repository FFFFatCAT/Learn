using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace DataRead
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        public static List<String> ElementsId = new List<String>(); //单元编号List初始化
        public static List<Double[,]> UnitStress = new List<Double[,]>(); //单位应力List初始化
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //打开Form1窗口
        }
        /// <summary>
        /// 读取txt数据，拆分每一行，剔除非数据行
        /// </summary>
        /// <param name="FilePath"></param>
        public static void TxtRead(string FilePath)
        {
            // 读取文件的源路径及其读取流
            StreamReader srReadFile = new StreamReader(FilePath);
            // 变量初始化
            List<String> ElementsId = new List<String>();
            // List<double[]> UnitStress = new List<double[]>();
            // 读取流直至文件末尾结束
            while (!srReadFile.EndOfStream)
            {
                string strReadLine = srReadFile.ReadLine(); //读取每行数据
                if (strReadLine.Length == 48) // 根据每行数据长度，判断是否包含单元及应力信息
                {
                    // String temp = strReadLine.Substring(0,9);
                    // 每行前9个字符串为单元编号，存储到对应List
                    Program.ElementsId.Add(strReadLine.Substring(0, 9));
                    // 每行其余数据分割为3组，存储为单元应力矩阵
                    double[,] temp = new double[1,3];
                    for (int a = 0; a < 3; a += 1)
                    {
                        temp[0,a] = Double.Parse(strReadLine.Substring(9 + a * 13, 13));
                    }
                    Program.UnitStress.Add(temp);
                    // Console.WriteLine(ElementsId.Last()); //屏幕最后添加的单元ID
                    // Console.WriteLine(strReadLine); //屏幕打印每行数据
                }
            }
            // 关闭读取流文件
            srReadFile.Close();
            //Console.ReadKey();
        }
    }

}
