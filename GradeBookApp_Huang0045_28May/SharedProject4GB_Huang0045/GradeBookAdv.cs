using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using ClassLibrary_Huang0045.HelperEnum;

namespace SharedProject4GB_Huang0045
{
    public class GradeBookAdv
    {
        static bool DEBUG_ON = false;
        public string CourseName { set; get; }
        public string TeacherName { set; get; }
        public double Rate4Regular { set; get; }
        public double Rate4MidTerm { set; get; }
        public double Rate4FinalExam { set; get; }
        public double average = 0, highestValue = -1, lowestValue = double.MaxValue;
        public int highestIndex = 0, lowestIndex = 0;

        public List<GradeRecord> completeRecordList = new List<GradeRecord>();

        public LevelCategoryEnum2[] levelCategoryEnum = { LevelCategoryEnum2.LEVEL_A, LevelCategoryEnum2.LEVEL_B,
            LevelCategoryEnum2.LEVEL_C, LevelCategoryEnum2.LEVEL_D, LevelCategoryEnum2.LEVEL_F };

        //Bar-Char and level-category related variables
        public int levelCategories_LENDTH;

        public static int[] distFrequencies4Levels;
        public static int[] thresholdValues;
        public static string[] levelCategoryLabels_Str;
        //public int[,] lowerAndUpperThresholds4Levels;
        public int unitValue = 10;

        const char SPLITTAB = '\t';
        public GradeBookAdv() { }
        public GradeBookAdv(string _courseName, string _teacherName)
        {
            CourseName = _courseName;
            TeacherName = _teacherName;
        }
        public GradeBookAdv(string _courseName, string _teacherName, double _regularRate, double _midRate, double _finalRate)
        {
            CourseName = _courseName;
            TeacherName = _teacherName;
            setRate(_regularRate, _midRate, _finalRate);
        }

        public GradeBookAdv(string _courseName, string _teacherName, double _regularRate, double _midRate, double _finalRate, List<GradeRecord> _recordList) 
        {
            CourseName = _courseName;
            TeacherName = _teacherName;
            setRate(_regularRate, _midRate, _finalRate);
            completeRecordList = calculateSemester4ListCollection(_recordList).ToList();
            initializeLevelData();
            distFrequencies4Levels = calculateDistribution4Levels(_recordList,
                unitValue, levelCategories_LENDTH, thresholdValues, levelCategoryLabels_Str);
        }//end GradeBookAdv 4

        public void setRate(double _regularRate, double _midRate, double _finalRate, List<GradeRecord> _recordList)
        {
            Rate4Regular = _regularRate;
            Rate4MidTerm = _midRate;
            Rate4FinalExam = _finalRate;
        }//end setRate 1

        public void setRate(double _regularRate, double _midRate, double _finalRate) 
        {
            Rate4Regular = _regularRate;
            Rate4MidTerm = _midRate;
            Rate4FinalExam = _finalRate;
        }//end setRate 2

        public void initializeLevelData() 
        {
            levelCategories_LENDTH = levelCategoryEnum.Length;
            thresholdValues = new int[levelCategories_LENDTH];
            levelCategoryLabels_Str = new string[levelCategories_LENDTH];
            for (int i = 0; i < levelCategories_LENDTH; i++) 
            {
                thresholdValues[i] = (int)levelCategoryEnum[i];
                levelCategoryLabels_Str[i] = levelCategoryEnum[i].GetDescription();
            }
        }//end initializeLevelData

        public void calculateSemesterMark2CompleteRecordList(GradeRecord record) 
        {
            record.SemesterMark = record.RegularMark * Rate4Regular + record.MidTermMark * Rate4MidTerm + record.FinalExamMark * Rate4FinalExam;
            completeRecordList.Add(record);
        }//end calculateSemesterMark2CompleteRecordList

        /// <summary>
        /// Calculates the semester for every record in list collection considered.
        /// </summary>
        /// <param name="_recordList">The record list.</param>
        /// <returns>
        /// </returns>
        public IEnumerable<GradeRecord> calculateSemester4ListCollection(List<GradeRecord> _recordList)
        {
            for (int i = 0; i < _recordList.Count; i++) 
            {
                _recordList[i].SemesterMark = _recordList[i].RegularMark * Rate4Regular +
                                            _recordList[i].MidTermMark * Rate4MidTerm +
                                            _recordList[i].FinalExamMark * Rate4FinalExam;
            }//end for
            return completeRecordList;
        }//end  CalculateSemester4ListCollection

