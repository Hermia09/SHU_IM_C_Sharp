using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using ClassLibrary_Huang0045.FileStreams;
using ClassLibrary_Huang0045.HelperEnum;
using ClassLibrary_Huang0045.HelperGUIdesign;
using SharedProject4GB_Huang0045;

namespace WinForm4GradeCR_Huang0045.Helper
{
    public class ReadCompletedRecordsModel
    {
        bool isDEBUG_ON = false;
        bool isBasicRecords = false;
        ChecksTextOrByteBased checkIstextByteBased;
        OpenReadOrWriteWithCheck_Hua0045 readORwriteCheck;
        StreamReader fileReader4InputData;
        public BinaryFormatter readFormatter = new BinaryFormatter();
        public DataGridViewDesign dataGridViewDesign = new DataGridViewDesign();

        public GradeRecordEnumAdv[] gradeRecordEnum =  {GradeRecordEnumAdv.STUDENT_ID,
                                                        GradeRecordEnumAdv.CLASS_ID,
                                                        GradeRecordEnumAdv.FIRST_NAME,
                                                        GradeRecordEnumAdv.LAST_NAME,
                                                        GradeRecordEnumAdv.REGULAR_MARK,
                                                        GradeRecordEnumAdv.MIDTERM_GRADE,
                                                        GradeRecordEnumAdv.FINAL_EXAM_GRADE,
                                                        GradeRecordEnumAdv.SEMESTER_MARK};
        const int numBeforeProcessQ = 7/*Before calcaute semester grade*/, numCompleted = 8/*after calculate semester grade*/;
        int numInColumnNeeded = numBeforeProcessQ;
        bool isProcessBeforeCompleted = true;

        string[] titlesInDGV;
        string[] titlesInDGV_Complete = new string[numCompleted];

        char[] delim = { ';', ',', '\t', '.', '@' };
        char[] delimSimple = { ',' };
        //public ReadCompletedRecordsModel(Frm4GradeCR _gradeForm4CreateRead, OpenFileDialog _fileChooser4KeyinRecords)
        //{
        //    InitializeDataGridView(_gradeForm4CreateRead.dataGridView_Read, numBeforeProcess);
        //}//end constructor ReadCompletedRecordsModel

        public ReadCompletedRecordsModel(DataGridView dataGridView, bool _isProcessBeforeCompleted/*, OpenFileDialog _fileChooser4KeyinRecords*/)
        {
            isProcessBeforeCompleted = _isProcessBeforeCompleted;
            if (isProcessBeforeCompleted) numInColumnNeeded = numBeforeProcessQ;
            else numInColumnNeeded = numCompleted;
            initializeDataGridView(dataGridView, numInColumnNeeded);
        }//end constructor ReadCompletedRecordsModel
        private void initializeDataGridView(DataGridView _dataGridView, int _numInColumn)
        {
            titlesInDGV = new string[_numInColumn];
            for (int i = 0; i < _numInColumn; i++)
            {
                titlesInDGV[i] = gradeRecordEnum[i].GetDescription();
            }
            dataGridViewDesign.initializeDataGridView(_dataGridView, titlesInDGV);

        }//end method initializeDataGridView

