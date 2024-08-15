using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrary_huang0045
{
    public partial class BankUIForm : Form
    {
        // parameterless constructor
        public BankUIForm()
        {
            InitializeComponent();
        }

        private void btn_SaveAs_Click(object sender, EventArgs e)
        {

        }
        protected int TextBoxCount { get; set; } = 4; // number of TextBoxes

        // enumeration constants specify TextBox indices
        public enum TextBoxIndices { Account, First, Last, Balance }

        
        
        // clear all TextBoxes
        public void ClearTextBoxes()
        {
            // iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                // if Control is TextBox, clear it
                (guiControl as TextBox)?.Clear();
            }
        }

        // set text box values to string-array values
        public void SetTextBoxValues(string[] values)
        {
            // determine whether string array has correct length
            if (values.Length != TextBoxCount)
            {
                // throw exception if not correct length
                throw (new ArgumentException(
                   $"There must be {TextBoxCount} strings in the array",
                   nameof(values)));
            }
            else // set array values if array has correct length
            {
                // set array values to TextBox values
                TxtBox_Account.Text = values[(int)TextBoxIndices.Account];
                TxtBox_FirstName.Text = values[(int)TextBoxIndices.First];
                TxtBox_LastName.Text = values[(int)TextBoxIndices.Last];
                TxtBox_Balance.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[] {
            TxtBox_Account.Text, TxtBox_FirstName.Text,
            TxtBox_LastName.Text, TxtBox_Balance.Text};
        }
    }
}
