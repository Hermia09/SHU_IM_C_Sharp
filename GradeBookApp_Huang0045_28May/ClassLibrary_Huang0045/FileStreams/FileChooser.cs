using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClassLibrary_Huang0045.FileStreams
{
    public class FileChooser
    {
        //create and show dialog box enabling user to save file
        public DialogResult result;

        public FileChooser() 
        {

        }

        public string openDialog2ChooseFile(OpenFileDialog fileChooser, string initialDir) 
        {
            string fileName = "";

            using (fileChooser) 
            {
                fileChooser.InitialDirectory = initialDir;
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }//end using
            #region ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("filename selected--> " + fileName);
                }//end else
            }//end if
            #endregion ensure that user clicked "OK"

            else if (result == DialogResult.Cancel) 
            {
                #region notify user if file could not be opened
                MessageBox.Show("There is not file selected or DialogResult.Cancel!", "Exit or Re-select a new file!");
                #endregion notify user if file could not be opened

                return null;
            }//end else if

            return fileName;
        }//end openDialog2ChooseFile
    }//end class FileChooser
}//end namespace ClassLibrary_Huang0045.FileStreams
