using System.Collections;
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
    public partial class BatchQuery : Form
    {
        public BatchQuery()
        {
            InitializeComponent();
        }

        private void btnGetBatch_Click(object sender, EventArgs e)
        {
            Batch queryobject = new Batch();
            if (!String.IsNullOrEmpty(txtBatchID.Text))
            {
                queryobject.Batch_Id = int.Parse(txtBatchID.Text);
            }
            queryobject.Batchname = txtBatchName.Text;
            queryobject.Batchdescription = txtBatchDescription.Text;

            List<object> dataRet = queryobject.get();
            List<Batch> data = new List<Batch>();
            foreach (object o in dataRet)
            {
                data.Add(o as Batch);
            }

            var _bind = data.Select(a => new
            {
                Batch_id = a.Batch_Id,
                BatchName = a.Batchname,
                Batchdescription = a.Batchdescription,


            }).ToList();

            batchGridView.DataSource = _bind;

            utility.AddDeleteAndEditButton(batchGridView);

            // Link for getting buttons working as part of grid.
            // http://stackoverflow.com/questions/10769316/add-a-button-in-a-new-column-to-all-rows-in-a-datagrid

            batchGridView.Update();
        }
    }
}
