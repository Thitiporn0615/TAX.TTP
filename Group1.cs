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
    public partial class Group1 : Form
    {
        
        public int sum ; //เก็บผลรวม G1




        public Group1()//เช็คการทำงาน
        {
            InitializeComponent(); //บุตร
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }





        

        private void checkbefore2561_CheckedChanged(object sender, EventArgs e)//ก่อน61
        {
            if (checkbefore2561.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkafter2561_CheckedChanged(object sender, EventArgs e)//หลัง61
        {
            if (checkafter2561.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void motherMe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void fatherSpouse_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void motherSpouse_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pregnant_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//ปุ่มถัดไป
        {
            sum = 0;//เป็นการเช็คเงื่อนไข
            if (comboBox1.Text == "มีคู่สมรส แต่คู่สมรสไม่มีรายได้")
            {
                sum = sum + 120000;
            }
            else
            {
                sum = sum + 60000;
            }
            if (checkbefore2561.Checked)//ก่อน61 ถ้าเลือก
            {
                sum = sum + (Convert.ToInt32(textBox1.Text) * 30000);
            }
            else if (checkafter2561.Checked)//หลัง61
            {
                if (Convert.ToInt32(textBox1.Text) == 0)
                {
                    sum = sum + ((Convert.ToInt32(textBox2.Text) - 1) * 60000) + 30000;
                }
                else
                {
                    sum = sum + (Convert.ToInt32(textBox2.Text) * 60000);
                }
            }
            else
            {
                sum = sum + 0;
            }
            if (fatherMe.Checked )
            {
                sum = sum + 30000;
            }
            if ( motherMe.Checked)
            {
                sum = sum + 30000;
            }
            if (fatherSpouse.Checked)
            {
                sum = sum + 30000;
            }
            if (motherSpouse.Checked)
            {
                sum = sum + 30000;
            }
            sum = sum + Convert.ToInt32(pregnant.Value) + (Convert.ToInt32(disabled.Value) * 60000);//pregnant ฝากครรภ์ //Convert คนพิการ                                                                           
            Group2 gp2 = new Group2();//โชว์ G2
            Program.sum1 = sum;//การส่งค่าข้ามฟอร์ม
            this.Hide();//ปิด
            gp2.ShowDialog();//ไป G2
        }
        
        private void button2_Click(object sender, EventArgs e)//ย้อนกลับ
        {
           Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
