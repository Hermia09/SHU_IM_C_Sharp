using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradeLib_Huang0045;
using ClassLibrary_Huang0045.HelperEnum;
using ClassLibrary_Huang0045.FileStreams;
using SharedProject4GB_Huang0045;
using WinForm4GradeCR_Huang0045.Helper;

namespace WinForm4GradeCR_Huang0045
{
    public partial class Frm4GradeCR : FrmGradeUI
    {
        ToolStripMenuItem[] tsmicreate;

        public List<string> studentIDList_InChkedLB;
        public List<string> studentIDListSorted;
        public List<string> studentIDsortedInChkedLB;
        public GradeRecord recordConsidered;

        public List<GradeRecord> basicDataList;
        public List<GradeRecord> sortedBasicsList;
        public List<GradeRecord> completedGradeRecordList;

        public bool isCompltedRecords = false;

        RecordProcessBtnModel recordProcessBtnModel;
        ReadBasicsInCreateModel readBasicsModel;
        SortAndBinarySearch SortAndSearch;
        ReadCompletedRecordsModel readCompletedRecordsModel;

        public Frm4GradeCR()
        {
            InitializeComponent();
            setupHandlers4CR();

            basicDataList = new List<GradeRecord>();
            sortedBasicsList = new List<GradeRecord>();
            completedGradeRecordList = new List<GradeRecord>();

            recordProcessBtnModel = new RecordProcessBtnModel(this);
            studentIDList_InChkedLB = new List<string>();
            studentIDListSorted = new List<string>();
        }
        /// <summary>
        /// Handles the Click event of the btnFileProcess control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The<see cref="EventArgs"/>instance containing the event data.</param>

        public void BtnFileProcess_Click(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;
            string menuType = senderBtn.Text;
            FileProcessBtnEnum selectedMenu = FileProcessBtnEnum.KEY_INTO_LISTBOX;
            for (int item = 0; item < fileProcessBtnEnum.Length; ++item)
            {
                if ((menuType == fileProcessBtnEnum[item].GetDescription()))
                {
                    selectedMenu = fileProcessBtnEnum[item];
                    break;
                }//end for
            }
            switchAppModels(selectedMenu);
            //MessageBox.Show("menuType: " + selectedMenu);

        }//btnFileProcess_Click

        /// <summary>
        /// Switches the application models.
        /// </summary>
        /// <param name="selectedMenu"></param>
        public void switchAppModels(FileProcessBtnEnum selectedMenu)
        {
            switch (selectedMenu)
            {
                case FileProcessBtnEnum.KEY_INTO_LISTBOX:
                    recordProcessBtnModel.btnKeyIntoListBox();
                    break;
                case FileProcessBtnEnum.DELETE:
                    recordProcessBtnModel.btnDeleteFromListBox();
                    break;
                case FileProcessBtnEnum.SAVE_FILE:
                    recordProcessBtnModel.btnSaveFile4ListBox();
                    break;
                case FileProcessBtnEnum.DESPLAY_RECORDS_1By1:
                    break;
                case FileProcessBtnEnum.EXIT:
                    this.Close();
                    break;

            }

        }
        /// <summary>
        /// Setup the handlers for processes of creating and reading records.
        /// </summary>

        private void setupHandlers4CR()
        {
            TSMitemCreateFile.Click += new EventHandler(fileToolStripMenuItem_Click);
            TSMitemReadFile.Click += new EventHandler(fileToolStripMenuItem_Click);

            #region Declare two toolStripItems of create file, set their found
            tsmicreate = new ToolStripMenuItem[createFileEnum.Length];
            tsmicreate[0] = TSMitem_New;
            tsmicreate[1] = TSMitem_Incomplete;
            for (int i = 0; i < tsmicreate.Length; i++)
            {
                tsmicreate[i].ForeColor = Color.Black;
                tsmicreate[i].Click += new EventHandler(createFileToolStripBtn_Click);
            }
            #endregion Declare two toolStripItems of create file, set their found
        }
        /// <summary>
        /// Handles the Click event of the FileToolStripMenuItem control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem senderItem = (ToolStripMenuItem)sender;
            string menuType = senderItem.Text;
            if (menuType == FileStreamMenuEnum.Read_File.GetDescription())//"Read_File"
            {
                changeBtnState(false);
                readCompletedRecordFile();
            }
            else//Create_File
            {
                changeBtnState(true);
            }

        }//end fileToolStripMenuItem_Click

