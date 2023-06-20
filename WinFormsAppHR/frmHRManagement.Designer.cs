namespace WinFormsAppHR
{
    partial class frmHRManagement
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
            label1 = new Label();
            txtEmployeeId = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            dtDob = new DateTimePicker();
            label4 = new Label();
            cboDepartment = new ComboBox();
            label5 = new Label();
            txtWorkingDay = new TextBox();
            label6 = new Label();
            mskRateSalary = new MaskedTextBox();
            dgvEmployees = new DataGridView();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 56);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 0;
            label1.Text = "Employee Id";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeId.Location = new Point(272, 53);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(351, 42);
            txtEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 141);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(272, 141);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(351, 42);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(741, 58);
            label3.Name = "label3";
            label3.Size = new Size(170, 37);
            label3.TabIndex = 4;
            label3.Text = "Date Of Birth";
            // 
            // dtDob
            // 
            dtDob.Location = new Point(947, 64);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(350, 37);
            dtDob.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(741, 146);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 6;
            label4.Text = "Departement";
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(953, 153);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(344, 38);
            cboDepartment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 238);
            label5.Name = "label5";
            label5.Size = new Size(170, 37);
            label5.TabIndex = 8;
            label5.Text = "Working Day";
            // 
            // txtWorkingDay
            // 
            txtWorkingDay.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkingDay.Location = new Point(272, 238);
            txtWorkingDay.Name = "txtWorkingDay";
            txtWorkingDay.Size = new Size(351, 42);
            txtWorkingDay.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(741, 241);
            label6.Name = "label6";
            label6.Size = new Size(148, 37);
            label6.TabIndex = 10;
            label6.Text = "Rate Salary";
            // 
            // mskRateSalary
            // 
            mskRateSalary.Location = new Point(953, 243);
            mskRateSalary.Name = "mskRateSalary";
            mskRateSalary.Size = new Size(344, 37);
            mskRateSalary.TabIndex = 11;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(66, 330);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 72;
            dgvEmployees.RowTemplate.Height = 39;
            dgvEmployees.Size = new Size(1234, 459);
            dgvEmployees.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(78, 823);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1222, 135);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(857, 49);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 61);
            btnExit.TabIndex = 3;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(420, 49);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 61);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(629, 49);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 61);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(182, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 61);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmHRManagement
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 997);
            Controls.Add(groupBox1);
            Controls.Add(dgvEmployees);
            Controls.Add(mskRateSalary);
            Controls.Add(label6);
            Controls.Add(txtWorkingDay);
            Controls.Add(label5);
            Controls.Add(cboDepartment);
            Controls.Add(label4);
            Controls.Add(dtDob);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtEmployeeId);
            Controls.Add(label1);
            Name = "frmHRManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Human Resoure Management";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeId;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private DateTimePicker dtDob;
        private Label label4;
        private ComboBox cboDepartment;
        private Label label5;
        private TextBox txtWorkingDay;
        private Label label6;
        private MaskedTextBox mskRateSalary;
        private DataGridView dgvEmployees;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnDelete;
    }
}