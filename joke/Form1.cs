using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.Text = "唐静是一只快乐的傻狍子！";
            this.button2.Text = "唐静是一个大美女！";
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.Text = "唐静是一个大美女！";
            this.button2.Text = "唐静是一只快乐的傻狍子！";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没错，唐静就是一只大傻狍子！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没错，唐静就是一只大傻狍子！");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("我是一只傻狍子！", "你是不是傻狍子？", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("88傻狍子！");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            System.Random rand = new System.Random();
            int x = rand.Next(0, 380);
            int y = rand.Next(0, 200);
            this.button3.Location = new Point(x, y);
        }
    }
}
