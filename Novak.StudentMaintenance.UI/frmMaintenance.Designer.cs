namespace Novak.StudentMaintenance.UI
{
    partial class frmMaintenance
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
            this.btnMakePerson = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.btnMakeStudent = new System.Windows.Forms.Button();
            this.cboAddressTypes = new System.Windows.Forms.ComboBox();
            this.btnMakeAddressTypes = new System.Windows.Forms.Button();
            this.btnSaveAddressTypes = new System.Windows.Forms.Button();
            this.btnLoadAddressTypes = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvAddressTypes = new System.Windows.Forms.DataGridView();
            this.btnLoadAddressTypesXML = new System.Windows.Forms.Button();
            this.btnSaveAddressTypesXML = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakePerson
            // 
            this.btnMakePerson.Location = new System.Drawing.Point(12, 64);
            this.btnMakePerson.Name = "btnMakePerson";
            this.btnMakePerson.Size = new System.Drawing.Size(100, 23);
            this.btnMakePerson.TabIndex = 0;
            this.btnMakePerson.Text = "Make Person";
            this.btnMakePerson.UseVisualStyleBackColor = true;
            this.btnMakePerson.Click += new System.EventHandler(this.btnMakePerson_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(12, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(12, 38);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(12, 100);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(0, 13);
            this.lblFullname.TabIndex = 3;
            // 
            // btnMakeStudent
            // 
            this.btnMakeStudent.Location = new System.Drawing.Point(118, 64);
            this.btnMakeStudent.Name = "btnMakeStudent";
            this.btnMakeStudent.Size = new System.Drawing.Size(100, 23);
            this.btnMakeStudent.TabIndex = 4;
            this.btnMakeStudent.Text = "Make Student";
            this.btnMakeStudent.UseVisualStyleBackColor = true;
            this.btnMakeStudent.Click += new System.EventHandler(this.btnMakeStudent_Click);
            // 
            // cboAddressTypes
            // 
            this.cboAddressTypes.FormattingEnabled = true;
            this.cboAddressTypes.Location = new System.Drawing.Point(12, 126);
            this.cboAddressTypes.Name = "cboAddressTypes";
            this.cboAddressTypes.Size = new System.Drawing.Size(121, 21);
            this.cboAddressTypes.TabIndex = 5;
            // 
            // btnMakeAddressTypes
            // 
            this.btnMakeAddressTypes.Location = new System.Drawing.Point(143, 126);
            this.btnMakeAddressTypes.Name = "btnMakeAddressTypes";
            this.btnMakeAddressTypes.Size = new System.Drawing.Size(110, 23);
            this.btnMakeAddressTypes.TabIndex = 6;
            this.btnMakeAddressTypes.Text = "Make Address Types";
            this.btnMakeAddressTypes.UseVisualStyleBackColor = true;
            this.btnMakeAddressTypes.Click += new System.EventHandler(this.btnMakeAddressTypes_Click);
            // 
            // btnSaveAddressTypes
            // 
            this.btnSaveAddressTypes.Location = new System.Drawing.Point(143, 155);
            this.btnSaveAddressTypes.Name = "btnSaveAddressTypes";
            this.btnSaveAddressTypes.Size = new System.Drawing.Size(110, 23);
            this.btnSaveAddressTypes.TabIndex = 7;
            this.btnSaveAddressTypes.Text = "Save Address Types";
            this.btnSaveAddressTypes.UseVisualStyleBackColor = true;
            this.btnSaveAddressTypes.Click += new System.EventHandler(this.btnSaveAddressTypes_Click);
            // 
            // btnLoadAddressTypes
            // 
            this.btnLoadAddressTypes.Location = new System.Drawing.Point(143, 184);
            this.btnLoadAddressTypes.Name = "btnLoadAddressTypes";
            this.btnLoadAddressTypes.Size = new System.Drawing.Size(110, 23);
            this.btnLoadAddressTypes.TabIndex = 8;
            this.btnLoadAddressTypes.Text = "Load Address Types";
            this.btnLoadAddressTypes.UseVisualStyleBackColor = true;
            this.btnLoadAddressTypes.Click += new System.EventHandler(this.btnLoadAddressTypes_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvAddressTypes
            // 
            this.dgvAddressTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressTypes.Location = new System.Drawing.Point(436, 12);
            this.dgvAddressTypes.Name = "dgvAddressTypes";
            this.dgvAddressTypes.Size = new System.Drawing.Size(240, 150);
            this.dgvAddressTypes.TabIndex = 10;
            // 
            // btnLoadAddressTypesXML
            // 
            this.btnLoadAddressTypesXML.Location = new System.Drawing.Point(259, 184);
            this.btnLoadAddressTypesXML.Name = "btnLoadAddressTypesXML";
            this.btnLoadAddressTypesXML.Size = new System.Drawing.Size(110, 23);
            this.btnLoadAddressTypesXML.TabIndex = 12;
            this.btnLoadAddressTypesXML.Text = "Load Address Types";
            this.btnLoadAddressTypesXML.UseVisualStyleBackColor = true;
            this.btnLoadAddressTypesXML.Click += new System.EventHandler(this.btnLoadAddressTypesXML_Click);
            // 
            // btnSaveAddressTypesXML
            // 
            this.btnSaveAddressTypesXML.Location = new System.Drawing.Point(259, 155);
            this.btnSaveAddressTypesXML.Name = "btnSaveAddressTypesXML";
            this.btnSaveAddressTypesXML.Size = new System.Drawing.Size(110, 23);
            this.btnSaveAddressTypesXML.TabIndex = 11;
            this.btnSaveAddressTypesXML.Text = "Save Address Types";
            this.btnSaveAddressTypesXML.UseVisualStyleBackColor = true;
            this.btnSaveAddressTypesXML.Click += new System.EventHandler(this.btnSaveAddressTypesXML_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 262);
            this.Controls.Add(this.btnLoadAddressTypesXML);
            this.Controls.Add(this.btnSaveAddressTypesXML);
            this.Controls.Add(this.dgvAddressTypes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoadAddressTypes);
            this.Controls.Add(this.btnSaveAddressTypes);
            this.Controls.Add(this.btnMakeAddressTypes);
            this.Controls.Add(this.cboAddressTypes);
            this.Controls.Add(this.btnMakeStudent);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnMakePerson);
            this.Name = "frmMaintenance";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakePerson;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Button btnMakeStudent;
        private System.Windows.Forms.ComboBox cboAddressTypes;
        private System.Windows.Forms.Button btnMakeAddressTypes;
        private System.Windows.Forms.Button btnSaveAddressTypes;
        private System.Windows.Forms.Button btnLoadAddressTypes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dgvAddressTypes;
        private System.Windows.Forms.Button btnLoadAddressTypesXML;
        private System.Windows.Forms.Button btnSaveAddressTypesXML;
    }
}