        /// <summary>
        /// Handles the Click event of the createFileToolStripBtn control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFileToolStripBtn_Click(object sender, EventArgs e)
        {
            CreateFileEnum selectedMenu = CreateFileEnum.CREATE_FROM_NEW;
            changeBtnState(true);
            clearTextBoxes();
            cbKey.Items.Clear();
            cbKey.Text = "";
            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)sender;
            string menuType = senderToolStripMenuItem.Text;
            for (int item = 0; item < createFileEnum.Length; ++item)
            {
                if (menuType == createFileEnum[item].GetDescription())
                {
                    selectedMenu = createFileEnum[item];
                    break;
                }
            }
            MessageBox.Show("selectedMenu: " + selectedMenu.ToString());

            readBasicsModel = new ReadBasicsInCreateModel(this, fileChooserBasicProfile, fileChooserIncompleteRecord, fileChooserCompleteRecord);
            readBasicsModel.switchModels(selectedMenu);
        }//createFileToolStripBtn_Click
        /// <summary>
        /// Changes the state of the BTNX.
        /// </summary>
        /// <param name="isCreateMode"></param>
        public void changeBtnState(bool isCreateMode)
        {
            processTabPage(isCreateMode);
            btnDelete.Visible = isCreateMode;
            btnKeyIn.Visible = isCreateMode;
            btnSaveFile.Visible = isCreateMode;
            btnDisplayRecordComplete.Visible = !isCreateMode;
        }//end changeBtnState


        private void readBasicFileUsingComboBox()
        {
            studentIDsortedInChkedLB = new List<string>();
            if (rdBtn_SearchBinary.Checked)
            {
                SortAndSearch.displayBasicResultsByBinarySearch(cbKey.Text);
            }
            else
            {
                SortAndSearch.diplayBasicResultsByLinearSearch(cbKey.Text);
            }
        }//end readBasicFileUsingComboBox()



        private void cbKey_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("I am in cb_SelectedIndexChanged!");

            SortAndSearch = new SortAndBinarySearch(this);
            clearTextBoxes();

            if (isCompltedRecords)
            {
                //MessageBox.Show("NEED TO Finish later!");
                readCompletedFileUsingComboBox();
            }//isCompltedRecords
            else
            {
                readBasicFileUsingComboBox();
            }
        }//End of cbKey_SelectedIndexChanged_1

        private void readCompletedRecordFile()
        {
            readCompletedRecordsModel = new ReadCompletedRecordsModel(this.dataGridView_Read, true);
            readCompletedRecordsModel.readRecordFile(this);
        }
        private void readCompletedFileUsingComboBox()
        {
            //http://stackoverflow.com/questions/6901070/getting-selected-value-of-a-combobox  (google "combobox get selected value c#")
            MessageBox.Show(cbKey.Text);

            foreach (var record in completedGradeRecordList)
            {
                if (record.StudentID == (cbKey.Text))
                {
                    //MessageBox.Show(list.StudentID+" (foreach)");
                    recordConsidered = record;

                    profileTextBoxes[((int)GradeRecordEnum.CLASS_ID) - 1].Text = record.ClassID;
                    profileTextBoxes[((int)GradeRecordEnum.LAST_NAME) - 1].Text = record.LastName;
                    profileTextBoxes[((int)GradeRecordEnum.FIRST_NAME) - 1].Text = record.FirstName;

                    profileTextBoxes[((int)GradeRecordEnum.REGULAR_MARK) - 1].Text = (record.RegularMark).ToString();
                    profileTextBoxes[((int)GradeRecordEnum.MIDTERM_GRADE) - 1].Text = (record.MidTermMark).ToString();
                    profileTextBoxes[((int)GradeRecordEnum.FINALEXAME_GRADE) - 1].Text = (record.FinalExamMark).ToString();

                    //StudentIDList.Add(list.StudentID);
                    break;
                }
            }
        }//end method readCompletedFileUsingComboBox()

    }//end class Frm4GradeCR : FrmGradeUI
}//end namespace WinForm4GradeCR_Huang0045
