using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoachingManagementSystem
{
    public partial class AddClassFrm : Form
    {
        public AddClassFrm()
        {
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            // Create Object
            Class newObj = new Class();
            newObj.ClassDescription = txtClassDescription.Text;
            newObj.ClassName = txtClassName.Text;
            // Assign read form's fields to object's fields

            // Call Save
            newObj.save();

            // http://tech.pro/tutorial/776/csharp-tutorial-binding-a-datagridview-to-a-collection

            this.Close();
        }
    }
}