        public double calculateAverage(List<GradeRecord> _recordList) 
        {
            double sum = 0;
            foreach (GradeRecord record in _recordList) 
            {
                sum += record.SemesterMark;
            }

            average = (sum / _recordList.Count);

            return average; //(double)(sum / _recordList.Count)
        }//end calculateAverage

        public double findHighest(List<GradeRecord> _recordList) 
        {
            highestValue = _recordList[0].SemesterMark;
            for (int i = 1; i < _recordList.Count; ++i) 
            {
                if (_recordList[i].SemesterMark > highestValue) 
                {
                    highestValue = _recordList[i].SemesterMark;
                    highestIndex = i;
                }
            }
            return highestValue;
        }//end findHighest

        public double findLowest(List<GradeRecord> _recordList)
        {
            lowestValue = _recordList[0].SemesterMark;
            for (int i = 1; i < _recordList.Count; ++i)
            {
                if (_recordList[i].SemesterMark < lowestValue)
                {
                    lowestValue = _recordList[i].SemesterMark;
                    lowestIndex = i;
                }
            }
            return lowestValue;
        }//end findLowest

        public static IEnumerable<GradeRecord> Linq_RecordListSortDescendingByStudentID(List<GradeRecord> _recordList)
        {
            var sorted =
                from record in _recordList
                orderby record.StudentID descending
                select record;

            return sorted;
        }//end StudentID descending


        public static IEnumerable<GradeRecord> Linq_RecordListSortAscendingByStudentID(List<GradeRecord> _recordList)

        {
            var sorted =
                from record in _recordList
                orderby record.StudentID ascending
                select record;

            return sorted;
        }//end StudentID ascending

        public static IEnumerable<GradeRecord> Linq_RecordListSortDescending(List<GradeRecord> _recordList)
        {
            var sorted =
                from record in _recordList
                orderby record.SemesterMark descending
                select record;

            return sorted;
        }//end SemesterMark descending

        public static IEnumerable<GradeRecord> Linq_RecordListSortAscending(List<GradeRecord> _recordList)
        {
            var sorted =
                from record in _recordList
                orderby record.SemesterMark ascending
                select record;

            return sorted;
        }//end SemesterMark ascending

        /// <summary>
        /// LINQ 切割 大於 給定的臨界值(例如:平均數)(List)
        /// Linqs for the record list filtered above average.</summary>
        /// <param name="recordList">The amounts list.</param>
        /// <param name="ThresholdValue">The average.</param>
        /// <returns> </returns>
        public static IEnumerable<GradeRecord> Linq_RecordListFilteredAboveThreshold(List<GradeRecord> recordList, double ThresholdValue) 
        {
            var filtered =
                from record in recordList
                where record.SemesterMark > ThresholdValue
                select record;

            return filtered;
        }//end Filtered Above Threshold

        /// <summary>
        /// LINQ 切割 小於 給定的臨界值(例如:平均數)(List)
        /// Linqs for the record list filtered above average.</summary>
        /// <param name="recordList">The amounts list.</param>
        /// <param name="ThresholdValue">The average.</param>
        /// <returns> </returns>
        public static IEnumerable<GradeRecord> Linq_RecordListFilteredBelowThreshold(List<GradeRecord> recordList, double ThresholdValue)
        {
            var filtered =
                from record in recordList
                where record.SemesterMark < ThresholdValue
                select record;

            return filtered;
        }//end Filtered Below Threshold

        public static IEnumerable<GradeRecord> selectLevel(List<GradeRecord> recordList, double _upperLimit, double _lowerLimit, double unitValue)
        {
            
            var levelSelect =
                from record in recordList
                where record.SemesterMark >= (_lowerLimit * unitValue) &&
                      record.SemesterMark < (_upperLimit * unitValue)
                select record;

            return levelSelect;
        }//end selectLevel

