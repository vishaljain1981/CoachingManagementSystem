using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
   public class Subject : CoachingBase
    {
        #region fields
        // All fidels of table, name of these fields should be exactly 
        // same as table's field in the database
        private int Subject_ID;
        public int Subject_ID1
        {
            get { return Subject_ID; }
            set { Subject_ID = value; }
        }
        private string SubjectName;
        public string SubjectName1
        {
            get { return SubjectName; }
            set { SubjectName = value; }
        }
        private int Class_ID;
        public int Class_ID1
        {
            get { return Class_ID; }
            set { Class_ID = value; }
        }
        private string SubjectDescription;
        public string SubjectDescription1
        {
            get { return SubjectDescription; }
            set { SubjectDescription = value; }
        }    
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
            if (!string.IsNullOrEmpty(SubjectName))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Subject.SubjectName.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(SubjectName);// Coming from C# FORM
            }
            // Gaurav - Pls change below fields according to above format and test
            if (Class_ID != null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Subject.Class_ID.ToString());
                FieldValues += getInsertStringFieldValue(Class_ID);
            }
            if (!string.IsNullOrEmpty(SubjectDescription))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Subject.SubjectDescription.ToString());
                FieldValues += getInsertStringFieldValue(SubjectDescription);
            }
            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Subject.ToString(), FieldNames, FieldValues);
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
            Subject gotUserFromDB = new Subject();
            // Gaurav - Replace below as first one
            gotUserFromDB.Subject_ID = int.Parse(dr[DatabaseCoachingInst.Subject.Subject_ID.ToString()].ToString());
            gotUserFromDB.SubjectName = dr[DatabaseCoachingInst.Subject.SubjectName.ToString()].ToString();
            gotUserFromDB.Class_ID = int.Parse(dr[DatabaseCoachingInst.Subject.Class_ID.ToString()].ToString());
            gotUserFromDB.SubjectDescription = dr[DatabaseCoachingInst.Subject.SubjectDescription.ToString()].ToString();
            // write similar code for other fields.
            return gotUserFromDB;
        }
        /// <summary>
        /// Object spcivic method
        /// </summary>
        /// <returns></returns>
        override public string buildStringForQuery()
        {
            // Select * from User where userName='Vishal' and address='XYZ'
            string queryStr = "";
            if (!string.IsNullOrEmpty(SubjectName))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Subject.SubjectName.ToString(), SubjectName);   //" User_Name = '" + user_name + "' and";
            }
            // Gaurav - do similar to avove for rest of fields
            if (Class_ID !=null && Class_ID !=0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Subject.Class_ID.ToString(), Class_ID);
            }
            if (!string.IsNullOrEmpty(SubjectDescription))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Subject.SubjectDescription.ToString(), SubjectDescription);
            }
            if (Subject_ID != null && Subject_ID != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Subject.Subject_ID.ToString(), Subject_ID);
            }          
            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Subject.ToString());
            return queryStr;
        }
        #endregion Query
    }
}
