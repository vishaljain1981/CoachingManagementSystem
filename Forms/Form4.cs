using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CoachingManagementSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coachingManagementSystem1DataSet1.UserRole' table. You can move, or remove it, as needed.
           // this.userRoleTableAdapter1.Fill(this.coachingManagementSystem1DataSet1.UserRole);
            // TODO: This line of code loads data into the 'coachingManagementSystem1DataSet.UserRole' table. You can move, or remove it, as needed.
            this.userRoleTableAdapter.Fill(this.coachingManagementSystem1DataSet.UserRole);
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userRoleTableAdapter.FillBy(this.coachingManagementSystem1DataSet.UserRole);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Object
            user newuser = new user();

            // Assign read form's fields to object's fields
            newuser.Address = Address_TextBox.Text;
            newuser.User_name = User_Name_TextBox.Text;
            newuser.Email_id = Email_TextBox.Text;
            newuser.Passwrod = Password_textBox1.Text;
            newuser.Phone = Phone_TextBox.Text;
            newuser.User_role_id = int.Parse(UserRole.SelectedValue.ToString());            
            // Call Save
            newuser.save();            
            // http://tech.pro/tutorial/776/csharp-tutorial-binding-a-datagridview-to-a-collection
            this.Close();
        }
    }
}
