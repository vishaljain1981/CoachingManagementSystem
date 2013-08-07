using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class GroupDiscussion : CoachingBase
    {
        #region fields
        // All fidels of table, name of these fields should be exactly 
        // same as table's field in the database
        public int GDSessionNumber_ID;
        public DateTime? DateOfGD;
        public int TeacherName_ID;
        public DateTime? StartTime;
        public DateTime? EndTime;   
        #endregion fields

        #region Save Methods
        /// <summary>
        /// Object Specific - Mehod to build string for insert data into db
        /// </summary>
        /// <returns></returns>
        override public string buildStringForInsert()
        {
            string FieldNames = "";
            string FieldValues = "";
            if (TeacherName_ID != 0 && TeacherName_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.GroupDiscussion.TeacherName_ID.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(TeacherName_ID);// Coming from C# FORM
            }

            if (DateOfGD != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.GroupDiscussion.DateOfGD.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(DateOfGD.ToString());// Coming from C# FORM
            }
            if (StartTime != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.GroupDiscussion.StartTime.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(StartTime.ToString());// Coming from C# FORM
            }
            if (EndTime != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.GroupDiscussion.EndTime.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(EndTime.ToString());// Coming from C# FORM
            }
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.GroupDiscussion.ToString(), FieldNames, FieldValues);
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
            GroupDiscussion gotFromDB = new GroupDiscussion();
            gotFromDB.GDSessionNumber_ID = int.Parse(dr[DatabaseCoachingInst.GroupDiscussion.GDSessionNumber_ID.ToString()].ToString());
            gotFromDB.TeacherName_ID = int.Parse(dr[DatabaseCoachingInst.GroupDiscussion.TeacherName_ID.ToString()].ToString());
            if (dr[DatabaseCoachingInst.GroupDiscussion.DateOfGD.ToString()] != null)
            {
                gotFromDB.DateOfGD = DateTime.Parse(dr[DatabaseCoachingInst.GroupDiscussion.DateOfGD.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.GroupDiscussion.StartTime.ToString()] != null)
            {
                gotFromDB.StartTime = DateTime.Parse(dr[DatabaseCoachingInst.GroupDiscussion.StartTime.ToString()].ToString());
            }
            if (dr[DatabaseCoachingInst.GroupDiscussion.EndTime.ToString()] != null)
            {
                gotFromDB.EndTime = DateTime.Parse(dr[DatabaseCoachingInst.GroupDiscussion.EndTime.ToString()].ToString());
            }
           // gotFromDB.Batchdescription = dr[DatabaseCoachingInst.Batch.BatchDescription.ToString()].ToString();
           // gotFromDB.class_id = int.Parse(dr[DatabaseCoachingInst.Batch.Class_ID.ToString()].ToString());
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
            if (GDSessionNumber_ID != null && GDSessionNumber_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Batch.Batch_ID.ToString(), GDSessionNumber_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (TeacherName_ID != null && TeacherName_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.GroupDiscussion.TeacherName_ID.ToString(), TeacherName_ID);   //" User_Name = '" + user_name + "' and";
            }
            if (DateOfGD!= null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.GroupDiscussion.DateOfGD.ToString(), DateOfGD.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (StartTime != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.GroupDiscussion.StartTime.ToString(), StartTime.ToString());   //" User_Name = '" + user_name + "' and";
            }

            if (EndTime != null)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.GroupDiscussion.EndTime.ToString(), EndTime.ToString());   //" User_Name = '" + user_name + "' and";
            }

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.GroupDiscussion.ToString());
            return queryStr;
        }
        #endregion Query
    }
}
