namespace BusinessManagementSystem {
    partial class FrmCreateUpdateEmployee {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboAdministrator = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtYearsOfEmployeeExperience = new System.Windows.Forms.TextBox();
            this.lblYearsOfEmployeeExperience = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(72, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 73);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(133, 22);
            this.txtId.TabIndex = 1;
            // 
            // cboAdministrator
            // 
            this.cboAdministrator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdministrator.FormattingEnabled = true;
            this.cboAdministrator.Location = new System.Drawing.Point(328, 30);
            this.cboAdministrator.Name = "cboAdministrator";
            this.cboAdministrator.Size = new System.Drawing.Size(157, 24);
            this.cboAdministrator.TabIndex = 2;
            this.cboAdministrator.SelectedIndexChanged += new System.EventHandler(this.cboAdministrator_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(61, 104);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Ime";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 135);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Prezime";
            // 
            // txtYearsOfEmployeeExperience
            // 
            this.txtYearsOfEmployeeExperience.Location = new System.Drawing.Point(96, 157);
            this.txtYearsOfEmployeeExperience.Name = "txtYearsOfEmployeeExperience";
            this.txtYearsOfEmployeeExperience.Size = new System.Drawing.Size(133, 22);
            this.txtYearsOfEmployeeExperience.TabIndex = 8;
            // 
            // lblYearsOfEmployeeExperience
            // 
            this.lblYearsOfEmployeeExperience.AutoSize = true;
            this.lblYearsOfEmployeeExperience.Location = new System.Drawing.Point(4, 160);
            this.lblYearsOfEmployeeExperience.Name = "lblYearsOfEmployeeExperience";
            this.lblYearsOfEmployeeExperience.Size = new System.Drawing.Size(86, 16);
            this.lblYearsOfEmployeeExperience.TabIndex = 7;
            this.lblYearsOfEmployeeExperience.Text = "Godine staža";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(96, 185);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(133, 22);
            this.txtPin.TabIndex = 10;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(61, 188);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(29, 16);
            this.lblPin.TabIndex = 9;
            this.lblPin.Text = "OIB";
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Location = new System.Drawing.Point(352, 70);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(133, 22);
            this.txtBankAccountNumber.TabIndex = 12;
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.AutoSize = true;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(308, 73);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(38, 16);
            this.lblBankAccountNumber.TabIndex = 11;
            this.lblBankAccountNumber.Text = "IBAN";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(352, 98);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(133, 22);
            this.txtContact.TabIndex = 14;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(295, 101);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(51, 16);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Kontakt";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(352, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(133, 22);
            this.txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(295, 129);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 16);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Adresa";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(352, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 22);
            this.txtUsername.TabIndex = 18;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(252, 157);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 16);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(352, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 22);
            this.txtPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(293, 185);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 16);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Lozinka";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(325, 11);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(118, 16);
            this.lblAdministrator.TabIndex = 21;
            this.lblAdministrator.Text = "Nadređena osoba";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancel.Location = new System.Drawing.Point(390, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.Location = new System.Drawing.Point(289, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmCreateUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 298);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtBankAccountNumber);
            this.Controls.Add(this.lblBankAccountNumber);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtYearsOfEmployeeExperience);
            this.Controls.Add(this.lblYearsOfEmployeeExperience);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cboAdministrator);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCreateUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos/ažuriranje zaposlenika";
            this.Load += new System.EventHandler(this.FrmCreateUpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboAdministrator;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtYearsOfEmployeeExperience;
        private System.Windows.Forms.Label lblYearsOfEmployeeExperience;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}