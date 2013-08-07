using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class Lectures : CoachingBase
    {
        #region fields
            public int Lecture_ID;
            public DateTime? DateOfLecture;
            public DateTime? StartTime;
            public DateTime? EndTime;
            public int BatchID;
            public int SubjectID;
            public int TeacherID;
            public bool? AttendanceTaken;
            public int SignOffBy_ID;
            public int DPTPreparedBy_ID;
            public string DPTFile;
            public DateTime? DPTDate;
            public int DPTTakenBy_ID;
            public int DPTCorrectedBy_ID;
            public bool? DPTResultDisplayed;
            public string DPTProblemSet;
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
            if (!string.IsNullOrEmpty(DPTFile))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTFile.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTFile);// Coming from C# FORM
            }

            if (!string.IsNullOrEmpty(DPTProblemSet))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTProblemSet.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTProblemSet);// Coming from C# FORM
            }
            #endregion

            #region Int fields
            if (BatchID != 0 && BatchID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.BatchID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(BatchID);// Coming from C# FORM
            }

            if (SubjectID != 0 && SubjectID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.SubjectID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(SubjectID);// Coming from C# FORM
            }

            if (TeacherID != 0 && TeacherID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.TeacherID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TeacherID);// Coming from C# FORM
            }

            if (SignOffBy_ID != 0 && SignOffBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.SignOffBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(SignOffBy_ID);// Coming from C# FORM
            }

            if (DPTPreparedBy_ID != 0 && DPTPreparedBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTPreparedBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTPreparedBy_ID);// Coming from C# FORM
            }

            if (DPTTakenBy_ID != 0 && DPTTakenBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTTakenBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTTakenBy_ID);// Coming from C# FORM
            }

            if (DPTCorrectedBy_ID != 0 && DPTCorrectedBy_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTCorrectedBy_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTCorrectedBy_ID);// Coming from C# FORM
            }
            #endregion

            #region DateTime fields
            if (DateOfLecture != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DateOfLecture.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DateOfLecture.ToString());// Coming from C# FORM
            }
            if (StartTime != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.StartTime.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(StartTime.ToString());// Coming from C# FORM
            }
            if (EndTime != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.EndTime.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(EndTime.ToString());// Coming from C# FORM
            }
            if (DPTDate != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTDate.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTDate.ToString());// Coming from C# FORM
            }
            #endregion

            #region Bool fields
            //AttendanceTaken
            if (AttendanceTaken != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.AttendanceTaken.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(AttendanceTaken);// Coming from C# FORM
            }
            //DPTResultDisplayed
            if (DPTResultDisplayed != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Lectures.DPTResultDisplayed.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DPTResultDisplayed);// Coming from C# FORM
            }
            #endregion

            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Lectures.ToString(), FieldNames, FieldValues);

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
            Lectures gotFromDB = new Lectures();

            #region String
            gotFromDB.DPTFile = dr[DatabaseCoachingInst.Lectures.DPTFile.ToString()].ToString();
            gotFromDB.DPTProblemSet = dr[DatabaseCoachingInst.Lectures.DPTProblemSet.ToString()].ToString();
            #endregion

            #region int
              gotFromDB.Lecture_ID = int.Parse(dr[DatabaseCoachingInst.Lectures.Lecture_ID.ToString()].ToString());
              gotFromDB.BatchID = int.Parse(dr[DatabaseCoachingInst.Lectures.BatchID.ToString()].ToString());
              gotFromDB.SubjectID = int.Parse(dr[DatabaseCoachingInst.Lectures.SubjectID.ToString()].ToString());
              gotFromDB.TeacherID = int.Parse(dr[DatabaseCoachingInst.Lectures.TeacherID.ToString()].ToString());
              gotFromDB.SignOffBy_ID = int.Parse(dr[DatabaseCoachingInst.Lectures.SignOffBy_ID.ToString()].ToString());
              gotFromDB.DPTPreparedBy_ID = int.Parse(dr[DatabaseCoachingInst.Lectures.DPTPreparedBy_ID.ToString()].ToString());
              gotFromDB.DPTTakenBy_ID = int.Parse(dr[DatabaseCoachingInst.Lectures.DPTTakenBy_ID.ToString()].ToString());
              gotFromDB.DPTCorrectedBy_ID = int.Parse(dr[DatabaseCoachingInst.Lectures.DPTCorrectedBy_ID.ToString()].ToString());
            #endregion
            
            #region bool
            gotFromDB.AttendanceTaken = bool.Parse(dr[DatabaseCoachingInst.Lectures.AttendanceTaken.ToString()].ToString());
            gotFromDB.DPTResultDisplayed = bool.Parse(dr[DatabaseCoachingInst.Lectures.DPTResultDisplayed.ToString()].ToString());
            #endregion

            #region DateTime
            if (dr[DatabaseCoachingInst.Lectures.DPTDate.ToString()] != null)
            {
                gotFromDB.DPTDate = DateTime.Parse(dr[DatabaseCoachingInst.Lectures.DPTDate.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.Lectures.StartTime.ToString()] != null)
            {
                gotFromDB.StartTime = DateTime.Parse(dr[DatabaseCoachingInst.Lectures.StartTime.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.Lectures.EndTime.ToString()] != null)
            {
                gotFromDB.EndTime = DateTime.Parse(dr[DatabaseCoachingInst.Lectures.EndTime.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.Lectures.DateOfLecture.ToString()] != null)
            {
                gotFromDB.DateOfLecture = DateTime.Parse(dr[DatabaseCoachingInst.Lectures.DateOfLecture.ToString()].ToString());
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
            if (!string.IsNullOrEmpty(DPTFile))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTFile.ToString(), DPTFile);   //" User_Name = '" + user_name + "' and";
            }
            if (!string.IsNullOrEmpty(DPTProblemSet))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTProblemSet.ToString(), DPTProblemSet);   //" User_Name = '" + user_name + "' and";
            }

            #endregion
            #region int
            if (Lecture_ID != null && Lecture_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.Lecture_ID.ToString(), Lecture_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (BatchID != null && BatchID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.BatchID.ToString(), BatchID);   //" User_Name = '" + user_name + "' and";
            }
            if (SubjectID != null && SubjectID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.SubjectID.ToString(), SubjectID);   //" User_Name = '" + user_name + "' and";
            }
            if (TeacherID != null && TeacherID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.TeacherID.ToString(), TeacherID);   //" User_Name = '" + user_name + "' and";
            }
            if (SignOffBy_ID != null && SignOffBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.SignOffBy_ID.ToString(), SignOffBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (DPTPreparedBy_ID != null && DPTPreparedBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTPreparedBy_ID.ToString(), TeacherID);   //" User_Name = '" + user_name + "' and";
            }
            if (DPTTakenBy_ID != null && DPTTakenBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTTakenBy_ID.ToString(), DPTTakenBy_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (DPTCorrectedBy_ID != null && DPTCorrectedBy_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTCorrectedBy_ID.ToString(), TeacherID);   //" User_Name = '" + user_name + "' and";
            }            
            #endregion

            #region bool
            if (AttendanceTaken != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.AttendanceTaken.ToString(), AttendanceTaken);   //" User_Name = '" + user_name + "' and";
            }

            if (DPTResultDisplayed != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTResultDisplayed.ToString(), DPTResultDisplayed);   //" User_Name = '" + user_name + "' and";
            }
            #endregion

            #region datetime
            if (DPTDate != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.DPTDate.ToString(), DPTDate.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (StartTime != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.StartTime.ToString(), StartTime.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (EndTime != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Lectures.EndTime.ToString(), EndTime.ToString());   //" User_Name = '" + user_name + "' and";
            }

            #endregion
                     

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Lectures.ToString());

            return queryStr;
        }

        #endregion Query
    }
}
