using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    public class user : CoachingBase
    {
        #region fields
        // All fidels of table, name of these fields should be exactly 
        // same as table's field in the database
        private string user_name;
        private int user_role_id;
        private string address;
        private string phone;
        private string email_id;
        private string passwrod;
        private int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email_id
        {
            get { return email_id; }
            set { email_id = value; }
        }

        public string Passwrod
        {
            get { return passwrod; }
            set { passwrod = value; }
        }

        public int User_role_id
        {
            get { return user_role_id; }
            set { user_role_id = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        #endregion fields

        #region Save Methods
        /// <summary>
        /// Object Specific - Mehod to build string for insert data into db
        /// </summary>
        /// <returns></returns>
        override public string buildStringForInsert()
        {
            string FieldNames="";
            string FieldValues="";

            if (!string.IsNullOrEmpty(user_name))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.user_name.ToString());// Coming from Table in Database
                FieldValues += getInsertStringFieldValue(user_name);// Coming from C# FORM
            }

            // Gaurav - Pls change below fields according to above format and test
            if (!string.IsNullOrEmpty(address))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.Address.ToString());
                FieldValues += getInsertStringFieldValue(address);
            }

            if (!string.IsNullOrEmpty(phone))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.Phone.ToString());
                FieldValues += getInsertStringFieldValue(Phone);
            }

            if (!string.IsNullOrEmpty(email_id))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.email.ToString());
                FieldValues += getInsertStringFieldValue(email_id);
            }

            if (!string.IsNullOrEmpty(passwrod))
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.password.ToString());
                FieldValues += getInsertStringFieldValue(Passwrod);
            }

            if (user_role_id!=null)
            {
                FieldNames += getInsertStringField(DatabaseCoachingInst.User.user_role_id.ToString());
                FieldValues += getInsertStringFieldValue(User_role_id);
            }

            string insertIntoString = getFinalInsertString(DatabaseCoachingInst.Tables.User.ToString(),FieldNames,FieldValues);

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
            user gotUserFromDB = new user();
            // Gaurav - Replace below as first one
            gotUserFromDB.address = dr[DatabaseCoachingInst.User.Address.ToString()].ToString();
            gotUserFromDB.Passwrod = dr[DatabaseCoachingInst.User.password.ToString()].ToString();
            gotUserFromDB.Phone = dr[DatabaseCoachingInst.User.Phone.ToString()].ToString();
            gotUserFromDB.User_name = dr[DatabaseCoachingInst.User.user_name.ToString()].ToString();
            gotUserFromDB.User_role_id = int.Parse(dr[DatabaseCoachingInst.User.user_role_id.ToString()].ToString());
            gotUserFromDB.Email_id = dr[DatabaseCoachingInst.User.email.ToString()].ToString();
            gotUserFromDB.User_id = int.Parse(dr[DatabaseCoachingInst.User.user_id.ToString()].ToString());
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


            if (!string.IsNullOrEmpty(user_name))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.user_name.ToString(), user_name);   //" User_Name = '" + user_name + "' and";
            }

            // Gaurav - do similar to avove for rest of fields
            if (!string.IsNullOrEmpty(address))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.Address.ToString(), address);
            }

            if (!string.IsNullOrEmpty(phone))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.Phone.ToString(), phone);
            }

            if (!string.IsNullOrEmpty(email_id))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.email.ToString(), email_id);
            }

            if (!string.IsNullOrEmpty(passwrod))
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.password.ToString(), passwrod);
            }

            if (user_role_id != null && user_role_id != 0)
            {
                queryStr += getQueryPartialString(DatabaseCoachingInst.User.user_role_id.ToString(), user_role_id);
            }

            queryStr = getFinalQueryString(queryStr, DatabaseCoachingInst.Tables.User.ToString());

            return queryStr;
        }
        #endregion Query

    }
}
