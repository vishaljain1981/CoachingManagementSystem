using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class ProblemSolvingTracking : CoachingBase
    {
        #region fields
            public int ProblemSSNumber_ID;
            public int TeacherName_ID;
            public int Admin_ID;
            public bool? ProblemSetGivenToTeacher;
            public DateTime? DateOfPSS;
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

            #region int
            if (ProblemSSNumber_ID != 0 && ProblemSSNumber_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ProblemSolvingTracking.ProblemSSNumber_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(ProblemSSNumber_ID);// Coming from C# FORM
            }

            if (TeacherName_ID != 0 && TeacherName_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ProblemSolvingTracking.TeacherName_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TeacherName_ID);// Coming from C# FORM
            }

            if (Admin_ID != 0 && Admin_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ProblemSolvingTracking.Admin_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(Admin_ID);// Coming from C# FORM
            }
            #endregion

            #region bool
            if (ProblemSetGivenToTeacher != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ProblemSolvingTracking.ProblemSetGivenToTeacher.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(ProblemSetGivenToTeacher);// Coming from C# FORM
            }
            #endregion
            #region Date
            if (DateOfPSS != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.ProblemSolvingTracking.DateOfPSS.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DateOfPSS.ToString());// Coming from C# FORM
            }

            #endregion
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.ProblemSolvingTracking.ToString(), FieldNames, FieldValues);

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
            ProblemSolvingTracking gotFromDB = new ProblemSolvingTracking();
            #region int
            gotFromDB.ProblemSSNumber_ID = int.Parse(dr[DatabaseCoachingInst.ProblemSolvingTracking.ProblemSSNumber_ID.ToString()].ToString());
            gotFromDB.TeacherName_ID = int.Parse(dr[DatabaseCoachingInst.ProblemSolvingTracking.TeacherName_ID.ToString()].ToString());
            gotFromDB.Admin_ID = int.Parse(dr[DatabaseCoachingInst.ProblemSolvingTracking.Admin_ID.ToString()].ToString());
            #endregion

            #region Bool
            gotFromDB.ProblemSetGivenToTeacher = bool.Parse(dr[DatabaseCoachingInst.ProblemSolvingTracking.ProblemSetGivenToTeacher.ToString()].ToString());
            #endregion

            #region DateTime
            if (dr[DatabaseCoachingInst.ProblemSolvingTracking.DateOfPSS.ToString()] != null)
            {
                gotFromDB.DateOfPSS = DateTime.Parse(dr[DatabaseCoachingInst.ProblemSolvingTracking.DateOfPSS.ToString()].ToString());
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

            #region int
            if (ProblemSSNumber_ID != null && ProblemSSNumber_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ProblemSolvingTracking.ProblemSSNumber_ID.ToString(), ProblemSSNumber_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (TeacherName_ID != null && TeacherName_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ProblemSolvingTracking.TeacherName_ID.ToString(), TeacherName_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (Admin_ID != null && Admin_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ProblemSolvingTracking.Admin_ID.ToString(), Admin_ID);   //" User_Name = '" + user_name + "' and";
            }
           
            #endregion

            #region bool
            if (ProblemSetGivenToTeacher != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ProblemSolvingTracking.ProblemSetGivenToTeacher.ToString(), ProblemSetGivenToTeacher);   //" User_Name = '" + user_name + "' and";
            }

            #endregion

            #region datetime
            if (DateOfPSS != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.ProblemSolvingTracking.DateOfPSS.ToString(), DateOfPSS.ToString());   //" User_Name = '" + user_name + "' and";
            }

            
            #endregion
            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.ProblemSolvingTracking.ToString());
            return queryStr;
        }

        #endregion Query
    }
}
