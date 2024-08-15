using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_Huang0045.HelperGUIdesign;
using ClassLibrary_Huang0045.FileStreams;
using ClassLibrary_Huang0045.HelperEnum;
using ClassLibrary_Huang0045.HelperFunction.InputCheckValidation_Huang0045;
using SharedProject4GB_Huang0045;
using WinForm4GradeCR_Huang0045.Helper;
using ZedGraphTest;

namespace WinForm4GradeQuery_Huang0045
{
    public partial class Frm4GradeQuery : Form
    {
        public TextBox[] profileTextBoxes;
        public Label[] profileLabels;
        //public Button[] processBtns;
        public const int BASIC_PROFILE_TEXTBOX_NO = 8;
        List<GradeRecord> recordList;

        public GradeRecordEnumAdv[] gradeQueryEnum ={GradeRecordEnumAdv.CLASS_ID,
                                                     GradeRecordEnumAdv.RATE_REGULARMARK,
                                                     GradeRecordEnumAdv.RATE_MIDTERM,
                                                     GradeRecordEnumAdv.RATE_FINALEXAM
        };
        public GradeRecordEnumAdv[] gradeRecordEnum =  {GradeRecordEnumAdv.STUDENT_ID,
                                                        GradeRecordEnumAdv.CLASS_ID,
                                                        GradeRecordEnumAdv.FIRST_NAME,
                                                        GradeRecordEnumAdv.LAST_NAME,
                                                        GradeRecordEnumAdv.REGULAR_MARK,
                                                        GradeRecordEnumAdv.MIDTERM_GRADE,
                                                        GradeRecordEnumAdv.FINAL_EXAM_GRADE,
                                                        GradeRecordEnumAdv.SEMESTER_MARK};

        const int numBeforeProcess = 7/*Before calcaute semester grade*/, numComplete = 8/*after calculate semester grade*/;
        //int numInColumnNeeded = numBeforeProcess;

        string[] titlesInDGV_BeforeProcess = new string[numBeforeProcess];
        string[] titlesInDGV_Complete = new string[numComplete];

        int CLASS_ID = 0, REGULAR_RATE = 1, MIDTERM_RATE = 2, FINALEXAM_RATE = 3;
        double Rate4Midterm = 1 / 3, Rate4Regular = 1 / 3, Rate4FinalExam = 1 / 3;
        DataCheckValidation_Huang0045 dataCheck = new DataCheckValidation_Huang0045(false, true);
        GradeBookAdv gradeBookAdv;


        public FileProcessBtnEnum[] btnEnums = { FileProcessBtnEnum.OPEN_FILE, FileProcessBtnEnum.COMPUTE_AND_SHOW,
                                                FileProcessBtnEnum.DRAW_PieChart_LinePlot_BarGraph,  FileProcessBtnEnum.EXIT };
        public FileProcessBtnEnum[] btnEnums2Initialize = { FileProcessBtnEnum.OPEN_FILE,
                                                FileProcessBtnEnum.DRAW_PieChart_LinePlot_BarGraph,  FileProcessBtnEnum.EXIT };
        public FileProcessBtnEnum selectedMenu4ProcessBtn;
        bool isOpen = true;

        public DataGridViewDesign dataGridViewDesign = new DataGridViewDesign();

        public List<GradeRecord> completedGradeRecordList;
        public ReadCompletedRecordsModel readCompletedRecordsModel;
        public FrmZedGraph4SmallGuruModified frmZedGraphs4AnyBook;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Frm4GradeQuery()
        {
            InitializeComponent();
            initializeNames4ProfileLabelsArray();
            initializeBtnsArray();
            InitializeDataGridView();
        }

        public Frm4GradeQuery(List<GradeRecord> _recordList)
        {
            InitializeComponent();
            recordList = _recordList;
            initializeNames4ProfileLabelsArray();
            initializeBtnsArray();
            InitializeDataGridView();
            completedGradeRecordList = new List<GradeRecord>();

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            isOpen = !isOpen;
            if (isOpen) btnOpenOrComputer.Text = FileProcessBtnEnum.OPEN_FILE.GetDescription();
            else btnOpenOrComputer.Text = FileProcessBtnEnum.COMPUTE_AND_SHOW.GetDescription();
        }

