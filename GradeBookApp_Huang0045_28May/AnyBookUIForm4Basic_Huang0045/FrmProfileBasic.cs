using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyBookUIForm4Basic_Huang0045
{
    public partial class FrmProfileBasic : Form
    {
        public TextBox[] profileTextBoxes;
        public Label[] profileLabels;
        public const int BASIC_PROFILE_TEXTBOX_ON = 9;
        public FrmProfileBasic()
        {
            InitializeComponent();
            initializeAllTextBox();
        }//end FrmProfileBasic()

        public void initializeAllTextBox()
        {
            profileTextBoxes = new TextBox[BASIC_PROFILE_TEXTBOX_ON - 1];
            TextBox[] profileTextBoxArray = { txtBox1st, txtBox2nd, txtBox3rd, txtBox4th, txtBox5th, txtBox6th, txtBox7th, txtBox8th };
            profileTextBoxes = profileTextBoxArray;

            profileLabels = new Label[BASIC_PROFILE_TEXTBOX_ON];
            Label[] profileLabelArray = { lblKey, lbl1st, lbl2nd, lbl3rd, lbl4th, lbl5th, lbl6th, lbl7th, lbl8th };
            profileLabels = profileLabelArray;
        }// end initializeAllTextBox() 

        public void clearTextBoxes()
        {
            foreach (TextBox txtbox in profileTextBoxes)
            {
                txtbox.Text = "";
            }
        }// end clearTextBoxes() 

        public void processTabPage(bool isListBox)
        {
            TabPage page4chkdListbx = tabCtrlRecords.TabPages[0];
            TabPage page4dataGridview = tabCtrlRecords.TabPages[1];

            if (isListBox)
            {
                // page1
                page4chkdListbx.Visible = true;
                page4chkdListbx.Enabled = true;

                // page2
                //page4dataGridview.Visible = true;
                page4dataGridview.Enabled = false;

                page4dataGridview.Hide();
                page4chkdListbx.Show();
            }
            else
            {
                // page2
                page4dataGridview.Visible = true;
                page4dataGridview.Enabled = true;

                // page1
                //page4chkdListbx.Visible = true;
                page4chkdListbx.Enabled = false;

                page4chkdListbx.Hide();
                page4dataGridview.Show();
            }
        }//end processTabPage

    }//end class
}//end namespace
