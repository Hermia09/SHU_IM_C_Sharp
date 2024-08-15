using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary_Huang0045.HelperEnum
{
    public enum MDILayoutEnum
    {
        [Description("Cascade")] CASCADE_LAYOUT = 1,
        [Description("Tile Horizontal")] TTILE_HORIZONTAL_LAYOUT = 2,
        [Description("Tile Vertical")] TTILE_VERTICAL_LAYOUT = 3,
    }
}
