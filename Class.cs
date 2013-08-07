using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    class Class_dep : CoachingBase
    {
        #region fields
        // All fidels of table, name of these fields should be exactly 
        // same as table's field in the database
        private int class_id;

        public int Class_id
        {
            get { return class_id; }
            set { class_id = value; }
        }
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        private string classDescription;

        public string ClassDescription
        {
            get { return classDescription; }
            set { classDescription = value; }
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

            if (!string.IsNullOrEmpty(classDescription))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Class.ClassDescription.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(classDescription);// Coming from C# FORM
            }

            if (!string.IsNullOrEmpty(className))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.Class.ClassName.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(className);// Coming from C# FORM
            }

            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.Class.ToString(), FieldNames, FieldValues);

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
            Class gotFromDB = new Class();
   
            gotFromDB.Class_id = int.Parse(dr[DatabaseCoachingInst.Class.Class_id.ToString()].ToString());
            gotFromDB.ClassDescription = dr[DatabaseCoachingInst.Class.ClassDescription.ToString()].ToString();
            gotFromDB.ClassName = dr[DatabaseCoachingInst.Class.ClassName.ToString()].ToString();

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


            if (!string.IsNullOrEmpty(className))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Class.ClassName.ToString(), className);   //" User_Name = '" + user_name + "' and";
            }

            if (!string.IsNullOrEmpty(classDescription))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Class.ClassDescription.ToString(), classDescription);   //" User_Name = '" + user_name + "' and";
            }

            if (class_id != null && class_id != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.Class.Class_id.ToString(), class_id);   //" User_Name = '" + user_name + "' and";
            }

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.Class.ToString());

            return queryStr;
        }

        #endregion Query

    }
}