        public void readRecordFile(Frm4GradeCR _frm4GradeCR)
        {
            _frm4GradeCR.checkedListBox_Create.Items.Clear();
            _frm4GradeCR.cbKey.Items.Clear();
            _frm4GradeCR.cbKey.Enabled = true;
            _frm4GradeCR.dataGridView_Read.Rows.Clear();

            var studentIndex = 0;

            string inputRecord;
            string[] inputFields;//will store individual pieces of data
            var isBinaryRight = false;

            GradeRecord record;
            var _checkOpenTxtBinary = -1;
            try
            {
                checkIstextByteBased = new ChecksTextOrByteBased(isBasicRecords, _frm4GradeCR.fileChooserBasicProfile,
                    _frm4GradeCR.fileChooserCompleteRecord);
                _checkOpenTxtBinary = checkIstextByteBased.checkEnumType_Is_TxtOrBinary(FileStreamBasedEnumNew.TEXT_BASED);


                if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.TEXT_BASED))
                {
                    readORwriteCheck = new OpenReadOrWriteWithCheck_Hua0045(true, false, checkIstextByteBased.fileName4Input, "",
                        (int)(FileStreamBasedEnum2.TEXT_BASED));
                    fileReader4InputData = readORwriteCheck.fileReader;

                    //inputRecord = fileReader4InputData.ReadLine();
                    inputRecord = fileReader4InputData.ReadLine();

                    //MessageBox.Show("inputRecord=" + inputRecord);
                    while (inputRecord != null)//original using 'if (inputRecord != null)', But .... (explain to students why change)
                    {
                        inputFields = inputRecord.Split(delimSimple);

                        if (isDEBUG_ON)
                        {
                            /*
                            MessageBox.Show("length=" + inputFields.Length);
                            for (int i = 0; i < inputFields.Length; i++)
                            {
                                MessageBox.Show(i + "=" + inputFields[i] + "\t");
                            }
                            */

                            MessageBox.Show("" + inputFields[(int)(GradeRecordEnum.STUDENT_ID)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.CLASS_ID)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.FIRST_NAME)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.LAST_NAME)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.REGULAR_MARK)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.MIDTERM_GRADE)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.FINALEXAME_GRADE)]
                                         );
                        }

                        record = new GradeRecord(inputFields[(int)(GradeRecordEnum.STUDENT_ID)],
                                                            inputFields[(int)(GradeRecordEnum.CLASS_ID)],
                                                            inputFields[(int)(GradeRecordEnum.FIRST_NAME)],
                                                            inputFields[(int)(GradeRecordEnum.LAST_NAME)],
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.REGULAR_MARK)]),
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.MIDTERM_GRADE)]),
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.FINALEXAME_GRADE)])
                                                          );

                        _frm4GradeCR.completedGradeRecordList.Add(record);
                        _frm4GradeCR.dataGridView_Read.Rows.Add(record.StudentID,
                                                                         record.ClassID,
                                                                         record.LastName,
                                                                         record.FirstName,
                                                                         record.RegularMark,
                                                                         record.MidTermMark,
                                                                         record.FinalExamMark);
                        _frm4GradeCR.cbKey.Items.Add(record.StudentID);
                        inputRecord = fileReader4InputData.ReadLine();
                        studentIndex++;
                    }//end while
                }//end if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.TEXT_BASED))

                if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.BYTE_BASED))
                {
                    MessageBox.Show("_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.BYTE_BASED)");
                    isBinaryRight = true;
                    readORwriteCheck = new OpenReadOrWriteWithCheck_Hua0045(true, false,
                        checkIstextByteBased.fileName4Input, "", (int)(FileStreamBasedEnum2.BYTE_BASED));
                    readFormatter = readORwriteCheck.readBinaryFormatter;

                    readORwriteCheck.input.Seek(0, SeekOrigin.Begin);//test2
                    while (true)
                    {
                        record = (GradeRecord)readFormatter.Deserialize(readORwriteCheck.input);
                        if (isDEBUG_ON) MessageBox.Show("tmpRecord(BYTE_BASED)" + record);

                        _frm4GradeCR.completedGradeRecordList.Add(record);
                        _frm4GradeCR.dataGridView_Read.Rows.Add(record.StudentID,
                                                                         record.ClassID,
                                                                         record.LastName,
                                                                         record.FirstName,
                                                                         record.RegularMark,
                                                                         record.MidTermMark,
                                                                         record.FinalExamMark);
                        _frm4GradeCR.cbKey.Items.Add(record.StudentID);
                        studentIndex++;
                    }
                }//end if

                if (readORwriteCheck != null)
                {
                    readORwriteCheck.CloseFile();
                    _frm4GradeCR.isCompltedRecords = true;

                    MessageBox.Show("No more records in file", string.Empty,
                           MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }//end try
            catch (SerializationException sEx)
            {
                readORwriteCheck.CloseFile();

                if (isBinaryRight) MessageBox.Show("Finished reading record info.");
                else MessageBox.Show(sEx.Message + "\r\nSomething Wrong Here!");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error Reading from File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException anEx)
            {
                MessageBox.Show("Read NO file!", "ArgumentNullException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException /*iorEx*/)
            {
                MessageBox.Show("Read Wrong file!\r\nRe-Choose!!", "IndexOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(/*fEx+*/"\r\nInput string was not in a correct format!\r\nCorrect your data or re-choose file!!",
                    "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException aoorEx)
            {
                MessageBox.Show(aoorEx.Message + "\r\nCorrect your data or re-choose file!!",
                    "ArgumentOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  // end try_catch
            catch (NullReferenceException /*enr*/) when (readORwriteCheck.result == DialogResult.Cancel)//added on 08June21
            {
                //MessageBox.Show(enr.Message+"\nMaybe You need to re-choose/give a file-name");
                MessageBox.Show(/*enr.Message+ */"\n\nMaybe You need to re-choose/give a file-name", "DialogResult.Cancel",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end readRecordFile

        public IEnumerable<GradeRecord> ReadRecordFile(/*bool isQuery,*/ DataGridView dataGridView, List<GradeRecord> completedGradeRecordList,
                                    OpenFileDialog fileChooserBasicProfile, OpenFileDialog fileChooserCompleteRecords)
        {
            dataGridView.Rows.Clear();

            var studentIndex = 0;

            string inputRecord;
            string[] inputFields;//will store individual pieces of data
            var isBinaryRight = false;

            GradeRecord record;
            var _checkOpenTxtBinary = -1;
            try
            {
                checkIstextByteBased = new ChecksTextOrByteBased(isBasicRecords, fileChooserBasicProfile,
                    fileChooserCompleteRecords);
                _checkOpenTxtBinary = checkIstextByteBased.checkEnumType_Is_TxtOrBinary(FileStreamBasedEnumNew.TEXT_BASED);


                if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.TEXT_BASED))
                {
                    readORwriteCheck = new OpenReadOrWriteWithCheck_Hua0045(true, false, checkIstextByteBased.fileName4Input, "",
                        (int)(FileStreamBasedEnum2.TEXT_BASED));
                    fileReader4InputData = readORwriteCheck.fileReader;

                    //inputRecord = fileReader4InputData.ReadLine();
                    inputRecord = fileReader4InputData.ReadLine();

                    //MessageBox.Show("inputRecord=" + inputRecord);
                    while (inputRecord != null)//original using 'if (inputRecord != null)', But .... (explain to students why change)
                    {
                        inputFields = inputRecord.Split(delimSimple);

                        if (isDEBUG_ON)
                        {
                            /*
                            MessageBox.Show("length=" + inputFields.Length);
                            for (int i = 0; i < inputFields.Length; i++)
                            {
                                MessageBox.Show(i + "=" + inputFields[i] + "\t");
                            }
                            */

                            MessageBox.Show("" + inputFields[(int)(GradeRecordEnum.STUDENT_ID)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.CLASS_ID)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.FIRST_NAME)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.LAST_NAME)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.REGULAR_MARK)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.MIDTERM_GRADE)] + "\t " +
                                          inputFields[(int)(GradeRecordEnum.FINALEXAME_GRADE)]
                                         );
                        }

                        record = new GradeRecord(inputFields[(int)(GradeRecordEnum.STUDENT_ID)],
                                                            inputFields[(int)(GradeRecordEnum.CLASS_ID)],
                                                            inputFields[(int)(GradeRecordEnum.FIRST_NAME)],
                                                            inputFields[(int)(GradeRecordEnum.LAST_NAME)],
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.REGULAR_MARK)]),
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.MIDTERM_GRADE)]),
                                                            double.Parse(inputFields[(int)(GradeRecordEnum.FINALEXAME_GRADE)])
                                                          );

                        completedGradeRecordList.Add(record);
                        dataGridView.Rows.Add(record.StudentID, record.ClassID, record.LastName, record.FirstName, record.RegularMark,
                                              record.MidTermMark, record.FinalExamMark);
                        dataGridView.Rows[studentIndex].DefaultCellStyle.BackColor = Color.LightYellow;//level ID
                        dataGridView.Rows[studentIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;//level ID


                        inputRecord = fileReader4InputData.ReadLine();
                        studentIndex++;
                    }//end while
                }//end if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.TEXT_BASED))

                if (_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.BYTE_BASED))
                {
                    MessageBox.Show("_checkOpenTxtBinary == (int)(FileStreamBasedEnum2.BYTE_BASED)");
                    isBinaryRight = true;
                    readORwriteCheck = new OpenReadOrWriteWithCheck_Hua0045(true, false,
                        checkIstextByteBased.fileName4Input, "", (int)(FileStreamBasedEnum2.BYTE_BASED));
                    readFormatter = readORwriteCheck.readBinaryFormatter;

                    readORwriteCheck.input.Seek(0, SeekOrigin.Begin);//test2
                    while (true)
                    {
                        record = (GradeRecord)readFormatter.Deserialize(readORwriteCheck.input);
                        if (isDEBUG_ON) MessageBox.Show("tmpRecord(BYTE_BASED)" + record);

                        completedGradeRecordList.Add(record);
                        dataGridView.Rows.Add(record.StudentID,
                                                                         record.ClassID,
                                                                         record.LastName,
                                                                         record.FirstName,
                                                                         record.RegularMark,
                                                                         record.MidTermMark,
                                                                         record.FinalExamMark);
                        studentIndex++;
                    }
                }//end if

                if (readORwriteCheck != null)
                {
                    readORwriteCheck.CloseFile();
                    //_frm4GradeCR.isCompltedRecords = true;

                    MessageBox.Show("No more records in file", string.Empty,
                           MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }

                //return completedGradeRecordList.ToList();
                return completedGradeRecordList;
            }//end try
            catch (SerializationException sEx)
            {
                readORwriteCheck.CloseFile();

                if (isBinaryRight) MessageBox.Show("Finished reading record info.");
                else MessageBox.Show(sEx.Message + "\r\nSomething Wrong Here!");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error Reading from File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException anEx)
            {
                MessageBox.Show("Read NO file!", "ArgumentNullException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException /*iorEx*/)
            {
                MessageBox.Show("Read Wrong file!\r\nRe-Choose!!", "IndexOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show(/*fEx+*/"\r\nInput string was not in a correct format!\r\nCorrect your data or re-choose file!!",
                    "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException aoorEx)
            {
                MessageBox.Show(aoorEx.Message + "\r\nCorrect your data or re-choose file!!",
                    "ArgumentOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  // end try_catch
            catch (NullReferenceException /*enr*/) when (readORwriteCheck.result == DialogResult.Cancel)//added on 08June21
            {
                //MessageBox.Show(enr.Message+"\nMaybe You need to re-choose/give a file-name");
                MessageBox.Show(/*enr.Message+ */"\n\nMaybe You need to re-choose/give a file-name", "DialogResult.Cancel",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }//end readRecordFile

    }//end class ReadCompletedRecordsModel
}
