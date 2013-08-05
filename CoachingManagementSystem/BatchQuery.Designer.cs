namespace CoachingManagementSystem
{
    partial class BatchQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchDescription = new System.Windows.Forms.TextBox();
            this.btnGetBatch = new System.Windows.Forms.Button();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.lblBatchID = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblBatchDescription = new System.Windows.Forms.Label();
            this.batchGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.batchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(378, 73);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(149, 20);
            this.txtBatchName.TabIndex = 0;
            // 
            // txtBatchDescription
            // 
            this.txtBatchDescription.Location = new System.Drawing.Point(679, 70);
            this.txtBatchDescription.Name = "txtBatchDescription";
            this.txtBatchDescription.Size = new System.Drawing.Size(181, 20);
            this.txtBatchDescription.TabIndex = 1;
            // 
            // btnGetBatch
            // 
            this.btnGetBatch.Location = new System.Drawing.Point(358, 152);
            this.btnGetBatch.Name = "btnGetBatch";
            this.btnGetBatch.Size = new System.Drawing.Size(75, 23);
            this.btnGetBatch.TabIndex = 2;
            this.btnGetBatch.Text = "Get Batch";
            this.btnGetBatch.UseVisualStyleBackColor = true;
            this.btnGetBatch.Click += new System.EventHandler(this.btnGetBatch_Click);
            // 
            // txtBatchID
            // 
            this.txtBatchID.Location = new System.Drawing.Point(191, 73);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(100, 20);
            this.txtBatchID.TabIndex = 3;
            // 
            // lblBatchID
            // 
            this.lblBatchID.AutoSize = true;
            this.lblBatchID.Location = new System.Drawing.Point(86, 73);
            this.lblBatchID.Name = "lblBatchID";
            this.lblBatchID.Size = new System.Drawing.Size(49, 13);
            this.lblBatchID.TabIndex = 4;
            this.lblBatchID.Text = "Batch ID";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.Location = new System.Drawing.Point(324, 73);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(66, 13);
            this.lblBatchName.TabIndex = 5;
            this.lblBatchName.Text = "Batch Name";
            // 
            // lblBatchDescription
            // 
            this.lblBatchDescription.AutoSize = true;
            this.lblBatchDescription.Location = new System.Drawing.Point(547, 76);
            this.lblBatchDescription.Name = "lblBatchDescription";
            this.lblBatchDescription.Size = new System.Drawing.Size(91, 13);
            this.lblBatchDescription.TabIndex = 6;
            this.lblBatchDescription.Text = "Batch Description";
            // 
            // batchGridView
            // 
            this.batchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchGridView.Location = new System.Drawing.Point(89, 206);
            this.batchGridView.Name = "batchGridView";
            this.batchGridView.Size = new System.Drawing.Size(779, 260);
            this.batchGridView.TabIndex = 7;
            // 
            // BatchQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 478);
            this.Controls.Add(this.batchGridView);
            this.Controls.Add(this.lblBatchDescription);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblBatchID);
            this.Controls.Add(this.txtBatchID);
            this.Controls.Add(this.btnGetBatch);
            this.Controls.Add(this.txtBatchDescription);
            this.Controls.Add(this.txtBatchName);
            this.Name = "BatchQuery";
            this.Text = "BatchQuery";
            ((System.ComponentModel.ISupportInitialize)(this.batchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.TextBox txtBatchDescription;
        private System.Windows.Forms.Button btnGetBatch;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.Label lblBatchID;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.Label lblBatchDescription;
        private System.Windows.Forms.DataGridView batchGridView;
    }
}