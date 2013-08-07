namespace CoachingManagementSystem
{
    partial class AddSubject
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
            this.components = new System.ComponentModel.Container();
            this.txtAddSubjectName = new System.Windows.Forms.TextBox();
            this.txtAddSubjectDescription = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachingManagementSystem1DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachingManagementSystem1DataSet2 = new CoachingManagementSystem.CoachingManagementSystem1DataSet2();
            this.classTableAdapter = new CoachingManagementSystem.CoachingManagementSystem1DataSet2TableAdapters.ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddSubjectName
            // 
            this.txtAddSubjectName.Location = new System.Drawing.Point(80, 51);
            this.txtAddSubjectName.Name = "txtAddSubjectName";
            this.txtAddSubjectName.Size = new System.Drawing.Size(235, 20);
            this.txtAddSubjectName.TabIndex = 0;
            // 
            // txtAddSubjectDescription
            // 
            this.txtAddSubjectDescription.Location = new System.Drawing.Point(763, 47);
            this.txtAddSubjectDescription.Name = "txtAddSubjectDescription";
            this.txtAddSubjectDescription.Size = new System.Drawing.Size(216, 20);
            this.txtAddSubjectDescription.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(367, 125);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SubjectName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject Description";
            // 
            // txtClassID
            // 
            this.txtClassID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "ClassName", true));
            this.txtClassID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coachingManagementSystem1DataSet2, "Class.Class_Id", true));
            this.txtClassID.DataSource = this.bindingSource1;
            this.txtClassID.DisplayMember = "ClassName";
            this.txtClassID.FormattingEnabled = true;
            this.txtClassID.Location = new System.Drawing.Point(392, 48);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(240, 21);
            this.txtClassID.TabIndex = 7;
            this.txtClassID.ValueMember = "Class_Id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.classBindingSource;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.coachingManagementSystem1DataSet2BindingSource;
            // 
            // coachingManagementSystem1DataSet2BindingSource
            // 
            this.coachingManagementSystem1DataSet2BindingSource.DataSource = this.coachingManagementSystem1DataSet2;
            this.coachingManagementSystem1DataSet2BindingSource.Position = 0;
            // 
            // coachingManagementSystem1DataSet2
            // 
            this.coachingManagementSystem1DataSet2.DataSetName = "CoachingManagementSystem1DataSet2";
            this.coachingManagementSystem1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 605);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtAddSubjectDescription);
            this.Controls.Add(this.txtAddSubjectName);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingManagementSystem1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddSubjectName;
        private System.Windows.Forms.TextBox txtAddSubjectDescription;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtClassID;
        private CoachingManagementSystem1DataSet2 coachingManagementSystem1DataSet2;
        private System.Windows.Forms.BindingSource coachingManagementSystem1DataSet2BindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private CoachingManagementSystem1DataSet2TableAdapters.ClassTableAdapter classTableAdapter;
    }
}