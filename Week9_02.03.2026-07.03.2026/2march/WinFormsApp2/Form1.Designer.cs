namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EmpID_label = new Label();
            EmpName_label = new Label();
            Designation_Label = new Label();
            DOJ_Label = new Label();
            Salary_Label = new Label();
            DeptNo_Label = new Label();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtEmpDesig = new TextBox();
            txtEmpDOJ = new TextBox();
            txtEmpSal = new TextBox();
            txtDeptNo = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnUpdateDB = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EmpID_label
            // 
            EmpID_label.AutoSize = true;
            EmpID_label.Location = new Point(46, 21);
            EmpID_label.Name = "EmpID_label";
            EmpID_label.Size = new Size(111, 25);
            EmpID_label.TabIndex = 0;
            EmpID_label.Text = "Enter EmpID";
            // 
            // EmpName_label
            // 
            EmpName_label.AutoSize = true;
            EmpName_label.Location = new Point(46, 65);
            EmpName_label.Name = "EmpName_label";
            EmpName_label.Size = new Size(140, 25);
            EmpName_label.TabIndex = 1;
            EmpName_label.Text = "Enter EmpName";
            // 
            // Designation_Label
            // 
            Designation_Label.AutoSize = true;
            Designation_Label.Location = new Point(46, 113);
            Designation_Label.Name = "Designation_Label";
            Designation_Label.Size = new Size(152, 25);
            Designation_Label.TabIndex = 2;
            Designation_Label.Text = "Enter Designation";
            // 
            // DOJ_Label
            // 
            DOJ_Label.AutoSize = true;
            DOJ_Label.Location = new Point(46, 156);
            DOJ_Label.Name = "DOJ_Label";
            DOJ_Label.Size = new Size(90, 25);
            DOJ_Label.TabIndex = 3;
            DOJ_Label.Text = "Enter DOJ";
            // 
            // Salary_Label
            // 
            Salary_Label.AutoSize = true;
            Salary_Label.Location = new Point(46, 195);
            Salary_Label.Name = "Salary_Label";
            Salary_Label.Size = new Size(104, 25);
            Salary_Label.TabIndex = 4;
            Salary_Label.Text = "Enter Salary";
            // 
            // DeptNo_Label
            // 
            DeptNo_Label.AutoSize = true;
            DeptNo_Label.Location = new Point(46, 232);
            DeptNo_Label.Name = "DeptNo_Label";
            DeptNo_Label.Size = new Size(120, 25);
            DeptNo_Label.TabIndex = 5;
            DeptNo_Label.Text = "Enter DeptNo";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(218, 18);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(150, 31);
            txtEmpId.TabIndex = 6;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(218, 65);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(150, 31);
            txtEmpName.TabIndex = 7;
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.Location = new Point(218, 113);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(150, 31);
            txtEmpDesig.TabIndex = 8;
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.Location = new Point(218, 150);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(150, 31);
            txtEmpDOJ.TabIndex = 9;
            // 
            // txtEmpSal
            // 
            txtEmpSal.Location = new Point(218, 189);
            txtEmpSal.Name = "txtEmpSal";
            txtEmpSal.Size = new Size(150, 31);
            txtEmpSal.TabIndex = 10;
            // 
            // txtDeptNo
            // 
            txtDeptNo.Location = new Point(218, 229);
            txtDeptNo.Name = "txtDeptNo";
            txtDeptNo.Size = new Size(150, 31);
            txtDeptNo.TabIndex = 11;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(66, 290);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(66, 388);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(228, 290);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(112, 34);
            btnFind.TabIndex = 14;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(228, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(404, 290);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(404, 388);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(549, 345);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(211, 34);
            btnUpdateDB.TabIndex = 18;
            btnUpdateDB.Text = "Update Into Database";
            btnUpdateDB.UseVisualStyleBackColor = true;
            btnUpdateDB.Click += btnUpdateDB_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(568, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(543, 289);
            dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 604);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtDeptNo);
            Controls.Add(txtEmpSal);
            Controls.Add(txtEmpDOJ);
            Controls.Add(txtEmpDesig);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(DeptNo_Label);
            Controls.Add(Salary_Label);
            Controls.Add(DOJ_Label);
            Controls.Add(Designation_Label);
            Controls.Add(EmpName_label);
            Controls.Add(EmpID_label);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmpID_label;
        private Label EmpName_label;
        private Label Designation_Label;
        private Label DOJ_Label;
        private Label Salary_Label;
        private Label DeptNo_Label;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtEmpDesig;
        private TextBox txtEmpDOJ;
        private TextBox txtEmpSal;
        private TextBox txtDeptNo;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnFind;
        private Button btnDelete;
        private Button btnClear;
        private Button btnClose;
        private Button btnUpdateDB;
        private DataGridView dataGridView1;
    }
}
