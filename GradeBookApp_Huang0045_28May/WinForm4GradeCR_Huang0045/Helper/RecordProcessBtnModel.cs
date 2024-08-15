using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SharedProject4GB_Huang0045;
using ClassLibrary_Huang0045.FileStreams;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinForm4GradeCR_Huang0045.Helper
{
    public class RecordProcessBtnModel
    {
        Frm4GradeCR frm4GradeCR;
        public int count_InChkedLB = 0;
        char[] delim = { ';', ',', '\t', '.', '@' };
        static int fileRecordIndex = 2;//???/
        public string outputFile = "SortGrade" + fileRecordIndex;
        public string initialDir = @"D:\Test\";
        public BinaryFormatter writeformatter = new BinaryFormatter();
        OpenReadOrWriteWithCheck_Hua0045 myRnW, myRrWSaveFile;
        public RecordProcessBtnModel(Frm4GradeCR _frm4GradeCR)
        {
            frm4GradeCR = _frm4GradeCR;
        }
        public void btnKeyIntoListBox()
        {
            try
            {
                /**
                 * below 3 lines can e replaced by using Library (ClassLibrary_xi1064.InputCheckValidation.DataCheckValidation)
                 * Then there is need to do try-catch here
                 * 
                 * Ask students to imlement it!
                 */
                frm4GradeCR.recordConsidered.RegularMark = double.Parse(frm4GradeCR.profileTextBoxes[((int)GradeRecordEnum.REGULAR_MARK) - 1].Text);
                frm4GradeCR.recordConsidered.MidTermMark = double.Parse(frm4GradeCR.profileTextBoxes[((int)GradeRecordEnum.MIDTERM_GRADE) - 1].Text);
                frm4GradeCR.recordConsidered.FinalExamMark = double.Parse(frm4GradeCR.profileTextBoxes[((int)GradeRecordEnum.FINALEXAME_GRADE) - 1].Text);

                frm4GradeCR.checkedListBox_Create.Items.Add(frm4GradeCR.recordConsidered.ToBaseString());
                /*
                 * Add the studentID (key) of grade recorded, already keyed into CheckedListBox,
                 * into list (i,e, studentIDList_InChkedLB here)
                 * to prevent from later beiing selected again by user
                 * Then remove the studentID (key) from comboBox
                 */
                frm4GradeCR.studentIDList_InChkedLB.Add(frm4GradeCR.cbKey.SelectedItem.ToString());
                count_InChkedLB++;
                frm4GradeCR.cbKey.Items.Remove(frm4GradeCR.cbKey.SelectedItem);//To remove currently selected item in ComboBox;

                frm4GradeCR.clearTextBoxes();
            }
            catch (ArgumentOutOfRangeException aoorEx)
            {
                MessageBox.Show(aoorEx.Message + "\r\nCorrect your data!!", "ArgumentOutOfRangeException", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }//end try_catch
            catch (FormatException fEx)
            {
                MessageBox.Show(fEx.Message + "\r\nCorrect your data \r\nvia \r\nSelecting or Adding!!", "FormatException", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }//end btnKeyIntoListBox()

        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The<see cref="EventArgs"/>instance containing the event data.</param>
        public void btnDeleteFromListBox()
        {
            string[] tokens;
            foreach (var item in frm4GradeCR.checkedListBox_Create.CheckedItems.OfType<string>().ToList())
            {
                MessageBox.Show("item.Tostring()=" + item.ToString());
                tokens = item.ToString().Split(delim);
                MessageBox.Show("tokens[0]=" + tokens[0]);

                frm4GradeCR.checkedListBox_Create.Items.Remove(item);
                frm4GradeCR.studentIDList_InChkedLB.Remove(tokens[0]);//remove the studentID (key) of grade recorded in CheckedList, in list, then it can be selected again by user
                count_InChkedLB--;

                frm4GradeCR.cbKey.Items.Add(tokens[0]);
            }
        }
        /// <summary>
        /// Handles the click event of the btnSaveFile control.
        /// </summary>
        /// <param name="sender">The<see cref="EventArgs"/>instance containing the event data.</param>
        /// <param name="e">The<see cref="EventArgs"/>instance containing the event data.</param>


        public void btnSaveFile4ListBox()
        {
            outputFile = initialDir + "GradesInCheckedListBox" + fileRecordIndex;
            //outputFile = initialDir;
            frm4GradeCR.rdBtn_Create.Checked = true;//for default

            if (frm4GradeCR.checkedListBox_Create.Items.Count != 0)
            {
                if (frm4GradeCR.rdBtn_txtSave.Checked)
                {
                    outputFile += "";
                    if (frm4GradeCR.rdBtn_Create.Checked)
                        myRrWSaveFile = new OpenReadOrWriteWithCheck_Hua0045(false, true, null, outputFile, (int)(FileStreamBasedEnumNew.TEXT_BASED), FileMode.Create
                            , frm4GradeCR.fileChooserSavingProfile, initialDir);

                    else
                        myRrWSaveFile = new OpenReadOrWriteWithCheck_Hua0045(false, true, null, outputFile, (int)(FileStreamBasedEnumNew.TEXT_BASED), FileMode.Append
                             , frm4GradeCR.fileChooserSavingProfile, initialDir);

                    foreach (var item in frm4GradeCR.checkedListBox_Create.Items)
                    {
                        myRrWSaveFile.fileWriter.WriteLine(item);
                    }
                    myRrWSaveFile.CloseFile();
                }
                else
                {
                    outputFile += ".dat";
                    if (frm4GradeCR.rdBtn_Create.Checked)
                        myRrWSaveFile = new OpenReadOrWriteWithCheck_Hua0045(false, true, null, outputFile, (int)(FileStreamBasedEnumNew.BYTE_BASED), FileMode.Create);
                    else
                        myRrWSaveFile = new OpenReadOrWriteWithCheck_Hua0045(false, true, null, outputFile, (int)(FileStreamBasedEnumNew.BYTE_BASED), FileMode.Append);

                    foreach (var item in frm4GradeCR.checkedListBox_Create.Items)
                    {
                        string stringTmp = item.ToString();
                        string[] strTmpArr = stringTmp.Split(delim);
                        GradeRecord record = new GradeRecord(strTmpArr[0], strTmpArr[1], strTmpArr[2], strTmpArr[3], double.Parse(strTmpArr[4]),
                            double.Parse(strTmpArr[5]), double.Parse(strTmpArr[6]));
                        writeformatter.Serialize(myRrWSaveFile.output, record);
                    }
                    myRrWSaveFile.CloseFile();
                }


                frm4GradeCR.studentIDList_InChkedLB.Clear();
                frm4GradeCR.checkedListBox_Create.Items.Clear();

                frm4GradeCR.cbKey.Enabled = false;
                MessageBox.Show("\r\n Rw-set Basic Records in ComboBox!\r\n(i.e. Re-read basic records from file)", "Need to Initialize Basic Data Again!", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("What a silly thing with nothing to be saved into file!");
            }
        }//end btnSaveFile_Click
    }//end class RecordProcessBtnModel
}//end namespace WinForm4GradeCR_Huang0045.Helper
