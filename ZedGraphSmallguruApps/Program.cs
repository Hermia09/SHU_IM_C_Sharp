using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZedGraphTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string ChartTitle = "Grade";
            string strData = "20\t4\t10\t6\t15\t"; string strLabels4LineBar = "9\t8\t7\t6\t5\t";
            string strLabels4Pie = "A\tB\tC\tD\tF\t";
            string txtXTitle = "Grade_Level";
            string txtYTitle = "Number_Students", txtXUnit = "Level", txtYUnit = "Student Count";
           


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmZedGraph4SmallGuruModified(strData, strLabels4Pie, strLabels4LineBar, ChartTitle, true, true, true,
                        txtXTitle, txtYTitle, txtXUnit, txtYUnit));
        }
    }
}