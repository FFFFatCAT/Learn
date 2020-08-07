using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLearn
{
    public partial class Form1 : Form
    {
        private Form2 objfrm;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.MaximumSize = new Size(400, 400); //最大尺寸
            //this.MinimumSize = new Size(300, 300); //最小尺寸
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 objfrm = new Form2(); //实例化窗口2
            
            //objfrm.Location = new Point(0, 0);
            //objfrm.StartPosition = FormStartPosition.Manual; //设置初始位置
            objfrm.Show(); //显示窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet; //设置窗口背景颜色
        }

        private void label1_Click(object sender, EventArgs e)
        {

            //if (this.label1.Parent == this)
            //{
            //    objfrm.Controls.Add(this.label1);
            //    this.label1.Text = "返回";
            //}
            //else
            //{
            //    this.Controls.Add(this.label1);
            //    this.label1.Text = "开始移动";
            //}
        }
    }
}
