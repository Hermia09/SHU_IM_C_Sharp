using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BankLibrary_huang0045;

namespace Credit_inquiry_huang0045
{
    public partial class CreditInquiryForm : Form
    {
        public CreditInquiryForm()
        {
            InitializeComponent();
        }

        private FileStream input; // maintains the connection to the file
        private StreamReader fileReader; // reads data from text file    

       

        private void Btn_done_Click(object sender, EventArgs e)
        {
            // close file and StreamReader
            try
            {
                fileReader?.Close(); // close StreamReader and underlying file
            }
            catch (IOException)
            {
                // notify user of error closing file
                MessageBox.Show("Cannot close file", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }// end Btn_done_Click

        private void Btn_open_Click(object sender, EventArgs e)
        {
            // create dialog box enabling user to open file         
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // exit event handler if user clicked Cancel
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // create FileStream to obtain read access to file
                    input = new FileStream(fileName,
                       FileMode.Open, FileAccess.Read);

                    // set file from where data is read
                    fileReader = new StreamReader(input);

                    // enable all GUI buttons, except for Open File button
                    Btn_open.Enabled = false;
                    Btn_credit.Enabled = true;
                    Btn_debit.Enabled = true;
                    Btn_zero.Enabled = true;
                }
            }
        }// end Btn_open_Click

        private void Btn_credit_Click(object sender, EventArgs e)
        {

        }// end Btn_credit_Click

        private bool ShouldDisplay(decimal balance, string accountType)
        {
            if (balance > 0M && accountType == "Credit Balances")
            {
                return true; // should display credit balances
            }
            else if (balance < 0M && accountType == "Debit Balances")
            {
                return true; // should display debit balances
            }
            else if (balance == 0 && accountType == "Zero Balances")
            {
                return true; // should display zero balances
            }

            return false;
        }//end ShouldDisplay

        private void Btn_GetBalance_Click(object sender, EventArgs e)
        {
            // convert sender explicitly to object of type button
            Button senderButton = (Button)sender;

            // get text from clicked Button, which stores account type
            string accountType = senderButton.Text;

            // read and display file information
            try
            {
                // go back to the beginning of the file
                input.Seek(0, SeekOrigin.Begin);

                txtBox_display.Text =
                   $"Accounts with {accountType}{Environment.NewLine}";

                // traverse file until end of file
                while (true)
                {
                    // get next Record available in file
                    string inputRecord = fileReader.ReadLine();

                    // when at the end of file, exit method
                    if (inputRecord == null)
                    {
                        return;
                    }

                    // parse input
                    string[] inputFields = inputRecord.Split(',');

                    // create Record from input
                    var record =
                       new Record(int.Parse(inputFields[0]), inputFields[1],
                          inputFields[2], decimal.Parse(inputFields[3]));

                    // determine whether to display balance
                    if (ShouldDisplay(record.Balance, accountType))
                    {
                        // display record
                        txtBox_display.AppendText($"{record.Account}\t" +
                           $"{record.FirstName}\t{record.LastName}\t" +
                           $"{record.Balance:C}{Environment.NewLine}");
                    }
                }// end while
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot Read File", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// end Btn_GetBalance

    }//end class CreditInquiryForm : Form
}//end namespace
