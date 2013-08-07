using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class MainTestTracking : CoachingBase
    {
        #region fields
            public string TestPaperFileName;
            public int TestPaper_ID;
            public int PreparedBy_ID;
            public int ReviewedBy_ID;
            public int TestTakenBy_ID;
            public int CopyCorrector_ID;
            public bool? IsNumericalTest;
            public bool? InformedToStudents;
            public DateTime? DateOfTestPaper;
            public DateTime? CopyToCorrectorGivenOn;
            public DateTime? CopiesGivenOn;
            public DateTime? CopiesCollectedOn;
            public DateTime? ResultDisplayedOn;
        #endregion

        #region Save Methods
        /// <summary>
        /// Object Specific - Mehod to build string for insert data into db
        /// </summary>
        /// <returns></returns>
        override public string buildStringForInsert()
        {
            string FieldNames = "";
            string FieldValues = "";
            #region StringFields
            if (!string.IsNullOrEmpty(TestPaperFileName))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.TestPaperFileName.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TestPaperFileName);// Coming from C# FORM
            }
            #endregion

            #region Int fields
            if (TestPaper_ID != 0 && TestPaper_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.TestPaper_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TestPaper_ID);// Coming from C# FORM
            }

            if (PreparedBy_ID != 0 && PreparedBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.PreparedBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(PreparedBy_ID);// Coming from C# FORM
            }

            if (ReviewedBy_ID != 0 && ReviewedBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.PreparedBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(ReviewedBy_ID);// Coming from C# FORM
            }

            if (TestTakenBy_ID != 0 && TestTakenBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.TestTakenBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TestTakenBy_ID);// Coming from C# FORM
            }

            if (CopyCorrector_ID != 0 && CopyCorrector_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.CopyCorrector_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(CopyCorrector_ID);// Coming from C# FORM
            }
            #endregion

            #region DateTime fields
            if (DateOfTestPaper != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.DateOfTestPaper.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DateOfTestPaper.ToString());// Coming from C# FORM
            }
            if (CopyToCorrectorGivenOn != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.CopyToCorrectorGivenOn.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(CopyToCorrectorGivenOn.ToString());// Coming from C# FORM
            }
            if (CopiesGivenOn != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.CopiesGivenOn.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(CopiesGivenOn.ToString());// Coming from C# FORM
            }
            if (CopiesCollectedOn != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.CopiesCollectedOn.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(CopiesCollectedOn.ToString());// Coming from C# FORM
            }
            if (ResultDisplayedOn != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.ResultDisplayedOn.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(ResultDisplayedOn.ToString());// Coming from C# FORM
            }
            #endregion

            #region Bool fields
            //AttendanceTaken
            if (IsNumericalTest != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.IsNumericalTest.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(IsNumericalTest);// Coming from C# FORM
            }
            //DPTResultDisplayed
            if (InformedToStudents != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.MainTestTracking.InformedToStudents.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(InformedToStudents);// Coming from C# FORM
            }
            #endregion

            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.MainTestTracking.ToString(), FieldNames, FieldValues);

            return insertIntoString;

        }
        #endregion Save Method

        #region Query
        /// <summary>
        /// Object Specific function
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        override public object convertFromReader(OleDbDataReader dr)
        {
            MainTestTracking gotFromDB = new MainTestTracking();

            #region String
            gotFromDB.TestPaperFileName = dr[DatabaseCoachingInst.MainTestTracking.TestPaperFileName.ToString()].ToString();
            #endregion

            #region int
            gotFromDB.TestPaper_ID = int.Parse(dr[DatabaseCoachingInst.MainTestTracking.TestPaper_ID.ToString()].ToString());
            gotFromDB.PreparedBy_ID = int.Parse(dr[DatabaseCoachingInst.MainTestTracking.PreparedBy_ID.ToString()].ToString());
            gotFromDB.ReviewedBy_ID = int.Parse(dr[DatabaseCoachingInst.MainTestTracking.ReviewedBy_ID.ToString()].ToString());
            gotFromDB.TestTakenBy_ID = int.Parse(dr[DatabaseCoachingInst.MainTestTracking.TestTakenBy_ID.ToString()].ToString());
            gotFromDB.CopyCorrector_ID = int.Parse(dr[DatabaseCoachingInst.MainTestTracking.CopyCorrector_ID.ToString()].ToString());
            #endregion

            #region bool
            gotFromDB.IsNumericalTest = bool.Parse(dr[DatabaseCoachingInst.MainTestTracking.IsNumericalTest.ToString()].ToString());
            gotFromDB.InformedToStudents = bool.Parse(dr[DatabaseCoachingInst.MainTestTracking.InformedToStudents.ToString()].ToString());
            #endregion

            #region DateTime
            if (dr[DatabaseCoachingInst.MainTestTracking.DateOfTestPaper.ToString()] != null)
            {
                gotFromDB.DateOfTestPaper = DateTime.Parse(dr[DatabaseCoachingInst.MainTestTracking.DateOfTestPaper.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.MainTestTracking.CopyToCorrectorGivenOn.ToString()] != null)
            {
                gotFromDB.CopyToCorrectorGivenOn = DateTime.Parse(dr[DatabaseCoachingInst.MainTestTracking.CopyToCorrectorGivenOn.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.MainTestTracking.CopiesGivenOn.ToString()] != null)
            {
                gotFromDB.CopiesGivenOn = DateTime.Parse(dr[DatabaseCoachingInst.MainTestTracking.CopiesGivenOn.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.MainTestTracking.CopiesCollectedOn.ToString()] != null)
            {
                gotFromDB.CopiesCollectedOn = DateTime.Parse(dr[DatabaseCoachingInst.MainTestTracking.CopiesCollectedOn.ToString()].ToString());
            }
             if (dr[DatabaseCoachingInst.MainTestTracking.ResultDisplayedOn.ToString()] != null)
            {
                gotFromDB.ResultDisplayedOn = DateTime.Parse(dr[DatabaseCoachingInst.MainTestTracking.ResultDisplayedOn.ToString()].ToString());
            }
            #endregion

            // write similar code for other fields.
            return gotFromDB;
        }

        /// <summary>
        /// Object spcivic method
        /// </summary>
        /// <returns></returns>
        override public string buildStringForQuery()
        {
            // Select * from User where userName='Vishal' and address='XYZ'
            string queryStr = "";

            #region string
            if (!string.IsNullOrEmpty(TestPaperFileName))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.TestPaperFileName.ToString(), TestPaperFileName);   //" User_Name = '" + user_name + "' and";
            }           

            #endregion
            #region int
            if (TestPaper_ID != null && TestPaper_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.TestPaper_ID.ToString(), TestPaper_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (PreparedBy_ID != null && PreparedBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.PreparedBy_ID.ToString(), PreparedBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (ReviewedBy_ID != null && ReviewedBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.ReviewedBy_ID.ToString(), ReviewedBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (TestTakenBy_ID != null && TestTakenBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.ReviewedBy_ID.ToString(), TestTakenBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (CopyCorrector_ID != null && CopyCorrector_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.CopyCorrector_ID.ToString(), CopyCorrector_ID);   //" User_Name = '" + user_name + "' and";
            }
            #endregion

            #region bool
            if (IsNumericalTest != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.IsNumericalTest.ToString(), IsNumericalTest);   //" User_Name = '" + user_name + "' and";
            }

            if (InformedToStudents != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.InformedToStudents.ToString(), InformedToStudents);   //" User_Name = '" + user_name + "' and";
            }
            #endregion

            #region datetime
            if (DateOfTestPaper != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.DateOfTestPaper.ToString(), DateOfTestPaper.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (CopyToCorrectorGivenOn != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.CopyToCorrectorGivenOn.ToString(), CopyToCorrectorGivenOn.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (CopiesGivenOn != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.CopiesGivenOn.ToString(), CopiesGivenOn.ToString());   //" User_Name = '" + user_name + "' and";
            }
            if (CopiesCollectedOn != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.CopiesCollectedOn.ToString(), CopiesCollectedOn.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (ResultDisplayedOn != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.MainTestTracking.ResultDisplayedOn.ToString(), ResultDisplayedOn.ToString());   //" User_Name = '" + user_name + "' and";
            }
            #endregion            
            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Lectures.ToString());
            return queryStr;
        }
        #endregion Query
    }
}
