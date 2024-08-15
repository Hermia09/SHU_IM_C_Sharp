using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyBookUIForm4Basic_Huang0045;
using ClassLibrary_Huang0045.HelperEnum;
using ClassLibrary_Huang0045.FileStreams;
using SharedProject4GB_Huang0045;

namespace GradeLib_Huang0045
{
    public partial class FrmGradeUI : FrmProfileBasic
    {
        #region Define variables
        public FileProcessBtnEnum[] fileProcessBtnEnum = {FileProcessBtnEnum.DELETE,FileProcessBtnEnum.KEY_INTO_LISTBOX,
            FileProcessBtnEnum.SAVE_FILE,FileProcessBtnEnum.DESPLAY_RECORDS_1By1,FileProcessBtnEnum.EXIT};

        public GradeRecordEnum[] gradeRecordEnum = {GradeRecordEnum.CLASS_ID,
                                                    GradeRecordEnum.FIRST_NAME,
                                                    GradeRecordEnum.LAST_NAME,
                                                    GradeRecordEnum.REGULAR_MARK,
                                                    GradeRecordEnum.MIDTERM_GRADE,
                                                    GradeRecordEnum.FINALEXAME_GRADE};

        //Declare the drop-down button and the items it will contain
        ToolStripDropDownButton toolStripDDbtnFile/*,toolStripDDbtnTextColor*/;//one for 'File', one for 'Text_Color'
        ToolStripDropDown dropDown_File/*,dropDown_TextColor*/;
        ToolStripDropDown dropDown_CreateFile;

        public ToolStripMenuItem TSMitemCreateFile, TSMitemReadFile;

        //Declar2 toolStripMenuItems and 2 sets of buttons which are attached to them separately;
        public ToolStripMenuItem TSMitem_New, TSMitem_Incomplete;
        public CreateFileEnum[] createFileEnum = { CreateFileEnum.CREATE_FROM_INCOMPLETE, CreateFileEnum.CREATE_FROM_NEW };
        public Button[] btnProcess;
        #endregion Define variables

        /// <summary>
        /// Initializes a new instance of the<see cref="FrmGradeUI"/>class.
        /// </summary>
        public FrmGradeUI()
        {
            InitializeComponent();
            initializeNames4ProfileLabelsArray();
            initializeDropDownButton();

            initialNames4ProcessBtnsArray();
            //setupHandlers4CR();
        }//end FrmGradeUI()

        public void initialNames4ProcessBtnsArray()
        {
            btnProcess = new Button[fileProcessBtnEnum.Length];
            Button[] btn4ProcessArray = { btnDelete, btnKeyIn, btnSaveFile, btnDisplayRecordComplete, btnExit };
            btnProcess = btn4ProcessArray;
            for (int i = 0; i < fileProcessBtnEnum.Length; i++)
            {
                btnProcess[i].Text = fileProcessBtnEnum[i].GetDescription();
            }
        }
        /// <summary>
        /// Initializes the names for profile-labels array.
        /// </summary>
        private void initializeNames4ProfileLabelsArray()
        {
            for (int i = 0; i < gradeRecordEnum.Length; i++)
            {
                //profileLabels[i].Text=gradeRecordEnum[i].ToString();
                profileLabels[i + 1].Text = gradeRecordEnum[i].GetDescription();
            }

            for (int i = gradeRecordEnum.Length; i < BASIC_PROFILE_TEXTBOX_ON - 1; i++)
            {
                profileTextBoxes[i].Visible = false;
                profileLabels[i + 1].Visible = false;
            }

            //lblKey.Text=GradeRecordEnum.STUDENT_ID.ToString();
            lblKey.Text = GradeRecordEnum.STUDENT_ID.GetDescription();
        }//end initializeNames4ProfileLabelsArray()

