using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_1A2B
{
    public partial class Frm1A2B : Form
    {
        private int[] ans = new int[10];
        private String[] input = new String[10];
        private Random rnd = new Random();
        //Step.2
        private String numans;
        //Step.3
        private String numinput;
        public Frm1A2B()
        {
            InitializeComponent();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i <= 3; i++)
            {
                ans[i] = rnd.Next(1, 9);
                for (int j = 0; j < i; j++) 
                {
                    while (ans[i] == ans[j]) 
                    {
                        j = 0;
                        ans[i] = rnd.Next(1, 9);
                    }
                }
                    
            }
            MessageBox.Show("Game Start!!!");
            btnEnter.Enabled = true;
            btnExit.Enabled = true;
            btnAnswer.Enabled = true;
            btnGameStart.Enabled = false;
        }//end btnGameStart_Click

        private void btnEnter_Click(object sender, EventArgs e)
        {
            numinput = "";
            for (int i = 0; i <= 3; i++)
            {
                input[i] = txt_InputNumber.Text.Substring(i, 1);
                numinput += input[i];
            }

            //Can not enter duplicate numbers
            if (numinput[0] == numinput[1] || numinput[0] == numinput[2] || numinput[0] == numinput[3]
                || numinput[1] == numinput[2] || numinput[1] == numinput[3] || numinput[2] == numinput[3])
            {
                MessageBox.Show("Can not enter duplicate numbers!");
            }//end if
            else 
            {
                int a = 0, b = 0;
                for (int i = 0; i <= 3; i++) 
                {
                    for (int k = 0; k <= 3; k++)
                    {
                        if (input[i] == ans[k].ToString()) 
                        {
                            if (i == k)
                            {
                                a++;
                            }
                            else if (i != k) 
                            {
                                b++;
                            }
                        }
                    }
                }
                listBox_Input.Items.Add(numinput + "-->" + a.ToString() + "A" + b.ToString() + "B\n");
                if (a == 4 && b == 0) 
                {
                    MessageBox.Show("You Win!!!!");
                    btnEnter.Enabled = false;
                }
                txt_InputNumber.Text = "";
                lbl_InputNumber.Text = numinput;
            }//end else
        }//end btnEnter_Click

        //Step.4 --> Button exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }//end btnExit_Click

        //Step.5 --> Button show the answer
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            String answer = "";
            for (int i = 0; i <= 3; i++) 
            {
                answer += ans[i];
            }
            MessageBox.Show("The answer is" + answer);
        }//end btnAnswer_Click

    }//end class Frm1A2B

}//end namespace WindowsFormsApp_1A2B
