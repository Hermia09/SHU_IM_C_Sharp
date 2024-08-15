using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary_Huang0045.FileStreams
{
    public enum FileProcessBtnEnum
    {
        [Description("Open File")]
        OPEN_FILE = 0,
        [Description("Delete")]
        DELETE = 1,
        [Description("Key into ListBox")]
        KEY_INTO_LISTBOX = 2,
        [Description("Clear")]
        CLEAR = 3,
        [Description("Save File")]
        SAVE_FILE = 4,
        [Description("Display Records (1 by 1) [COMPLETED]")]
        DESPLAY_RECORDS_1By1 = 5,
        [Description("Exit")]
        EXIT = 6,
        [Description("Compute and Show")]
        COMPUTE_AND_SHOW = 7,
        [Description("Draw Pie-Chart/Line-Plot/Bar-Graph")]
        DRAW_PieChart_LinePlot_BarGraph = 8
       
    }//end enum FileProcessEnum
}//end namespace ClassLibrary_Huang0045.FileStreams
