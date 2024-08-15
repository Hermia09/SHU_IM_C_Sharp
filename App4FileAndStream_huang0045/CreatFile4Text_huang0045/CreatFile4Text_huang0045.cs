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
using ClassLibrary_230045.HelperFunction.InputCheckValidation;

namespace CreatFile4Text_huang0045
{
    public partial class CreatFile4Form : BankUIForm
    {
        private StreamWriter fileWriter; // 建立讀檔器元件
        DataCheckValidation dataCheck = new DataCheckValidation(false, true);
        public CreatFile4Form()
        {
            InitializeComponent();
        }// end CreatFile4Form

        private void btn_SaveAs_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to save file
            DialogResult result; // result of SaveFileDialog
            string fileName; // name of file containing data

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file 
                result = fileChooser.ShowDialog(); //對話器
                fileName = fileChooser.FileName; // name of file to save data
            }

            // ensure that user clicked "OK"
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
                    // save file via FileStream if user specified valid file
                    try
                    {
                        // 建立讀檔物件串流
                        var output = new FileStream(fileName,
                           FileMode.OpenOrCreate, FileAccess.Write);

                        // sets file to where data is written
                        fileWriter = new StreamWriter(output);

                        // disable Save button and enable Enter button
                        btn_SaveAs.Enabled = false;
                        btn_Enter.Enabled = true;
                    }
                    catch (IOException)
                    {
                        // notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }// end btn_SaveAs_Click

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter?.Close(); // close StreamWriter and underlying file
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Exit();
        }// end btn_Exit_Click

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            // store TextBox values string array
            string[] values = GetTextBoxValues();
            bool checkAll = false;

            // determine whether TextBox account field is empty
            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.Account]))
            {
                // store TextBox values in Record and output it
                try
                {
                    // get account-number value from TextBox
                    int accountNumber =
                       int.Parse(values[(int)TextBoxIndices.Account]);

                    // determine whether accountNumber is valid
                    if (accountNumber > 0)
                    {
                        //檢查輸入字串是否是空的
                        checkAll = dataCheck.CheckStringNotEmpty(values[(int)TextBoxIndices.First], lbl_FirstName.Text);
                        if (checkAll) checkAll = dataCheck.CheckStringNotEmpty(values[(int)TextBoxIndices.Last], lbl_LastName.Text);

                        if (checkAll)
                        {
                            // Record containing TextBox values to output
                            var record = new Record(accountNumber,
                                values[(int)TextBoxIndices.First],
                                values[(int)TextBoxIndices.Last],
                                decimal.Parse(values[(int)TextBoxIndices.Balance]));

                            // write Record to file, fields separated by commas
                            fileWriter.WriteLine(
                               $"{record.Account},{record.FirstName}," +
                               $"{record.LastName},{record.Balance}");
                        }
                        
                    }
                    else
                    {
                        // notify user if invalid account number
                        MessageBox.Show("Invalid Account Number", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Writing to File", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearTextBoxes(); // clear TextBox values
        }// end enterButton_Click

    }// end class CreatFile4Form : BankUIForm
}
