using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SharedProject4GB_Huang0045
{
    [Serializable]
    public class GradeRecord
    {
        #region define variables and properties
        public string StudentID { get; set; }
        public string ClassID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double regularMark;
        public double midtermMark;
        public double finalExamMark;//Scores:0~100
        public double RegularRate { get; set; }
        public double MidTermRate { get; set; }
        public double FinalExamRate { get; set; }
        public double SemesterMark { get; set; }
        public string LevelLetter { get; set; }
        public Color color4LevelID { get; set; }
        public string RecordCompleteString { get; set; }
        //public isSemesterDone=false;
        #endregion define variables and properties

        //default constructor with zero parameter
        /// <summary>
        /// Initializes a new instance of the <see cref="GradeRecord" /> class.
        /// </summary>
        public GradeRecord()//Construct
            : this(string.Empty, string.Empty, string.Empty, string.Empty) { }

        /// <summary>Initializes a new instance of the <see cref="GradeRecord" /> class.</summary>
        /// <param name="_studentID">The student identifier.</param>
        /// <param name="_classID">The class identifier.</param>
        /// <param name="_fristName">Name of the frist.</param>
        /// <param name="_lastName">The last name.</param>
        public GradeRecord(string _studentID, string _classID, string _fristName, string _lastName)
        {
            StudentID = _studentID;
            ClassID = _classID;
            FirstName = _fristName;
            LastName = _lastName;
        }//end constructor GradeRecord with 4 parameter

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeRecord" /> class.
        /// </summary>
        /// <param name="_studentID">The student identifier.</param>
        /// <param name="_classID">The class identifier.</param>
        /// <param name="_fristName">Name of the frist.</param>
        /// <param name="_lastName">The last name.</param>
        /// <param name="_regularMark">The regular mark.</param>
        /// <param name="_midtermMark">The midterm mark.</param>
        /// <param name="_finalExamMark">The final exam mark.</param>
        public GradeRecord(string _studentID, string _classID, string _fristName, string _lastName,
           double _regularMark, double _midtermMark, double _finalExamMark)
        {
            StudentID = _studentID;
            ClassID = _classID;
            FirstName = _fristName;
            LastName = _lastName;

            RegularMark = _regularMark;
            MidTermMark = _midtermMark;
            FinalExamMark = _finalExamMark;
        }//end constructor GradeRecord with 7 parameter

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeRecord" /> class.
        /// </summary>
        /// <param name="_studentID">The student identifier.</param>
        /// <param name="_classID">The class identifier.</param>
        /// <param name="_fristName">Name of the frist.</param>
        /// <param name="_lastName">The last name.</param>
        /// <param name="_regularMark">The regular mark.</param>
        /// <param name="_midtermMark">The midterm mark.</param>
        /// <param name="_finalExamMark">The final exam mark.</param>
        /// <param name="_regularRate">The regular rate.</param>
        /// <param name="_midtermRate">The midterm rate.</param>
        /// <param name="_finalExamRate">The final exam rate.</param>
        public GradeRecord(string _studentID, string _classID, string _fristName, string _lastName,
           double _regularMark, double _midtermMark, double _finalExamMark,
           double _regularRate, double _midtermRate, double _finalExamRate)
        {
            StudentID = _studentID;
            ClassID = _classID;
            FirstName = _fristName;
            LastName = _lastName;

            RegularMark = _regularMark;
            MidTermMark = _midtermMark;
            FinalExamMark = _finalExamMark;

            RegularRate = _regularRate;
            MidTermRate = _midtermRate;
            FinalExamRate = _finalExamRate;

            calculateSemestMark(_regularRate, _midtermRate, _finalExamRate);
        }//end constructor GradeRecord with 10 parameter

        /// <summary>
        /// Sets the grade level.
        /// </summary>
        /// <param name="_LevelLetter">The level letter.</param>
        public void setGradeLevel(string _LevelLetter)
        {
            LevelLetter = _LevelLetter;

            RecordCompleteString = ToStringComplete();
        }//end setGradeLevel

        public void calculateSemestMark(double _regulaRate, double _midtermRate, double _finalExamRate)
        {
            RegularRate = _regulaRate;
            MidTermRate = _midtermRate;
            FinalExamRate = _finalExamRate;

            SemesterMark = RegularMark * _regulaRate + MidTermMark * _midtermRate + FinalExamMark * _finalExamRate;
        }//end calculateSemestMark

        /// <summary>
        /// Gets or sets the regular mark.
        /// </summary>
        public double RegularMark
        {
            get
            {
                return regularMark;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    regularMark = value;
                else
                    throw new ArgumentOutOfRangeException("RegularMark", value, "Regular Mark must be >=0 and <=100");
            }
        }

        public double MidTermMark
        {
            get
            {
                return midtermMark;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    midtermMark = value;
                else
                    throw new ArgumentOutOfRangeException("MidTermMark", value, "MidTerm Mark must be >=0 and <=100");
            }
        }
        public double FinalExamMark
        {
            get
            {
                return finalExamMark;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    finalExamMark = value;
                else
                    throw new ArgumentOutOfRangeException("FinalExamMark", value, "Final-Exam Mark must be >=0 and <=100");
            }
        }

        /// <summary>
        /// To the basic string.
        /// Only converts to basic data, including Student ID, Class ID, First Name and Last Name
        /// </summary>
        /// <returns> </returns>
        public string ToBasicString()
        {
            return ($"{StudentID},{ClassID}," +
                    $"{FirstName},{LastName}");
        }//end ToBasicString()

        /// <summary>
        /// Converts to basestring.</summary>
        /// <returns></returns>
        public string ToBaseString()
        {
            return string.Format(
                $"{StudentID,-10},{ClassID,-10},{FirstName,-7},{LastName,-7}," +
                $"{RegularMark,6:F2},{MidTermMark,6:F2},{FinalExamMark,6:F2}");

        }//end method ToBaseString()

        /// <summary>
        /// Converts to string (no rates).
        /// </summary>
        /// <returns> </returns>
        public string ToStringNoRates()
        {
            var gradeRecord = ToBaseString();
            gradeRecord += string.Format($",{SemesterMark,6:F2}");

            return gradeRecord;
        }//end ToStringNoRates()

        /// <summary>
        /// Converts to string (complete).
        /// </summary>
        /// <returns> </returns>
        public string ToStringComplete()
        {
            var gradeRecord = ToStringNoRates();
            gradeRecord += string.Format($",{LevelLetter,-7}");

            return gradeRecord;
        }//end ToStringComplete() 

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var gradeRecord = ToBaseString();
            gradeRecord += string.Format($",{SemesterMark,6:F2},{RegularRate,5:F2}," +
                $"{MidTermRate,5:F2},{FinalExamRate,5:F2}");

            return gradeRecord;
        }//end method ToString
    }//end class GradeRecord
}//end namespace SharedProject4GB_Huang0045
