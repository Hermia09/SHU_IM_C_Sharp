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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using BankLibrary_huang0045;
using ClassLibrary_230045.HelperFunction.InputCheckValidation;

namespace ReadFile_huang0045
{
    public partial class ReadFile_huang0045 : BankUIForm
    {
        // object for deserializing RecordSerializable in binary format
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input; // stream for reading from a file

        public ReadFile_huang0045()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file
            DialogResult result; // result of OpenFileDialog
            string fileName; // name of file containing data

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // get specified name
            }

            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                // show error if user specified invalid file
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // create FileStream to obtain read access to file
                    input = new FileStream(
                       fileName, FileMode.Open, FileAccess.Read);

                    btn_openFile.Enabled = false; // disable Open File button
                    btn_nextRecord.Enabled = true;  // enable Next Record button
                }
            }
        }// end btn_openFile_Click

        private void btn_nextRecord_Click(object sender, EventArgs e)
        {
            // deserialize RecordSerializable and store data in TextBoxes
            try
            {
                // get next RecordSerializable available in file
                RecordSerializable record =
                   (RecordSerializable)reader.Deserialize(input);

                // store RecordSerializable values in temporary string array
                var values = new string[] {
               record.Account.ToString(),
               record.FirstName.ToString(),
               record.LastName.ToString(),
               record.Balance.ToString()
            };

                // copy string-array values to TextBox values
                SetTextBoxValues(values);
            }
            catch (SerializationException)
            {
                input?.Close(); // close FileStream
                btn_openFile.Enabled = true; // enable Open File button
                btn_nextRecord.Enabled = false; // disable Next Record button

                ClearTextBoxes();

                // notify user if no RecordSerializables in file
                MessageBox.Show("No more records in file", string.Empty,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//end btn_nextRecord_Click


}
