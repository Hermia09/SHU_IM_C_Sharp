using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary_Huang0045.FileStreams
{
    public enum FileStreamMenuEnum
    {
        [Description("Choose File")]
        Choose_File,
        [Description("New File (Text-Based)")]
        New_File_TB,//TB:Text-Based
        [Description("Existing File (Text-Based)")]
        Existing_File_TB,
        [Description("New File (Byte-Based)")]
        New_File_BB,//BB:Byte-Based
        [Description("Exisiting File (Byte-Based)")]
        Exisiting_File_BB,
        [Description("Create File")]
        Create_File,
        [Description("Write File")]
        Write_File,
        [Description("Read File")]
        Read_File,
        [Description("Close File")]
        Close_File,
        [Description("Exit")]
        Exit
    }//end enum FileStreamEnum

    public enum FileStreamBasedEnum
    {
        Text_Based,
        Binary_Based
    }//end enum FileStreamEnum

    public enum FileStreamBasedEnum2
    {
        CHARACTER_BASED = 1,
        BYTE_BASED = 2,
        TEXT_BASED = 3,
        EXIT = 4
    }//end enum FileStreamEnum2

    public enum FileStreamBasedEnumNew
    {
        [Description("Character-Based")]
        CHARACTER_BASED = 1,
        [Description("Byte-based")]
        BYTE_BASED = 2,
        [Description("Text-Based")]
        TEXT_BASED = 3,
        [Description("Exit")]
        EXIT = 4
    }//End of FileStreamEnun

    public enum FileProcessEnum
    {
        [Description("Create (Text)")] CREATE_TEXT = 1,
        [Description("Read (Text)")] READ_TEXT = 2,
        [Description("Inquiry (Text)")] INQUIRY_TEXT = 3,
        [Description("Create (Binary)")] CREATE_BINARY = 4,
        [Description("Read (Binary)")] READ_BINARY = 5,
        [Description("Inquiry (Binary)")] INQUIRY_BINARY = 6,
        [Description("Exit")] EXIT = 7,
    }

}//end namespace ClassLibrary_Huang0045.FileStreams
