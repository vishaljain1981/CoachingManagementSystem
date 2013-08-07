using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        #region  second method for connection string
      //      String connect = ConfigurationManager.AppSettings["con"];
      //      String connect = ConfigurationSettings.AppSettings["con"];
      //      System.Data.OleDb.OleDbConnection connectionstring = new System.Data.OleDb.OleDbConnection(connect);
      //      connectionstring.Open();
      //      string string2 = "insert into Lecture(STARTTIME,ENDTIME) values('" + STARTTIME.Text + "','" + ENDTIME.Text + "')";
      //      System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(string2, connectionstring);
      //      cmd.ExecuteNonQuery();
      //      connectionstring.Close();
        #endregion

        #region first method for connection string
         //   System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
         //   conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\PenDrive\mydatabase.accdb;User Id=admin;Password=;";
         //   conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\PenDrive\mydatabase.accdb;User Id=admin;Password=;";
         //   conn.Open();
         //   string string1 = "insert into Lecture(STARTTIME,ENDTIME) values('" + STARTTIME.Text + "','" + ENDTIME.Text + "')";
         //   System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(string1, conn);
         //   cmd.ExecuteNonQuery();
         //   conn.Close();
        #endregion
        }
        #region panel click but no code to be written
        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
        #endregion

        #region my code on button click
        private void Get_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\PenDrive\mydatabase.accdb;User Id=admin;Password=;";
            conn.Open();
            string string1 = "Select STARTTIME,ENDTIME from Lecture";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(string1, conn);
            System.Data.OleDb.OleDbDataReader r = cmd.ExecuteReader();

            #region while loop
            while (r.Read())
            {
                String string2 = r["STARTTIME"].ToString();
                String string3 = r["ENDTIME"].ToString();
                //STARTTIME_Get.Text = string2;
                //ENDTIME_Get.Text = string3;

            }
            #endregion   

            #region while loop with Dictionary         
     /*       int i = 1;
            while (r.Read())
            {
                            string string7="";
                            Dictionary<string, int> d = new Dictionary<string, int>()
                            {
                                {r["STARTTIME"].ToString(),i}
                            };  
                             foreach (var pair in d)
                             {
                                string7 = pair.Key;                                
                             }
                             STARTTIME_Get.Text = string7;
                             i = i + 1;                   
             }         */    
            #endregion           
           
            r.Close();
            conn.Close();

        }
        #endregion

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUserRoleForm frm = new AddUserRoleForm();
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser frm = new EditUser();
            frm.Show();
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query frm = new Query();
            frm.Show();
        }

        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClassFrm frm = new AddClassFrm();
            frm.Show();
        }

        private void getClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassQuery frm = new frmClassQuery();
            frm.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddBatch batch = new frmAddBatch();
            batch.Show();
        }

        private void getToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BatchQuery frm = new BatchQuery();
            frm.Show();

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubject frm = new AddSubject();
            frm.Show();

        }
    }
}
