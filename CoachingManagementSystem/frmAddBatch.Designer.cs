namespace CoachingManagementSystem
{
    partial class frmAddBatch
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
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(214, 45);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(100, 20);
            this.txtBatchName.TabIndex = 0;
            // 
            // txtBatchDescription
            // 
            this.txtBatchDescription.Location = new System.Drawing.Point(525, 45);
            this.txtBatchDescription.Name = "txtBatchDescription";
            this.txtBatchDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBatchDescription.TabIndex = 1;
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.Location = new System.Drawing.Point(386, 145);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(75, 23);
            this.btnAddBatch.TabIndex = 2;
            this.btnAddBatch.Text = "Add Batch";
            this.btnAddBatch.UseVisualStyleBackColor = true;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Batch Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch Description";
            // 
            // frmAddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBatch);
            this.Controls.Add(this.txtBatchDescription);
            this.Controls.Add(this.txtBatchName);
            this.Name = "frmAddBatch";
            this.Text = "frmAddBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.TextBox txtBatchDescription;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}