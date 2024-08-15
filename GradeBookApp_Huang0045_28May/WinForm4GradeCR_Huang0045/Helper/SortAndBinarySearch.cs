using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedProject4GB_Huang0045;

namespace WinForm4GradeCR_Huang0045.Helper
{
    class SortAndBinarySearch
    {
        bool isDEBUG_ONE = false;

        Frm4GradeCR frm4GradeCR;
        List<GradeRecord> basicGradeRecordList;
        List<GradeRecord> keyinGradeRecordList = new List<GradeRecord>();
        List<GradeRecord> sortedGradeRecordList;
        List<string> studentIDListSorted;
        char[] delim = { ';', ',', '\t', '.', '@' };
        char[] delimSimple = { ',' };
        GradeBookAdv gradeBook = new GradeBookAdv();
        public SortAndBinarySearch()
        {

        }
        public SortAndBinarySearch(Frm4GradeCR _frmGradeCR)
        {
            frm4GradeCR = _frmGradeCR;
        }
        public SortAndBinarySearch(List<GradeRecord> _basicGradeRecordList, List<string> _studentIDListSorted)
        {
            basicGradeRecordList = _basicGradeRecordList;
            studentIDListSorted = _studentIDListSorted;
        }
        public IEnumerable<GradeRecord> sortDataInCheckedListBox()
        {
            foreach (var item in frm4GradeCR.checkedListBox_Create.Items)
            {
                string stringTmp = item.ToString();
                string[] strTmpArr = stringTmp.Split(delimSimple/*delim*/);
                MessageBox.Show("strTmpArr[0]=" + strTmpArr[0] + ";strTmpArr[1]=" + strTmpArr[1] + ";strTmpArr[2]=" + strTmpArr[2] + ";strTmpArr[3]=" + strTmpArr[3]);
                GradeRecord record = new GradeRecord(strTmpArr[0], strTmpArr[1], strTmpArr[2], strTmpArr[3],
                    double.Parse(strTmpArr[4]), double.Parse(strTmpArr[5]), double.Parse(strTmpArr[6]));
                keyinGradeRecordList.Add(record);
            }
            sortedGradeRecordList = GradeBookAdv.Linq_RecordListSortAscendingByStudentID(keyinGradeRecordList).ToList();
            return sortedGradeRecordList;
        }//end sortDataInCheckedListBox

        public void diplayBasicResultsByLinearSearch(string selectedText)
        {
            //Linear Search
            foreach (var record in frm4GradeCR.sortedBasicsList)
            {
                if (record.StudentID == selectedText)
                {
                    frm4GradeCR.recordConsidered = record;

                    showBasicRecordConsidered(record);
                    break;
                }

            }
        }
        public void displayBasicResultsByBinarySearch(string selectedText)
        {
            int i = frm4GradeCR.studentIDListSorted.BinarySearch(selectedText);
            MessageBox.Show("selected i=" + 1);
            frm4GradeCR.recordConsidered = frm4GradeCR.sortedBasicsList[i];
            showBasicRecordConsidered(frm4GradeCR.recordConsidered);
        }
        private void showBasicRecordConsidered(GradeRecord record)
        {
            frm4GradeCR.profileTextBoxes[(int)GradeRecordEnum.CLASS_ID - 1].Text = record.ClassID;
            frm4GradeCR.profileTextBoxes[(int)GradeRecordEnum.FIRST_NAME - 1].Text = record.FirstName;
            frm4GradeCR.profileTextBoxes[(int)GradeRecordEnum.LAST_NAME - 1].Text = record.LastName;

            frm4GradeCR.studentIDList_InChkedLB.Add(record.StudentID);
        }
        public bool addStudentIDINComboBoxByBinarySearch(string _keyToken, bool isIncheckedListBox)
        {
            if (frm4GradeCR.checkedListBox_Create.Items.Count != 0)
            {
                int index = frm4GradeCR.studentIDsortedInChkedLB.BinarySearch(_keyToken);

                if (isDEBUG_ONE) MessageBox.Show("_keyToken =" + _keyToken);
                if (isDEBUG_ONE) MessageBox.Show("index =" + index);
                if (index >= 0 && index <= frm4GradeCR.studentIDsortedInChkedLB.Count)
                    isIncheckedListBox = true;

                if (!isIncheckedListBox)
                    frm4GradeCR.cbKey.Items.Add(_keyToken.Trim());
                return isIncheckedListBox;
            }
            else
            {
                frm4GradeCR.cbKey.Items.Add(_keyToken.Trim());
            }
            return false;
        }
        public bool addStudentIDInComboBoxByLinearSearch(string _keyToken, bool isIncheckedListBox)
        {
            foreach (var item in frm4GradeCR.checkedListBox_Create.Items)
            {
                string stringTmp = item.ToString();
                string[] strTmpArr = stringTmp.Split(delim);

                if (_keyToken.Trim() == strTmpArr[0].ToString().Trim())
                {
                    if (isDEBUG_ONE) MessageBox.Show("_keyToken (not added)=" + _keyToken);
                    isIncheckedListBox = true;
                    break;
                }
            }
            if (!isIncheckedListBox)
                frm4GradeCR.cbKey.Items.Add(_keyToken.Trim());
            return isIncheckedListBox;

        }

    }//end class SortAndBinarySearch
}//end namespace WinForm4GradeCR_Huang0045.Helper
