using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ClassLibrary_Huang0045.FileStreams;
using GradeLib_Huang0045;
using SharedProject4GB_Huang0045;

namespace WinForm4GradeCR_Huang0045.Helper
{
    public class ReadBasicsInCreateModel//old was 'ReadBasicRecordsModel'
    {
        bool isDEBUG_ON = false;
        WinForm4GradeCR_Huang0045.Frm4GradeCR frm4Grade;
        OpenFileDialog fileChooser4Basics;
        OpenFileDialog fileChooser4OutputFile;
        OpenFileDialog fileChooser4IncompleteRec;

        bool isBasics = true;
        ChecksTextOrByteBased checkIstextByteBased;

        OpenReadOrWriteWithCheck_Hua0045 readORwriteCheck;
        char[] delim = { ';', ',', '\t', '.', '@' };
        char[] delimSimple = { ',' };

        StreamReader fileReader4Input;
        public ReadBasicsInCreateModel(WinForm4GradeCR_Huang0045.Frm4GradeCR _frm4Grade, OpenFileDialog _fileChooser4Basic, OpenFileDialog _fileChooser4IncompleteRec,
            OpenFileDialog _fileChooser4OutputFile)
        {
            frm4Grade = _frm4Grade;
            fileChooser4Basics = _fileChooser4Basic;
            fileChooser4IncompleteRec = _fileChooser4IncompleteRec;
            fileChooser4OutputFile = _fileChooser4OutputFile;
        }//end ReadBasicsInCreateModel

        public void switchModels(CreateFileEnum selectedMenu)
        {
            switch (selectedMenu)
            {
                case CreateFileEnum.CREATE_FROM_NEW:
                    if (frm4Grade.rdBtn_txtSave.Checked)
                        readBasicsFileTextBased(selectedMenu);
                    else
                        readBasicsFileBinaryBased();
                    break;
                case CreateFileEnum.CREATE_FROM_INCOMPLETE:
                    if (frm4Grade.rdBtn_txtSave.Checked)
                        readBasicsFileTextBased(selectedMenu);
                    else
                        readBasicsFileBinaryBased();
                    break;
                case CreateFileEnum.SAVE_FILE:
                    saveFile();
                    break;
            }//end switch
        }//end swithModels

        public void readBasicsFileTextBased(CreateFileEnum selectedMenu)
        {
            #region define/initialize local veriables
            var studentIndex = 0;
            frm4Grade.cbKey.Items.Clear();
            frm4Grade.studentIDListSorted.Clear();
            frm4Grade.basicDataList.Clear();
            var _checkOpenIsTxtOrBinary = -1;
            string inputRecord;
            string[] inputFields;//will store individual pleces of data
            GradeRecord record;
            #endregion define/initialize local veriables
            checkIstextByteBased = new ChecksTextOrByteBased(isBasics, fileChooser4Basics, fileChooser4IncompleteRec);
            _checkOpenIsTxtOrBinary = checkIstextByteBased.checkEnumType_Is_TxtOrBinary(FileStreamBasedEnumNew.TEXT_BASED);
            if (_checkOpenIsTxtOrBinary == (int)(FileStreamBasedEnumNew.TEXT_BASED))
            {
                readORwriteCheck = new OpenReadOrWriteWithCheck_Hua0045(true, false, checkIstextByteBased.fileName4Input, "",
                    (int)(FileStreamBasedEnumNew.TEXT_BASED));
                fileReader4Input = readORwriteCheck.fileReader;
                //inputRecord=fileReader4InputData.ReadLine();//title....

                inputRecord = fileReader4Input.ReadLine();

                while (inputRecord != null)//original using 'if (inputRecord != null)',But...(explain to students why change)
                {
                    inputFields = inputRecord.Split(delimSimple);
                    record = new GradeRecord(inputFields[(int)(GradeRecordEnum.STUDENT_ID)],
                                                      inputFields[(int)(GradeRecordEnum.CLASS_ID)],
                                                      inputFields[(int)(GradeRecordEnum.FIRST_NAME)],
                                                      inputFields[(int)(GradeRecordEnum.LAST_NAME)]);
                    frm4Grade.basicDataList.Add(record);
                    #region debug mode
                    if (isDEBUG_ON)
                    {
                        MessageBox.Show("" + inputFields[(int)(GradeRecordEnum.STUDENT_ID)] + ", " +
                                                      inputFields[(int)(GradeRecordEnum.CLASS_ID)] + ", " +
                                                      inputFields[(int)(GradeRecordEnum.LAST_NAME)] + ", " +
                                                      inputFields[(int)(GradeRecordEnum.FIRST_NAME)]);
                    }

                    #endregion debug mode
                    inputRecord = fileReader4Input.ReadLine();
                    studentIndex++;

                }
                readORwriteCheck.CloseFile();
                putRecordKeyIntoComboBox(selectedMenu);
            }
            else//(_checkOpenIsTxtOrBinary == (int)(FileStreamBasedEnumNew.Binary_BASEED))
            {
                MessageBox.Show("File is not Text_Based!\r\nRe-Choose!!", "Wrong file mechanism",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void putRecordKeyIntoComboBox(CreateFileEnum selectedMenu)
        {
            //sort baisics-list data using ascending order
            frm4Grade.sortedBasicsList =
                GradeBookAdv.Linq_RecordListSortAscendingByStudentID(frm4Grade.basicDataList).ToList();
            //put student-IDs (as record key) into both list and comboBox considered
            foreach (var basicsSorted in frm4Grade.sortedBasicsList)
            {
                if (selectedMenu == CreateFileEnum.CREATE_FROM_NEW)
                {
                    frm4Grade.studentIDListSorted.Add(basicsSorted.StudentID.ToString().Trim());
                    frm4Grade.cbKey.Items.Add(basicsSorted.StudentID.ToString().Trim());

                }
                else
                {
                    addItemIntoComboBox4Incomplete(basicsSorted.StudentID);//make sure no duplication for inccomplete records
                }
            }
            frm4Grade.isCompltedRecords = false;//re-set to default for another new run if needed
            MessageBox.Show("No more record in file", string.Empty,
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addItemIntoComboBox4Incomplete(string _keyToken)
        {

            bool isIncheckedListBox = false;
            //MessageBox.Show("_keyToken(considered)=" + _keyToken.Trim());
            #region add item of interest in comboBox but remove already existed in checkList, to prevent from being selected by user in comboBox
            if (frm4Grade.rdBtn_SearchBinary.Checked)
            {
                //isIncheckedListBox-sortAndSearch.addStudentIDInComboBoxByBinarySearch(frm4Grade, _keyToken, isIncheckedListBox)

            }
            else
            {
                //isIncheckedListBox-sortAndSearch.addStudentIDInComboBoxByLinearSearch(frm4Grade, _keyToken, isIncheckedListBox)

            }
            #endregion add item of interest in comboBox but remove already existed in checkList, to prevent from being selected by user in comboBox
        }

        public void readBasicsFileBinaryBased()
        {

        }//end readBasicsFileBinaryBased()
        public void saveFile()
        {

        }//end saveFile()
    }//end class ReadBasicsInCreateModel
}//end namespace WinForm4GradeCR_Huang0045.Helper
