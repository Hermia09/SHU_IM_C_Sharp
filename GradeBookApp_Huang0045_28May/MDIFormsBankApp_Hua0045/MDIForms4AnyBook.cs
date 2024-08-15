using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_Huang0045.FileStreams;
using ClassLibrary_Huang0045.HelperEnum;

namespace MDIForms4AnyBook_Huang0045
{
    public partial class MDIForms4AnyBook : Form
    {
        MDILayoutEnum[] AppEnums = { MDILayoutEnum.CASCADE_LAYOUT, MDILayoutEnum.TTILE_HORIZONTAL_LAYOUT, MDILayoutEnum.TTILE_VERTICAL_LAYOUT };
        
        FileProcessEnum[] fileProcessEnums = { FileProcessEnum.CREATE_TEXT,FileProcessEnum.READ_TEXT,FileProcessEnum.INQUIRY_TEXT,FileProcessEnum.CREATE_BINARY,
                                               FileProcessEnum.READ_BINARY,FileProcessEnum.INQUIRY_BINARY,FileProcessEnum.EXIT};

        public MDIForms4AnyBook()
        {
            InitializeComponent();
        }

        private void BankAppToolStripMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem senderBankApp = (ToolStripMenuItem) sender;
            String menuType = senderBankApp.Text;
            FileProcessEnum selectedMenu = FileProcessEnum.CREATE_TEXT;

            for (int item = 0; item < fileProcessEnums.Length; ++item)
            {
                if (menuType == fileProcessEnums[item].GetDescription())
                {
                    selectedMenu = fileProcessEnums[item];
                    break;
                }
            }
            switchAppModels(selectedMenu);
        }

        public virtual void switchAppModels(FileProcessEnum selectedMenu)
        {

        }

        private void LayoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem senderBankApp = (ToolStripMenuItem)sender;
            String menuType = senderBankApp.Text;
            MDILayoutEnum selectedMDILayout = MDILayoutEnum.CASCADE_LAYOUT;

            for (int item = 0; item < AppEnums.Length; ++item)
            {
                if (menuType == AppEnums[item].GetDescription())
                {
                    selectedMDILayout = AppEnums[item];
                    break;
                }
            }
            switchLayout(selectedMDILayout);
        }// end of LayoutToolStripMenuItem1_Click

        private void switchLayout(MDILayoutEnum selectedMDILayout)
        {
            switch (selectedMDILayout)
            {
                case MDILayoutEnum.CASCADE_LAYOUT:
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case MDILayoutEnum.TTILE_HORIZONTAL_LAYOUT:
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case MDILayoutEnum.TTILE_VERTICAL_LAYOUT:
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
            }
        }// end of switchLayout

    }// end of class
}// end of namespce
