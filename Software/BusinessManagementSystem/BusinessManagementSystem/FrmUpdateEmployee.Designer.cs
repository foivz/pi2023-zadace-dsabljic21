namespace BusinessManagementSystem {
    partial class FrmUpdateEmployee {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cboAdministrator = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblYearsOfEmployeeExperience = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtYearsOfEmployeeExperience = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(84, 128);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Ime";
            // 
            // cboAdministrator
            // 
            this.cboAdministrator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdministrator.FormattingEnabled = true;
            this.cboAdministrator.Location = new System.Drawing.Point(311, 49);
            this.cboAdministrator.Name = "cboAdministrator";
            this.cboAdministrator.Size = new System.Drawing.Size(180, 24);
            this.cboAdministrator.TabIndex = 2;
            this.cboAdministrator.SelectedIndexChanged += new System.EventHandler(this.cboAdministrator_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 125);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(95, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(57, 156);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Prezime";
            // 
            // lblYearsOfEmployeeExperience
            // 
            this.lblYearsOfEmployeeExperience.AutoSize = true;
            this.lblYearsOfEmployeeExperience.Location = new System.Drawing.Point(27, 184);
            this.lblYearsOfEmployeeExperience.Name = "lblYearsOfEmployeeExperience";
            this.lblYearsOfEmployeeExperience.Size = new System.Drawing.Size(86, 16);
            this.lblYearsOfEmployeeExperience.TabIndex = 8;
            this.lblYearsOfEmployeeExperience.Text = "Godine staža";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(187, 52);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(118, 16);
            this.lblAdministrator.TabIndex = 9;
            this.lblAdministrator.Text = "Nadređena osoba";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(300, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 16);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Lozinka";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(259, 184);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 16);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(302, 156);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 16);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Adresa";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(302, 128);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(51, 16);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Kontakt";
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.AutoSize = true;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(315, 100);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(38, 16);
            this.lblBankAccountNumber.TabIndex = 14;
            this.lblBankAccountNumber.Text = "IBAN";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(84, 210);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(29, 16);
            this.lblPin.TabIndex = 15;
            this.lblPin.Text = "OIB";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(119, 209);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(132, 22);
            this.txtPin.TabIndex = 21;
            // 
            // txtYearsOfEmployeeExperience
            // 
            this.txtYearsOfEmployeeExperience.Location = new System.Drawing.Point(119, 181);
            this.txtYearsOfEmployeeExperience.Name = "txtYearsOfEmployeeExperience";
            this.txtYearsOfEmployeeExperience.Size = new System.Drawing.Size(132, 22);
            this.txtYearsOfEmployeeExperience.TabIndex = 22;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 153);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 97);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 24;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(359, 125);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(132, 22);
            this.txtContact.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(359, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 22);
            this.txtAddress.TabIndex = 28;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(359, 181);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 27;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(359, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 26;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Location = new System.Drawing.Point(359, 97);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(132, 22);
            this.txtBankAccountNumber.TabIndex = 25;
            // 
            // FrmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 345);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBankAccountNumber);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtYearsOfEmployeeExperience);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblBankAccountNumber);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.lblYearsOfEmployeeExperience);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cboAdministrator);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje/Izmjena zaposlenika";
            this.Load += new System.EventHandler(this.FrmUpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cboAdministrator;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblYearsOfEmployeeExperience;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtYearsOfEmployeeExperience;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
    }
}