﻿using System;
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
    public partial class Group4 : Form
    {
        public double sum4;
        public Group4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum4 = 0;
            sum4 = sum4 + (Convert.ToInt32(numericUpDown4.Value) * 2);//การศึกษา
            sum4 = sum4 + (Convert.ToInt32(numericUpDown1.Value) * 2);//พยาบาล
            sum4 = sum4 + (Convert.ToInt32(numericUpDown2.Value) * 2);//กีฬา
            sum4 = sum4 + (Convert.ToInt32(numericUpDown3.Value) * 2);//สาธารณะประโยชน์
            sum4 = sum4 + Convert.ToInt32(numericUpDown5.Value);//การเมือง
            sum4 = sum4 + Convert.ToInt32(numericUpDown6.Value);//พายุปานึก
            Group5 gp5 = new Group5();
            Program.sum4 = sum4;//เก็บค่า
            this.Hide();
            gp5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//ย้อนกลับ
        {
            Group3 G3 = new Group3();
            this.Hide();
            G3.ShowDialog();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
