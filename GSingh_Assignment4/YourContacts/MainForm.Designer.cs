namespace YourContacts
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddressType = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.grbEmail = new System.Windows.Forms.GroupBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.txtEmailType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grbTakeANote = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtTakeANote = new System.Windows.Forms.TextBox();
            this.grbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.grbAddress.SuspendLayout();
            this.grbEmail.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbTakeANote.SuspendLayout();
            this.grbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 16;
            this.lstContacts.Location = new System.Drawing.Point(13, 13);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(216, 468);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 487);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(216, 23);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(406, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(406, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(493, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(162, 22);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLastName.Location = new System.Drawing.Point(492, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(163, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // btnEditContact
            // 
            this.btnEditContact.Location = new System.Drawing.Point(550, 133);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(105, 23);
            this.btnEditContact.TabIndex = 7;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.txtZip);
            this.grbAddress.Controls.Add(this.lblZip);
            this.grbAddress.Controls.Add(this.txtProvince);
            this.grbAddress.Controls.Add(this.lblProvince);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Controls.Add(this.txtAddressType);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.lblType);
            this.grbAddress.Location = new System.Drawing.Point(236, 176);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(419, 137);
            this.grbAddress.TabIndex = 8;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtZip.Location = new System.Drawing.Point(340, 88);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(62, 22);
            this.txtZip.TabIndex = 16;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(311, 91);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(32, 17);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip:";
            // 
            // txtProvince
            // 
            this.txtProvince.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtProvince.Location = new System.Drawing.Point(243, 88);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ReadOnly = true;
            this.txtProvince.Size = new System.Drawing.Size(62, 22);
            this.txtProvince.TabIndex = 14;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(170, 91);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(67, 17);
            this.lblProvince.TabIndex = 13;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCity.Location = new System.Drawing.Point(69, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(95, 22);
            this.txtCity.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtStreet.Location = new System.Drawing.Point(69, 60);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(333, 22);
            this.txtStreet.TabIndex = 10;
            // 
            // txtAddressType
            // 
            this.txtAddressType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtAddressType.Location = new System.Drawing.Point(69, 31);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.ReadOnly = true;
            this.txtAddressType.Size = new System.Drawing.Size(156, 22);
            this.txtAddressType.TabIndex = 9;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(13, 60);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 17);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 31);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // grbEmail
            // 
            this.grbEmail.Controls.Add(this.lblEmailType);
            this.grbEmail.Controls.Add(this.txtEmailType);
            this.grbEmail.Controls.Add(this.txtEmail);
            this.grbEmail.Location = new System.Drawing.Point(236, 320);
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.Size = new System.Drawing.Size(419, 93);
            this.grbEmail.TabIndex = 9;
            this.grbEmail.TabStop = false;
            this.grbEmail.Text = "Email";
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.Location = new System.Drawing.Point(240, 44);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(44, 17);
            this.lblEmailType.TabIndex = 17;
            this.lblEmailType.Text = "Type:";
            // 
            // txtEmailType
            // 
            this.txtEmailType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEmailType.Location = new System.Drawing.Point(290, 41);
            this.txtEmailType.Name = "txtEmailType";
            this.txtEmailType.ReadOnly = true;
            this.txtEmailType.Size = new System.Drawing.Size(112, 22);
            this.txtEmailType.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEmail.Location = new System.Drawing.Point(16, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(209, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.lblPhoneType);
            this.grbPhone.Controls.Add(this.txtPhoneType);
            this.grbPhone.Controls.Add(this.txtPhone);
            this.grbPhone.Location = new System.Drawing.Point(236, 428);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(419, 93);
            this.grbPhone.TabIndex = 18;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Phone";
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(240, 44);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(44, 17);
            this.lblPhoneType.TabIndex = 17;
            this.lblPhoneType.Text = "Type:";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPhoneType.Location = new System.Drawing.Point(290, 41);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(112, 22);
            this.txtPhoneType.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPhone.Location = new System.Drawing.Point(16, 41);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(209, 22);
            this.txtPhone.TabIndex = 13;
            // 
            // grbTakeANote
            // 
            this.grbTakeANote.Controls.Add(this.btnAddNote);
            this.grbTakeANote.Controls.Add(this.txtTakeANote);
            this.grbTakeANote.Location = new System.Drawing.Point(673, 13);
            this.grbTakeANote.Name = "grbTakeANote";
            this.grbTakeANote.Size = new System.Drawing.Size(464, 157);
            this.grbTakeANote.TabIndex = 19;
            this.grbTakeANote.TabStop = false;
            this.grbTakeANote.Text = "Take A Note:";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(337, 121);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(107, 23);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtTakeANote
            // 
            this.txtTakeANote.BackColor = System.Drawing.Color.White;
            this.txtTakeANote.Location = new System.Drawing.Point(15, 36);
            this.txtTakeANote.Multiline = true;
            this.txtTakeANote.Name = "txtTakeANote";
            this.txtTakeANote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakeANote.Size = new System.Drawing.Size(429, 79);
            this.txtTakeANote.TabIndex = 0;
            // 
            // grbNotes
            // 
            this.grbNotes.Controls.Add(this.txtNotes);
            this.grbNotes.Location = new System.Drawing.Point(673, 177);
            this.grbNotes.Name = "grbNotes";
            this.grbNotes.Size = new System.Drawing.Size(464, 344);
            this.grbNotes.TabIndex = 20;
            this.grbNotes.TabStop = false;
            this.grbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNotes.Location = new System.Drawing.Point(15, 30);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(429, 303);
            this.txtNotes.TabIndex = 1;
            // 
            // picContact
            // 
            this.picContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picContact.ErrorImage = null;
            this.picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
            this.picContact.InitialImage = ((System.Drawing.Image)(resources.GetObject("picContact.InitialImage")));
            this.picContact.Location = new System.Drawing.Point(236, 13);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(164, 157);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 2;
            this.picContact.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 536);
            this.Controls.Add(this.picContact);
            this.Controls.Add(this.grbNotes);
            this.Controls.Add(this.grbTakeANote);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbEmail);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lstContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbEmail.ResumeLayout(false);
            this.grbEmail.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.grbPhone.PerformLayout();
            this.grbTakeANote.ResumeLayout(false);
            this.grbTakeANote.PerformLayout();
            this.grbNotes.ResumeLayout(false);
            this.grbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddressType;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.GroupBox grbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmailType;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.GroupBox grbPhone;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grbTakeANote;
        private System.Windows.Forms.TextBox txtTakeANote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.GroupBox grbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox picContact;
    }
}

