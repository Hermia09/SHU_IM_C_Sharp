using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary_Huang0045.FileStreams;
using SharedProject4GB_Huang0045;

namespace WinForm4GradeCR_Huang0045.Helper
{
    class ChecksTextOrByteBased
    {
        bool isDEBUG_ON = false;
        private bool isBasics;
        char[] delim = { ';', ',', '\t', '.', '@' };
        char[] delimSimple = { ',' };
        OpenFileDialog fileChooser4Basic;
        OpenFileDialog fileChooser4NotBasics;

        string initialDir = @"D:\Test";
        public string fileName4Input;
        OpenReadOrWriteWithCheck_Hua0045 fileChooser = new OpenReadOrWriteWithCheck_Hua0045();
        public int checkOpenIsTxtOrBinary = -1;
        OpenReadOrWriteWithCheck_Hua0045 myRnw;

        bool isTextBased = false;
        public BinaryFormatter readFormatter = new BinaryFormatter();
        public ChecksTextOrByteBased(bool _isBasics, OpenFileDialog _fileChooser4Basics,
            OpenFileDialog _fileChooser4NotBasics)
        {
            isBasics = _isBasics;
            fileChooser4Basic = _fileChooser4Basics;
            fileChooser4NotBasics = _fileChooser4NotBasics;

            if (isBasics)//e.g. 'basicProfile_GradeRecords.csv'           
                fileName4Input = fileChooser.openDialog2ChooseFile(fileChooser4Basic, initialDir);
            else
                fileName4Input = fileChooser.openDialog2ChooseFile(fileChooser4NotBasics, initialDir);
        }
        public int checkEnumType_Is_TxtOrBinary(FileStreamBasedEnumNew fileStreamBasedEnumNew)
        {
            var studentIndex = 0;
            string inputRecord;
            string[] inputFilelds = null;//will store individual pieces of data
            GradeRecord record;
            try
            {

                if (fileStreamBasedEnumNew == FileStreamBasedEnumNew.TEXT_BASED)
                {
                    myRnw = new OpenReadOrWriteWithCheck_Hua0045(true, false, fileName4Input, "", (int)
                        (FileStreamBasedEnumNew.TEXT_BASED));
                    inputRecord = myRnw.fileReader.ReadLine();//test
                    MessageBox.Show("inputRecord =" + inputRecord);
                    while (inputRecord != null)//original using 'if (inputRecord != null)', But ....(explain to students why change)                      
                    {
                        inputFilelds = inputRecord.Split(delimSimple);
                        record = new GradeRecord(inputFilelds[(int)(GradeRecordEnum.STUDENT_ID)],
                                                            inputFilelds[(int)(GradeRecordEnum.CLASS_ID)],
                                                            inputFilelds[(int)(GradeRecordEnum.LAST_NAME)],
                                                            inputFilelds[(int)(GradeRecordEnum.FIRST_NAME)]);
                        #region debug mode
                        if (isDEBUG_ON)
                        {
                            MessageBox.Show("" + inputFilelds[(int)(GradeRecordEnum.STUDENT_ID)] + ", " +
                                               inputFilelds[(int)(GradeRecordEnum.CLASS_ID)] + ", " +
                                               inputFilelds[(int)(GradeRecordEnum.LAST_NAME)] + ", " +
                                               inputFilelds[(int)(GradeRecordEnum.FIRST_NAME)]);
                        }
                        #endregion debug mode
                        inputRecord = myRnw.fileReader.ReadLine();
                        studentIndex++;
                    }
                    myRnw.CloseFile();

                    MessageBox.Show("inputFields[1] =" + inputFilelds[1]);
                    checkOpenIsTxtOrBinary = (int)(FileStreamBasedEnum2.TEXT_BASED);
                    MessageBox.Show("This is TEXT_BASED!");
                    isTextBased = true;
                    myRnw.CloseFile();
                }
                else//!isTextBased
                {
                    /**
                     * Not sure if it is needed to run through whole set of record/basics
                     * for making sure the file considered is right one...                   
                     * NEED TO Come back to verify later
                     */
                    #region NEED TO Come back to verify if working properly later
                    myRnw = new OpenReadOrWriteWithCheck_Hua0045(true, false, fileName4Input, "", (int)
                        (FileStreamBasedEnumNew.BYTE_BASED));
                    myRnw.input.Seek(0, SeekOrigin.Begin);//test2
                    GradeRecord tmpRecord = (GradeRecord)readFormatter.Deserialize(myRnw.input);

                    myRnw.input.Seek(0, SeekOrigin.Begin);//tested
                    checkOpenIsTxtOrBinary = (int)(FileStreamBasedEnumNew.BYTE_BASED);
                    MessageBox.Show("This is BYTE_BASED!");

                    isTextBased = false;
                    myRnw.CloseFile();//failed
                    #endregion
                }
            }
            catch (NullReferenceException nrEx)
            {
                MessageBox.Show(nrEx.Message + "\r\nError reading from File", "NullReferenceException", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //System.Environment.Exit(0);
            }
            catch (IndexOutOfRangeException /*iorEx*/)
            {
                MessageBox.Show("Read wrong file!\r\nRe-Choose!", "IndexOutOfRangeException", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return checkOpenIsTxtOrBinary;
        }//end checkEnumType_Is_TxtOrBinary
    }//end class ChecksTextOrByteBased
}//end namespace WinForm4GradeCR_Huang0045.Helper
