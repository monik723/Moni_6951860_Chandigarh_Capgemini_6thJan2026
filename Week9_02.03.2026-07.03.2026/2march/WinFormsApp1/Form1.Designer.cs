using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblID = new Label();
            this.lblName = new Label();
            this.lblEmail = new Label();
            this.lblSalary = new Label();
            this.txtID = new TextBox();
            this.txtName = new TextBox();
            this.txtSalary = new TextBox();
            this.txtEmail = new TextBox();
            this.cmbDepartment = new ComboBox();
            this.lbldepartment = new Label();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnLoad = new Button();
            this.btnSearch = new Button();
            this.lblSearch = new Label();
            this.txtsearch = new TextBox();
            this.dataGridView1 = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // Form settings
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Text = "Employee Management System";

            // Add controls to form
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private Label lblID;
        private Label lblName;
        private Label lblEmail;
        private Label lblSalary;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSalary;
        private TextBox txtEmail;
        private ComboBox cmbDepartment;
        private Label lbldepartment;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnSearch;
        private Label lblSearch;
        private TextBox txtsearch;
        private DataGridView dataGridView1;
    }
}