        /// <summary>
        /// Calculates the distribution of grade-levels.
        /// </summary>
        /// <param name="recordList">The record list.</param>
        /// <param name="unitValue">The unit value.</param>
        /// <param name="levelCategories_LENGTH">Length of the level categories.</param>
        /// <param name="thresholdValues">The threshold values.</param>
        /// <param name="levelCategoryLabels_Str">The level category labels string.</param>
        /// <returns> </returns>
        public static int[] calculateDistribution4Levels(List<GradeRecord> recordList, double unitValue,
            int levelCategories_LENGTH, int[] thresholdValues, string[] levelCategoryLabels_Str)
        {
            List<GradeRecord>[] filteredRecordList = new List<GradeRecord>[levelCategories_LENGTH];

            //stores frequency of grades in each range of grades' categories
            if (DEBUG_ON) MessageBox.Show("frequency_LENGTH (in calDataDistribution())=" + levelCategories_LENGTH);
            int[] _distFrequencies4Levels = new int[levelCategories_LENGTH];

            filteredRecordList[0] = Linq_RecordListFilteredAboveThreshold(recordList, thresholdValues[0] * unitValue).ToList();

            for (int category = 0; category < levelCategories_LENGTH - 1; category++) 
            {
                filteredRecordList[category + 1] = selectLevel(recordList,
                    thresholdValues[category], thresholdValues
                    [category + 1], unitValue).ToList();
                if (DEBUG_ON) MessageBox.Show("_distFrequencies4Levels[" + category + "]=" + _distFrequencies4Levels[category]);
            }
            filteredRecordList[4] = Linq_RecordListFilteredBelowThreshold(recordList, thresholdValues[3] * unitValue).ToList();
            _distFrequencies4Levels[4] = filteredRecordList[4].Count;


            for (int category = 0; category < levelCategories_LENGTH - 1; category++) 
            {
                _distFrequencies4Levels[category] = filteredRecordList
                   [category].ToArray().Length;
            }
            return _distFrequencies4Levels;
        }//end calculateDistribution4Levels

        /// <summary>
        /// Displays the scores.
        /// </summary>
        /// <param name="recordList">The record list.</param>
        /// <param name="displayLisBox">The display lis box.</param>
        /// <param name="displayDataGridView">The display data grid view.</param>
        /// <param name="queryApproach">The query approach.</param>
        public static void displayScores(List<GradeRecord> recordList, 
            ListBox displayLisBox, DataGridView displayDataGridView, int queryApproach) 
        {
            displayDataGridView.Rows.Clear();
            int indexRow = 0;

            foreach (GradeRecord record in recordList) 
            {
                if (queryApproach == (int)QueryApproachEnum.ListBox)
                {
                    displayLisBox.Items.Add(record.ToStringNoRates());
                    //displayLisBox.Items.Add(record);//for the most complete record
                }//end if
                else 
                {
                    displayDataGridView.Rows.Add(record.StudentID,
                        record.ClassID, record.LastName, record.FirstName,
                        record.RegularMark, record.MidTermMark,
                        record.FinalExamMark, record.SemesterMark);

                    record.color4LevelID = decideRecordColorInGridView(record.SemesterMark);
                    displayDataGridView.Rows
                        [indexRow].DefaultCellStyle.BackColor =
                        record.color4LevelID;//level ID

                    indexRow++;
                }//end else
            }//end foreach
            return;
        }//end displayScores

        /// <summary>
        /// Decides the color in grid view.
        /// </summary>
        /// <param name="semesterMark">The semester mark.</param>
        /// <param name="indexRow">The index row.</param>
        /// <param name="displayDataGridView">The display data grid view.</param>
        /// <returns></returns>
        public static Color decideRecordColorInGridView(double semesterMark) 
        {
            Color color4Record = Color.LightGreen;
            if (semesterMark >= ((int)LevelCategoryEnum.LEVEL_A) * 10.0)
            {
                //displayDataGridView.Rows[i].Cells[ELEMENT_NO - 1].Style.BackColor = Color.Green;//OK
                color4Record = Color.YellowGreen;
            }
            else if ((semesterMark < ((int)LevelCategoryEnum.LEVEL_A) * 10.0)
                && (semesterMark >= ((int)LevelCategoryEnum.LEVEL_D) * 10.0))
            {
                //displayDataGridView.Rows[i].Cells[ELEMENT_NO - 1].Style.BackColor = Color.Yellow;//OK
                color4Record = Color.LightYellow;
            }
            else 
            {
                //displayDataGridView.Rows[i].Cells[ELEMENT_NO - 1].Style.BackColor = Color.Red;//OK
                color4Record = Color.OrangeRed;
            }
            return color4Record;
        }//end decideRecordColorInGridView

    }//end class GradeBookAdv
}//end namespace SharedProject4GB_Huang0045