        public void initializeNames4ProfileLabelsArray()
        {
            profileLabels = new Label[BASIC_PROFILE_TEXTBOX_NO];
            Label[] profileLabelArray = { lbl1st, lbl2nd, lbl3rd, lbl4th, lbl5th, lbl6th, lbl7th, lbl8th };
            profileLabels = profileLabelArray;

            profileTextBoxes = new TextBox[BASIC_PROFILE_TEXTBOX_NO];
            TextBox[] profileTextBoxArray = { txtBox1st, txtBox2nd, txtBox3rd, txtBox4th, txtBox5th, txtBox6th, txtBox7th, txtBox8th };
            profileTextBoxes = profileTextBoxArray;

            for (int i = 0; i < gradeQueryEnum.Length; i++)
            {
                //profileLabels[i].Text = gradeRecordEnum[i].ToString();
                profileLabels[i].Text = gradeQueryEnum[i].GetDescription();
            }

            for (int i = gradeQueryEnum.Length; i < BASIC_PROFILE_TEXTBOX_NO; i++)
            {
                profileTextBoxes[i].Visible = false;
                profileLabels[i].Visible = false;
            }

            if (recordList == null) profileTextBoxes[0].Text = "UNKNOWN";
            else profileTextBoxes[0].Text = recordList[0].ClassID;

            profileTextBoxes[0].Enabled = false;
        }//end initializeNames4ProfileLabelsArray()

        public void initializeBtnsArray()
        {
            //processBtns = new Button[btnEnums2Initialize.Length];
            Button[] btnsArray = { btnOpenOrComputer, btnDrawCharts, btnExit };

            for (int i = 0; i < btnEnums2Initialize.Length; i++)
            {
                btnsArray[i].Text = btnEnums2Initialize[i].GetDescription();
            }
        }//end initializeBtnsArray()

        public void clearUpInitialize4NewStart()
        {
            for (int i = 0; i < gradeQueryEnum.Length; i++)
            {

                profileTextBoxes[i].Text = "";
            }
            dataGridView_BeforeProcess.Rows.Clear();
            dataGridView_Complete.Rows.Clear();
            completedGradeRecordList = new List<GradeRecord>();
        }

        public void switchLayoutModels(FileProcessBtnEnum selectMenu)
        {
            switch (selectMenu)
            {
                case FileProcessBtnEnum.OPEN_FILE: //GradesInCheckedListBox3.txt
                    clearUpInitialize4NewStart();
                    readCompletedRecordsModel = new ReadCompletedRecordsModel(this.dataGridView_BeforeProcess, true);
                    recordList = readCompletedRecordsModel.ReadRecordFile(dataGridView_BeforeProcess, completedGradeRecordList, null, fileChooserCompleteRecords);
                    btnOpenOrComputer.Text = FileProcessBtnEnum.COMPUTE_AND_SHOW.GetDescription();
                    break;
                case FileProcessBtnEnum.COMPUTE_AND_SHOW:
                    bool checkRates = getRates4DistributionViaCheck();
                    if (checkRates)
                    {
                        MessageBox.Show("(Rate4Regular, Rate4Midterm, Rate4FinalExam)= (" + Rate4Regular + ", " + Rate4Midterm + ", " + Rate4FinalExam + ")");
                        MessageBox.Show("Good! You can start drawing charts!");
                        gradeBookAdv = new GradeBookAdv("", "", Rate4Midterm, Rate4Regular, Rate4FinalExam, recordList);
                        GradeBookAdv.displayScores(gradeBookAdv.completeRecordList, null, dataGridView_Complete, 1);
                    }
                    break;
                case FileProcessBtnEnum.DRAW_PieChart_LinePlot_BarGraph:
                    string ChartTitle = "Grade";
                    string txtXTitle = "Grade_Level";
                    string txtYTitle = "Number_Students", txtXUnit = "Level", txtYUnit = "Student Count";
                    string strData = "";
                    string strLabels_PieChart = "";
                    string strLabels_LineBarPlot = "";

                    for (int i = 0; i < GradeBookAdv.thresholdValues.Length; i++)
                    {
                        strLabels_LineBarPlot += GradeBookAdv.thresholdValues[i] + "\t";
                        strLabels_PieChart += GradeBookAdv.levelCategoryLabels_Str[i] + "\t";
                        strData += GradeBookAdv.distFrequencies4Levels[i] + "\t";
                    }
                    //frmZedGraphs4AnyBook= new FrmZedGraphs4AnyBook(strData, strLabels_PieChart, strLabels_LineBarPlot,ChartTitle, false, true, true,
                    //txtXTitle, txtYTitle, txtXUnit, txtYUnit);//FrmZedGraph4SmallGuruModified
                    frmZedGraphs4AnyBook = new FrmZedGraph4SmallGuruModified(strData, strLabels_PieChart, strLabels_LineBarPlot, ChartTitle, false, true, true,
                                                    txtXTitle, txtYTitle, txtXUnit, txtYUnit);//FrmZedGraph4SmallGuruModified
                    frmZedGraphs4AnyBook.Show();

                    break;
            }//end switch
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;
            string menuType = senderBtn.Text;
            /*FileProcessBtnEnum*/
            selectedMenu4ProcessBtn = FileProcessBtnEnum.OPEN_FILE;

            for (int item = 0; item < btnEnums.Length; ++item)
            {
                if ((menuType == btnEnums[item].GetDescription()))
                {
                    selectedMenu4ProcessBtn = btnEnums[item];
                    break;
                }
            }
            switchLayoutModels(selectedMenu4ProcessBtn);
        }