        public void initializeDropDownButton()
        {
            #region Setup a primary toolStripDropDownButtons with a drop-down for 'File'; then attach 2 toolStripMenuItems of "Create File" and "Read File" to the drop-down.
            //1. set up the ToolStripDropDownButton for 'File'
            toolStripDDbtnFile = new ToolStripDropDownButton();
            toolStripDDbtnFile.Text = "File";
            //https://stackoverflow.com/questions/16181980/how-to-add-image-to-toolstripmenuitem
            //toolStripDDbtnFile.Image = Image.FromFile(@"Q:\C#_2_a0001\final\GradeBookApp_a0001\Icons\Open.jfif");

            // 2. attach the drop-down on the ToolStripDropDownButton for 'File'.
            dropDown_File = new ToolStripDropDown();
            toolStripDDbtnFile.DropDown = dropDown_File;

            // 2-1. Set the drop-down direction.
            toolStripDDbtnFile.DropDownDirection = ToolStripDropDownDirection.BelowRight;

            // 2-2. Do show a drop-down arrow.
            toolStripDDbtnFile.ShowDropDownArrow = true;

            // 3. Declare 2 toolStripMenuItems (including "Create FILE" and "Read File"),
            //    set their foreground color and text, then add them to the drop-down.
            TSMitemCreateFile = new ToolStripMenuItem();
            TSMitemCreateFile.ForeColor = Color.BlueViolet;
            TSMitemCreateFile.Text = FileStreamMenuEnum.Create_File.GetDescription();//"Create File";
            //TSMitemCreateFile.Image = Image.FromFile(@"Q:\C#_2_a0001\final\GradeBookApp_a0001\Icons\Create.jfif");

            //TSMitemCreateFile.Click += new EventHandler(FileToolStripMenuItem_Click);

            TSMitemReadFile = new ToolStripMenuItem();
            TSMitemReadFile.ForeColor = Color.BlueViolet;
            TSMitemReadFile.Text = FileStreamMenuEnum.Read_File.GetDescription();//"Read File";
            //TSMitemReadFile.Image = Image.FromFile(@"Q:\C#_2_a0001\final\GradeBookApp_a0001\Icons\read.png");

            // TSMitemReadFile.Click += new EventHandler(FileToolStripMenuItem_Click);
            //4. add toolStripMenuItems of "Create File" and "Read File" on drop-down
            dropDown_File.Items.AddRange(new ToolStripItem[]
                {TSMitemCreateFile,TSMitemReadFile});
            #endregion Setup a primary toolStripDropDownButtons with a drop-down for 'File'; then attach 2 toolStripMenuItems of "Create File" and "Read File" to the drop-down.

            #region Add the main toolStripDropDownButtons, already setup and attched all components needed, to the toolStrip of interest.
            toolStripCRfile.Items.Add(toolStripDDbtnFile);
            //toolStropCRfile.Item.Add(toolSripDDbtnTextColor);
            #endregion

            #region Setup a parent toolStripDropDown of "Create File" and attach it with 2 toolStripMenuItems of "New" and "Incomplete".
            dropDown_CreateFile = new ToolStripDropDown();
            TSMitemCreateFile.DropDown = dropDown_CreateFile;
            TSMitemCreateFile.DropDownDirection = ToolStripDropDownDirection.Right;//Set the drop-down direction.
            //https://stackoverflow.com/questions/16181980/how-to-add-image-to-toolstripmenuitem

            //Declare and attach 2 main toolStripMenuItems to a related toolStripMenuItem, set their foreground color and text,
            //and add the toolStripMenuItems to the drop-down
            TSMitem_New = new ToolStripMenuItem();
            TSMitem_New.ForeColor = Color.DarkBlue;
            TSMitem_New.Text = CreateFileEnum.CREATE_FROM_NEW.GetDescription();

            TSMitem_Incomplete = new ToolStripMenuItem();
            TSMitem_Incomplete.ForeColor = Color.DarkBlue;
            TSMitem_Incomplete.Text = CreateFileEnum.CREATE_FROM_INCOMPLETE.GetDescription();

            dropDown_CreateFile.Items.AddRange(new ToolStripItem[] { TSMitem_New, TSMitem_Incomplete });
            #endregion Setup a parent toolStripDropDown of "Create File" and attach it with 2 toolStripMenuItems of "New" and "Incomplete".
        }//end initializeDropDownButton()
    }//end class
}//end namespace GradeLib_Huang0045
