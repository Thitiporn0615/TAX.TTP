using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static double sum; 
        public static string name;
        public static double sum58;
        public static double sum62;
        public static double sum1;//g1
        public static double sum2;//g2
        public static double sum3;//g3
        public static double sum4;//g4
        public static double sum5;//g5
        public static double money;//ผลรวมทั้งหมด
    }
}