        private void InitializeDataGridView()
        {
            //prepare titles for DataGridView used for records before completing semester-grades.
            for (int i = 0; i < numComplete - 1; i++)
            {
                titlesInDGV_BeforeProcess[i] = gradeRecordEnum[i].GetDescription();
            }

            //Prepare titles for DataGridView used for records after completing emester-grades.
            for (int i = 0; i < numComplete; i++)
            {
                titlesInDGV_Complete[i] = gradeRecordEnum[i].GetDescription();
            }

            dataGridViewDesign.initializeDataGridView(dataGridView_BeforeProcess, titlesInDGV_BeforeProcess);
            dataGridViewDesign.initializeDataGridView(dataGridView_Complete, titlesInDGV_Complete);
        }


        public bool getRates4DistributionViaCheck()
        {
            var _checkRates = false;
            var sumRates = 0.0;


            _checkRates = dataCheck.checkValueInRange(profileTextBoxes[MIDTERM_RATE].Text, profileLabels[MIDTERM_RATE].Text, 0, 1.0, false, false, dataCheck.DOUBLE_TYPE);
            if (!_checkRates)
            {
                profileTextBoxes[MIDTERM_RATE].Text = "";
                return false;
            }

            _checkRates = dataCheck.checkValueInRange(profileTextBoxes[REGULAR_RATE].Text, profileLabels[REGULAR_RATE].Text, 0, 1.0, false, false, dataCheck.DOUBLE_TYPE);
            if (!_checkRates)
            {
                profileTextBoxes[REGULAR_RATE].Text = "";
                return false;
            }

            _checkRates = dataCheck.checkValueInRange(profileTextBoxes[FINALEXAM_RATE].Text, profileLabels[FINALEXAM_RATE].Text, 0, 1.0, false, false, dataCheck.DOUBLE_TYPE);
            if (!_checkRates)
            {
                profileTextBoxes[FINALEXAM_RATE].Text = "";
                return false;
            }

            Rate4Midterm = double.Parse(profileTextBoxes[MIDTERM_RATE].Text);
            Rate4Regular = double.Parse(profileTextBoxes[REGULAR_RATE].Text);
            Rate4FinalExam = double.Parse(profileTextBoxes[FINALEXAM_RATE].Text);

            sumRates = Rate4Midterm + Rate4Regular + Rate4FinalExam;
            _checkRates = dataCheck.checkValueUsingCompare_1flag(sumRates.ToString(), "Sum_Of_Rates", 1.0, 0, dataCheck.DOUBLE_TYPE);

            return _checkRates;//could be 'true' or 'false';
        }//end getRates4DistributionViaCheck
    }
}
