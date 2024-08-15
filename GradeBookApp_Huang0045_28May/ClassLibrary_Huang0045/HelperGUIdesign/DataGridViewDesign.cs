using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary_Huang0045.HelperGUIdesign
{
    public class DataGridViewDesign
    {
        public DataGridViewDesign() { }

        public void initializeDataGridView(DataGridView dataGridView, string[] _headerText)
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView.ColumnCount = _headerText.Length;
            dataGridView.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names. 
            for (int i = 0; i < _headerText.Length; i++)
            {
                dataGridView.Columns[i].HeaderText /*Name*/ = _headerText[i];
            }
        }//InitializeDataGridView
    }
}
