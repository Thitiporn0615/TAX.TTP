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
    public partial class Group2 : Form
    {
        
        public double sum2;//เก็บค่าG2 
     


        public Group2()
        {
            InitializeComponent();
        }

        private void Group2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ถัดไป
        {
            sum2 = 0;//ค่าเริ่มต้น
            double social_security = Convert.ToInt32(numericUpDown4.Value); //ประกันสังคม
            double life_security = Convert.ToInt32(numericUpDown8.Value); //ประกันชีวิต
            double heal_security = Convert.ToInt32(numericUpDown1.Value); //ประกันสุขภาพ
            double spouse_security = Convert.ToInt32(numericUpDown2.Value); //ประกันคู่สมรส
            double FM_security = Convert.ToInt32(numericUpDown9.Value); //ประกันบิดามารดา
            double provident_fund = Convert.ToInt32(numericUpDown3.Value); //กองทุนสำรองเลี้ยงชีพ
            double KOH = Convert.ToInt32(numericUpDown10.Value); //กอช.
            double teacher_fund = Convert.ToInt32(numericUpDown5.Value); //กองทุนครู
            double pension = Convert.ToInt32(numericUpDown11.Value); //เบี้ยบำนาญ
            double LTF = Convert.ToInt32(numericUpDown7.Value);
            double RMF = Convert.ToInt32(numericUpDown6.Value);
            double TMP = life_security + heal_security;//ประกันตนเอง+สุขภาพ
            double TMP2 = provident_fund + teacher_fund + RMF + KOH;//สำรองเลี้ยงชีพ+กองทุนครู+RMF+กอช.

            if (TMP > 100000)//ประกันตนเอง+สุขภาพ
            {
                TMP = 100000;
            }
            if ((Program.money * 0.15) > 490000)//กองทุนสำรองเลี้ยงชีพ
            {
                numericUpDown3.Value = 490000;
            }
            else
            {
                numericUpDown3.Maximum = Convert.ToInt32(Program.money * 0.15);//ถ้าไม่ใช่ ก็ตามที่กรอกมา 
            }
            if ((Program.money * 0.15) > 500000)//กองทุนครู
            {
                numericUpDown5.Value = 500000;
            }
            else
            {
                numericUpDown5.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)//RmF
            {
                numericUpDown6.Value = 500000;
            }
            else
            {
                numericUpDown6.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)//LTF
            {
                numericUpDown7.Value = 500000;
            }
            else
            {
                numericUpDown7.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if ((Program.money * 0.15) > 500000)//เบี้ยบำนาญ
            {
                numericUpDown11.Value = 500000;
            }
            else
            {
                numericUpDown11.Maximum = Convert.ToInt32(Program.money * 0.15);
            }
            if (TMP2 > 500000)//ตัวแปรที่รวมกันทั้ง 4 ต้องไม่เกิน 500000
            {
                TMP2 = 500000;
            }
            sum2 = sum2 + TMP2 + TMP + social_security + spouse_security + FM_security + pension + LTF;//ผลรวมของG2

            Group3 gp3 = new Group3();
            Program.sum2 = sum2;
            this.Hide();//ออก
            gp3.ShowDialog();//โชว์ G3





        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group1 G1 = new Group1();
            this.Hide();
            G1.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//คู่สมรสมีรายได้
        {
            if (radioButton2.Checked)
            {
                numericUpDown2.Enabled = true;//เปิด
            }
            else
            {
                numericUpDown2.Enabled = false;//ปิด
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//คู่สมรสไม่มีรายได้
        {
            if (radioButton2.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
