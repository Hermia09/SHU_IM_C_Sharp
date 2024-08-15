using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIForms4AnyBook_Huang0045;
using ClassLibrary_Huang0045.FileStreams;
using AnyBookUIForm4Basic_Huang0045;
using GradeLib_Huang0045;
using WinForm4GradeCR_Huang0045;
using WinForm4GradeQuery_Huang0045;

namespace WindFormsAppUsingMDI_GradeBook_Huang0045
{
    public partial class FrmMDI4GradeBook : MDIForms4AnyBook
    {
        public FrmMDI4GradeBook()
        {
            InitializeComponent();
        }

        public override void switchAppModels(FileProcessEnum selectedMenu)
        {
            switch (selectedMenu)
            {
                case FileProcessEnum.CREATE_TEXT:
                    var frmCreateFileText = new Frm4GradeCR();
                    frmCreateFileText.MdiParent = this;
                    frmCreateFileText.Show();
                    break;
                case FileProcessEnum.READ_TEXT:
                    var frmReadFileText = new Frm4GradeCR();
                    frmReadFileText.MdiParent = this;
                    frmReadFileText.Show();
                    break;
                case FileProcessEnum.INQUIRY_TEXT:
                    //var frmCreditInquiryText = new Frm4GradeQuery();
                    var frmCreditInquiryText = new Frm4GradeQuery(null);
                    frmCreditInquiryText.MdiParent = this;
                    frmCreditInquiryText.Show();
                    break;
                //case FileProcessEnum.CREATE_BINARY:
                //    //            var frmCreateFileBinary = new CreateFileFormB_lo0116();
                //    //frmCreateFileBinary.MdiParent = this;
                //    //frmCreateFileBinary.Show();
                //    break;
                //case FileProcessEnum.READ_BINARY:
                //    //            var frmReadFileBinary = new ReadFileFormB_lo0116();
                //    //frmReadFileBinary.MdiParent = this;
                //    //frmReadFileBinary.Show();
                //    break;
                //case FileProcessEnum.INQUIRY_BINARY:
                //    //            var frmCreditInquiryBinary = new CreditInquiryFormB_lo0116();
                //    //frmCreditInquiryBinary.MdiParent = this;
                //    //frmCreditInquiryBinary.Show();
                //    break;
                case FileProcessEnum.EXIT:
                    Application.Exit();
                    break;
            }
        }//end switchAppModels
    }
}
