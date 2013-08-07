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
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coachingManagementSystem1DataSet2.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.coachingManagementSystem1DataSet2.Class);

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            // Create Object
            Subject newObj = new Subject();
            newObj.SubjectName1 = txtAddSubjectName.Text;
            newObj.Class_ID1 = int.Parse(txtClassID.SelectedValue.ToString());
            newObj.SubjectDescription1 = txtAddSubjectDescription.Text;
            // Assign read form's fields to object's fields
            // Call Save
            newObj.save();
            // http://tech.pro/tutorial/776/csharp-tutorial-binding-a-datagridview-to-a-collection
            this.Close();
        }


    }
}
