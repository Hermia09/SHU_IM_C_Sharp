using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace SharedProject4GB_Huang0045
{
    public enum LevelCategoryEnum 
    {
        [Description("Level A+:100")]
        LEVEL_A_PLUS = 10,
        [Description("Level A: 90~99")]
        LEVEL_A = 9,
        [Description("Level B: 80~89")]
        LEVEL_B = 8,
        [Description("Level C: 70~79")]
        LEVEL_C = 7,
        [Description("Level D: 60~69")]
        LEVEL_D = 6,
        [Description("Level F: < 60")]
        LEVEL_F = 5,
    }//end LevelCategoryEnum 

    public enum LevelCategoryEnum2
    {
        [Description("A+")]
        LEVEL_A_PLUS = 10,
        [Description("A")]
        LEVEL_A = 9,
        [Description("B")]
        LEVEL_B = 8,
        [Description("C")]
        LEVEL_C = 7,
        [Description("D")]
        LEVEL_D = 6,
        [Description("F")]
        LEVEL_F = 5,
    }//end LevelCategoryEnum 

    public enum GradeRecordEnumAdv
    {
        [Description("Teacher-Name:")]
        TEACHER_NAME,
        [Description("Couser-Name:")]
        COUSER_NAME,
        [Description("Class-ID:")]
        CLASS_ID,
        [Description("No of Student:")]
        STUDENT_NO,
        [Description("No of Regular:")]
        REGULAR_RECORD_NO,
        [Description("Student-ID:")]
        STUDENT_ID,
        [Description("First-Name:")]
        FIRST_NAME,
        [Description("Last-Name:")]
        LAST_NAME,
        [Description("Mid-Term:")]
        MIDTERM_GRADE,
        [Description("Final-Exam:")]
        FINAL_EXAM_GRADE,
        [Description("Regular:")]
        REGULAR_MARK,
        [Description("Semester:")]
        SEMESTER_MARK,
        [Description("% Mid-Term:")]
        RATE_MIDTERM,
        [Description("% Final-Exam:")]
        RATE_FINALEXAM,
        [Description("% Regular:")]
        RATE_REGULARMARK,
        [Description("Sum-of-Rate")]
        SUM_OF_RATES,

        [Description("1st")]
        R_1ST,
        [Description("2nd")]
        R_2ND,
        [Description("3rd")]
        R_3RD,
        [Description("4th")]
        R_4TH,
        [Description("5th")]
        R_5TH,
        [Description("6th")]
        R_6TH,
        [Description("7th")]
        R_7TH,
        [Description("8th")]
        R_8TH,
        [Description("9th")]
        R_9TH,
        [Description("10th")]
        R_10TH,
        [Description("11st")]
        R_11ST,
        [Description("12nd")]
        R_12ND,
    }//end enum GradeRecordEnumAdv

    public enum GradeBookEnum
    {
        [Description("Teacher-Name:")]
        TEACHER_NAME,
        [Description("Couser-Name:")]
        COUSER_NAME,
        [Description("Class-ID:")]
        CLASS_ID,
        [Description("No of Student:")]
        STUDENT_NO,
        [Description("No of Regular:")]
        REGULAR_RECORD_NO,
        [Description("Student-ID:")]
        STUDENT_ID,
        [Description("First-Name:")]
        FIRST_NAME,
        [Description("Last-Name:")]
        LAST_NAME,
        [Description("Mid-Term:")]
        MIDTERM_GRADE,
        [Description("Final-Exam:")]
        FINAL_EXAM_GRADE,
        [Description("Regular:")]
        REGULAR_MARK,
        [Description("Semester:")]
        SEMESTER_MARK,
        [Description("%Mid-Term:")]
        RATE_MIDTERM,
        [Description("%Final-Exam:")]
        RATE_FINALEXAM,
    }//end enum GradeBookEnum

    public enum GradeRecordEnum
    {
        [Description("Student-ID")]
        STUDENT_ID = 0,
        [Description("Class-ID")]
        CLASS_ID = 1,
        [Description("First-Name")]
        FIRST_NAME = 2,
        [Description("Last-Name")]
        LAST_NAME = 3,
        [Description("Regular")]
        REGULAR_MARK = 4,
        [Description("MidTerm")]
        MIDTERM_GRADE = 5,
        [Description("Final-Exam")]
        FINALEXAME_GRADE = 6,
        [Description("Regular-Rate")]
        REGULAR_RATE = 7,
        [Description("Midterm-Rate")]
        MIDTERM_RATE = 8,
        [Description("FinalExam-Rate")]
        FINALEXAME_RATE = 9,
        [Description("Semester-Mark")]
        SEMESTER_MARK = 10,
    }// end GradeRecordEnum

    public enum RatesEnum
    {
        [Description("%MidTerm")]
        RATE_MIDTERM = 0,
        [Description("%Final-Exam")]
        RATE_FINALEXAM = 1,
        [Description("%Regular")]
        RATE_REGULAR = 2,
        [Description("Sum-of-Rate")]
        SUM_OF_RATES = 3
    }//end RateEnum

    public enum ToolStripMenuItemEnum
    {
        [Description("Calculate")]
        PROCESS_DATA,
        [Description("Set Profile")]
        SET_PROFILE,
        [Description("Clear Profile")]
        CLEAR_PROFILE,
        [Description("Clear Record")]
        CLEAR_RECORD,
        [Description("Clear Rates")]
        CLEAR_RATES,
        [Description("Reset All")]
        RESET_ALL,
        [Description("Show ListBox")]
        SHOW_LISTBOX,
        [Description("Hide ListBox")]
        HIDE_LISTBOX,
        [Description("Get Report")]
        GET_REPORT,
        [Description("Write Report")]
        WRITE_REPORT,
        [Description("Show a Record")]
        SHOW_A_RECORD,
        [Description("Delete Records")]
        DELETE_RECORDS,
        [Description("Exit")]
        EXIT

    }
    public enum RegularEnum
    {
        [Description("1st")]
        R_1st,
        [Description("2nd")]
        R_2nd,
        [Description("3rd")]
        R_3rd,
        [Description("4th")]
        R_4th,
        [Description("5th")]
        R_5th,
        [Description("6th")]
        R_6th,
        [Description("7th")]
        R_7th,
        [Description("8th")]
        R_8th,
        [Description("9th")]
        R_9th,
        [Description("10th")]
        R_10th,
        [Description("11th")]
        R_11th,
        [Description("12th")]
        R_12th,
    }//end RegularEnum

    public enum QueryApproachEnum
    {
        ListBox = 0,
        DataGridView = 1
    }//end  QueryApproachEnum

}//end namespace SharedProject4GB_Huang0045
