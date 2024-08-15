using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GradeLib_Huang0045
{
    public enum CreateFileEnum
    {
        [Description("New")]
        CREATE_FROM_NEW = 0,
        [Description("Incomplete")]
        CREATE_FROM_INCOMPLETE = 1,
        [Description("New (Text-Based)")]
        TEXT_BASED_BASICS = 2,
        [Description("New (Binary-Based)")]
        BINARY_BASED_BASICS = 3,
        [Description("Incomplete (Text-Based)")]
        TEXT_BASED_INCOMPLETE = 4,
        [Description("Incomplete (Binary-Based)")]
        BINARY_BASED_INCOMPLETE = 5,
        [Description("Save File")]
        SAVE_FILE = 6

    }//end CreateFileEnum
}//end namespace GradeLib_Huang0045
