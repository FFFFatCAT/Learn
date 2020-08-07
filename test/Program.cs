using System;
using System.Collections.Generic;//引用命名空间
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)//主方法，程序入口
        {
            //ATM存取款
            Console.WriteLine("####欢迎登录XXXX银行####");
            Console.Write("请输入账号："); //输出
            string account = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();
            if (account == "zhangsan" && password == "123456")
            {
                Console.WriteLine("登录成功！");
                Console.WriteLine("请选择业务：1、查询余额 2、取款 3、存款 4、转账");
                int method = int.Parse(Console.ReadLine());
                switch (method)
                {
                    case 1:
                        Console.WriteLine("您的余额为1000");
                        break;
                    case 2:
                        Console.WriteLine("请输入取款金额");
                        break;
                    case 3:
                        Console.WriteLine("请输入存款金额");
                        break;
                    case 4:
                        Console.WriteLine("请输入转账金额");
                        break;
                }

            }
            else
            {
                Console.WriteLine("登录失败");
            }
                

            Console.ReadLine();//等待输入
        }
    }
}
