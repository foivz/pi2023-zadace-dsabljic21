namespace BusinessManagementSystem {
    partial class FrmEmployees {
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.txtFilterUsername = new System.Windows.Forms.TextBox();
            this.lblFilterUsername = new System.Windows.Forms.Label();
            this.btnFilterUsername = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 42);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(889, 403);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateEmployee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreateEmployee.Location = new System.Drawing.Point(675, 451);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(110, 49);
            this.btnCreateEmployee.TabIndex = 1;
            this.btnCreateEmployee.Text = "Unesi zaposlenika";
            this.btnCreateEmployee.UseVisualStyleBackColor = false;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(559, 451);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(110, 49);
            this.btnUpdateEmployee.TabIndex = 2;
            this.btnUpdateEmployee.Text = "Ažuriraj zaposlenika";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(791, 451);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(110, 49);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Izbriši zaposlenika";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // txtFilterUsername
            // 
            this.txtFilterUsername.Location = new System.Drawing.Point(537, 10);
            this.txtFilterUsername.Name = "txtFilterUsername";
            this.txtFilterUsername.Size = new System.Drawing.Size(155, 22);
            this.txtFilterUsername.TabIndex = 4;
            // 
            // lblFilterUsername
            // 
            this.lblFilterUsername.AutoSize = true;
            this.lblFilterUsername.Location = new System.Drawing.Point(437, 13);
            this.lblFilterUsername.Name = "lblFilterUsername";
            this.lblFilterUsername.Size = new System.Drawing.Size(94, 16);
            this.lblFilterUsername.TabIndex = 5;
            this.lblFilterUsername.Text = "Korisničko ime";
            this.lblFilterUsername.Click += new System.EventHandler(this.lblFilterUsername_Click);
            // 
            // btnFilterUsername
            // 
            this.btnFilterUsername.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFilterUsername.Location = new System.Drawing.Point(698, 5);
            this.btnFilterUsername.Name = "btnFilterUsername";
            this.btnFilterUsername.Size = new System.Drawing.Size(88, 32);
            this.btnFilterUsername.TabIndex = 6;
            this.btnFilterUsername.Text = "Traži";
            this.btnFilterUsername.UseVisualStyleBackColor = false;
            this.btnFilterUsername.Click += new System.EventHandler(this.btnFilterUsername_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRemoveFilter.Location = new System.Drawing.Point(791, 7);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(110, 29);
            this.btnRemoveFilter.TabIndex = 7;
            this.btnRemoveFilter.Text = "Ukloni filter";
            this.btnRemoveFilter.UseVisualStyleBackColor = false;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(913, 508);
            this.Controls.Add(this.btnRemoveFilter);
            this.Controls.Add(this.btnFilterUsername);
            this.Controls.Add(this.lblFilterUsername);
            this.Controls.Add(this.txtFilterUsername);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "FrmEmployees";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox txtFilterUsername;
        private System.Windows.Forms.Label lblFilterUsername;
        private System.Windows.Forms.Button btnFilterUsername;
        private System.Windows.Forms.Button btnRemoveFilter;
    }
}