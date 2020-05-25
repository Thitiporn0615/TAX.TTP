using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    public partial class Total : Form
    {
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();//ออกจากโปรแกรม
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group5 G5 = new Group5();
            this.Hide();
            G5.ShowDialog();
        }

        public Total()
        {
            InitializeComponent();
        }

        private void Total_Load(object sender, EventArgs e)
        {
            double total = Program.money - (Program.sum1 + Program.sum2 + Program.sum3 + Program.sum4 + Program.sum5);//รายได้สุทธิ
            textBox1.Text = Program.sum1.ToString();
            textBox2.Text = Program.sum2.ToString();
            textBox3.Text = Program.sum3.ToString();
            textBox4.Text = Program.sum4.ToString();
            textBox5.Text = Program.sum5.ToString();
            textBox6.Text = (Program.sum1 + Program.sum2 + Program.sum3 + Program.sum4 + Program.sum5).ToString();//ลดหย่อนทั้งหมด
            if (total < 0)
            {
                total = 0;//ลดหย่อนเกินเงินเดือน มันจะติดลบก็จะให้มีค่าเป็น 0
            }
            textBox7.Text = total.ToString();//แสดงรายได้สุทธิ
            if (total >= 0 && total <= 150000)//ไม่ต้องจ่าย
            {
                total = 0;
            }
            else if (total > 150000 && total <= 300000)
            {
                total = (total - 150000) * 0.05;
            }
            else if (total > 300000 && total <= 500000)
            {
                total = (total - 300000) * 0.1 + 7500;
            }
            else if (total > 500000 && total <= 750000)
            {
                total = (total - 500000) * 0.15 + 27500;
            }
            else if (total > 750000 && total <= 1000000)
            {
                total = (total - 750000) * 0.2 + 65000;
            }
            else if (total > 1000000 && total <= 2000000)
            {
                total = (total - 1000000) * 0.25 + 115000;
            }
            else if (total > 2000000 && total <= 5000000)
            {
                total = (total - 2000000) * 0.3 + 365000;
            }
            else if (total > 5000000)
            {
                total = (total - 5000000) * 0.35 + 1265000;
            }
            textBox8.Text = total.ToString();//แสดงภาษีที่ต้องจ่ายทั้งหมด
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
