namespace REGISTERATION_FORM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ID = new Label();
            NAME = new Label();
            EMAIL = new Label();
            PHONE = new Label();
            DEPARTMENT = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDepartment = new TextBox();
            btnCreate = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewMYTABLE = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMYTABLE).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.PowderBlue;
            ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ID.ForeColor = SystemColors.ActiveCaptionText;
            ID.Location = new Point(20, 224);
            ID.Margin = new Padding(2, 0, 2, 0);
            ID.Name = "ID";
            ID.Size = new Size(75, 15);
            ID.TabIndex = 0;
            ID.Text = "Student-ID :";
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.BackColor = Color.PowderBlue;
            NAME.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NAME.ForeColor = SystemColors.ActiveCaptionText;
            NAME.Location = new Point(11, 275);
            NAME.Margin = new Padding(2, 0, 2, 0);
            NAME.Name = "NAME";
            NAME.Size = new Size(96, 15);
            NAME.TabIndex = 1;
            NAME.Text = "Student-NAME :";
            // 
            // EMAIL
            // 
            EMAIL.AutoSize = true;
            EMAIL.BackColor = Color.PowderBlue;
            EMAIL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EMAIL.ForeColor = SystemColors.ActiveCaptionText;
            EMAIL.Location = new Point(20, 330);
            EMAIL.Margin = new Padding(2, 0, 2, 0);
            EMAIL.Name = "EMAIL";
            EMAIL.Size = new Size(55, 15);
            EMAIL.TabIndex = 2;
            EMAIL.Text = "Section :";
            // 
            // PHONE
            // 
            PHONE.AutoSize = true;
            PHONE.BackColor = Color.PowderBlue;
            PHONE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PHONE.ForeColor = SystemColors.ActiveCaptionText;
            PHONE.Location = new Point(13, 390);
            PHONE.Margin = new Padding(2, 0, 2, 0);
            PHONE.Name = "PHONE";
            PHONE.Size = new Size(82, 15);
            PHONE.TabIndex = 3;
            PHONE.Text = "Department :";
            // 
            // DEPARTMENT
            // 
            DEPARTMENT.AutoSize = true;
            DEPARTMENT.BackColor = Color.PowderBlue;
            DEPARTMENT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DEPARTMENT.ForeColor = SystemColors.ActiveCaptionText;
            DEPARTMENT.Location = new Point(13, 436);
            DEPARTMENT.Margin = new Padding(2, 0, 2, 0);
            DEPARTMENT.Name = "DEPARTMENT";
            DEPARTMENT.Size = new Size(73, 15);
            DEPARTMENT.TabIndex = 4;
            DEPARTMENT.Text = "Permission :";
            // 
            // txtId
            // 
            txtId.BackColor = Color.Khaki;
            txtId.Cursor = Cursors.Hand;
            txtId.Font = new Font("Arial Narrow", 11.25F);
            txtId.ForeColor = SystemColors.InactiveCaptionText;
            txtId.Location = new Point(115, 217);
            txtId.Margin = new Padding(2, 3, 2, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 25);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Khaki;
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Arial Narrow", 11.25F);
            txtName.ForeColor = SystemColors.InactiveCaptionText;
            txtName.Location = new Point(115, 268);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(118, 25);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Khaki;
            txtEmail.Cursor = Cursors.Hand;
            txtEmail.Font = new Font("Arial Narrow", 11.25F);
            txtEmail.ForeColor = SystemColors.InactiveCaptionText;
            txtEmail.Location = new Point(115, 323);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(118, 25);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.Khaki;
            txtPhone.Cursor = Cursors.Hand;
            txtPhone.Font = new Font("Arial Narrow", 11.25F);
            txtPhone.ForeColor = SystemColors.InactiveCaptionText;
            txtPhone.Location = new Point(115, 383);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(118, 25);
            txtPhone.TabIndex = 8;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.Khaki;
            txtDepartment.Cursor = Cursors.Hand;
            txtDepartment.Font = new Font("Arial Narrow", 11.25F);
            txtDepartment.ForeColor = SystemColors.InactiveCaptionText;
            txtDepartment.Location = new Point(115, 429);
            txtDepartment.Margin = new Padding(2, 3, 2, 3);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(118, 25);
            txtDepartment.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Orange;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(75, 482);
            btnCreate.Margin = new Padding(2, 3, 2, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 40);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "SUBMIT";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Orange;
            btnRead.Cursor = Cursors.Hand;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRead.ForeColor = SystemColors.ControlLightLight;
            btnRead.Location = new Point(429, 531);
            btnRead.Margin = new Padding(2, 3, 2, 3);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(86, 40);
            btnRead.TabIndex = 11;
            btnRead.Text = "READ";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(587, 531);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orange;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(738, 531);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 40);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewMYTABLE
            // 
            dataGridViewMYTABLE.BackgroundColor = Color.Khaki;
            dataGridViewMYTABLE.BorderStyle = BorderStyle.None;
            dataGridViewMYTABLE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewMYTABLE.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMYTABLE.GridColor = Color.Khaki;
            dataGridViewMYTABLE.Location = new Point(369, 314);
            dataGridViewMYTABLE.Margin = new Padding(0);
            dataGridViewMYTABLE.Name = "dataGridViewMYTABLE";
            dataGridViewMYTABLE.Size = new Size(534, 166);
            dataGridViewMYTABLE.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(20, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 15;
            label1.Text = "PERMISSION FORM :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PowderBlue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(56, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(787, 90);
            label2.TabIndex = 16;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(940, 653);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewMYTABLE);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Controls.Add(txtDepartment);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(DEPARTMENT);
            Controls.Add(PHONE);
            Controls.Add(EMAIL);
            Controls.Add(NAME);
            Controls.Add(ID);
            DoubleBuffered = true;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "FIELD TRIP PERMISSION REGISTERATION FORM";
            TransparencyKey = Color.Yellow;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMYTABLE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label NAME;
        private Label EMAIL;
        private Label PHONE;
        private Label DEPARTMENT;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDepartment;
        private Button btnCreate;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewMYTABLE;
        private Label label1;
        private Label label2;
    }
}
