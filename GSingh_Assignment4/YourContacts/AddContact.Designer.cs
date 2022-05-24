namespace YourContacts
{
    partial class AddContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm));
            this.grbSecondaryFormPhone = new System.Windows.Forms.GroupBox();
            this.mtxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbSecondaryFormPhoneType = new System.Windows.Forms.ComboBox();
            this.lblSecondaryFormPhoneType = new System.Windows.Forms.Label();
            this.grbSecondaryFormEmail = new System.Windows.Forms.GroupBox();
            this.cmbSecondaryFormEmailType = new System.Windows.Forms.ComboBox();
            this.lblSecondaryFormEmailType = new System.Windows.Forms.Label();
            this.txtSecondaryFormEmail = new System.Windows.Forms.TextBox();
            this.grbSecondaryFormAddress = new System.Windows.Forms.GroupBox();
            this.mtxZip = new System.Windows.Forms.MaskedTextBox();
            this.cmbSecondaryFormProvince = new System.Windows.Forms.ComboBox();
            this.cmbSecondaryFormAddressType = new System.Windows.Forms.ComboBox();
            this.lblSecondaryFormZip = new System.Windows.Forms.Label();
            this.lblSecondaryFormProvince = new System.Windows.Forms.Label();
            this.txtSecondaryFormCity = new System.Windows.Forms.TextBox();
            this.lblSecondaryFormCity = new System.Windows.Forms.Label();
            this.txtSecondaryFormStreet = new System.Windows.Forms.TextBox();
            this.lblSecondaryFormStreet = new System.Windows.Forms.Label();
            this.lblSecondaryFormType = new System.Windows.Forms.Label();
            this.btnSecondaryFormAddPhoto = new System.Windows.Forms.Button();
            this.txtSecondaryFormLastName = new System.Windows.Forms.TextBox();
            this.txtSecondaryFormFirstName = new System.Windows.Forms.TextBox();
            this.lblSecondaryFormLastName = new System.Windows.Forms.Label();
            this.lblSecondaryFormFirstName = new System.Windows.Forms.Label();
            this.picSecondaryFormContact = new System.Windows.Forms.PictureBox();
            this.btnSecondaryFormSave = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grbSecondaryFormPhone.SuspendLayout();
            this.grbSecondaryFormEmail.SuspendLayout();
            this.grbSecondaryFormAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondaryFormContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSecondaryFormPhone
            // 
            this.grbSecondaryFormPhone.Controls.Add(this.mtxPhoneNumber);
            this.grbSecondaryFormPhone.Controls.Add(this.cmbSecondaryFormPhoneType);
            this.grbSecondaryFormPhone.Controls.Add(this.lblSecondaryFormPhoneType);
            this.grbSecondaryFormPhone.Location = new System.Drawing.Point(21, 427);
            this.grbSecondaryFormPhone.Name = "grbSecondaryFormPhone";
            this.grbSecondaryFormPhone.Size = new System.Drawing.Size(464, 93);
            this.grbSecondaryFormPhone.TabIndex = 27;
            this.grbSecondaryFormPhone.TabStop = false;
            this.grbSecondaryFormPhone.Text = "Phone";
            // 
            // mtxPhoneNumber
            // 
            this.mtxPhoneNumber.Location = new System.Drawing.Point(16, 42);
            this.mtxPhoneNumber.Mask = "(000) 000-0000";
            this.mtxPhoneNumber.Name = "mtxPhoneNumber";
            this.mtxPhoneNumber.Size = new System.Drawing.Size(234, 22);
            this.mtxPhoneNumber.TabIndex = 20;
            // 
            // cmbSecondaryFormPhoneType
            // 
            this.cmbSecondaryFormPhoneType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSecondaryFormPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryFormPhoneType.FormattingEnabled = true;
            this.cmbSecondaryFormPhoneType.Items.AddRange(new object[] {
            "Personal",
            "Business"});
            this.cmbSecondaryFormPhoneType.Location = new System.Drawing.Point(335, 42);
            this.cmbSecondaryFormPhoneType.Name = "cmbSecondaryFormPhoneType";
            this.cmbSecondaryFormPhoneType.Size = new System.Drawing.Size(112, 24);
            this.cmbSecondaryFormPhoneType.TabIndex = 20;
            // 
            // lblSecondaryFormPhoneType
            // 
            this.lblSecondaryFormPhoneType.AutoSize = true;
            this.lblSecondaryFormPhoneType.Location = new System.Drawing.Point(274, 45);
            this.lblSecondaryFormPhoneType.Name = "lblSecondaryFormPhoneType";
            this.lblSecondaryFormPhoneType.Size = new System.Drawing.Size(44, 17);
            this.lblSecondaryFormPhoneType.TabIndex = 17;
            this.lblSecondaryFormPhoneType.Text = "Type:";
            // 
            // grbSecondaryFormEmail
            // 
            this.grbSecondaryFormEmail.Controls.Add(this.cmbSecondaryFormEmailType);
            this.grbSecondaryFormEmail.Controls.Add(this.lblSecondaryFormEmailType);
            this.grbSecondaryFormEmail.Controls.Add(this.txtSecondaryFormEmail);
            this.grbSecondaryFormEmail.Location = new System.Drawing.Point(21, 319);
            this.grbSecondaryFormEmail.Name = "grbSecondaryFormEmail";
            this.grbSecondaryFormEmail.Size = new System.Drawing.Size(464, 93);
            this.grbSecondaryFormEmail.TabIndex = 26;
            this.grbSecondaryFormEmail.TabStop = false;
            this.grbSecondaryFormEmail.Text = "Email";
            // 
            // cmbSecondaryFormEmailType
            // 
            this.cmbSecondaryFormEmailType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSecondaryFormEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryFormEmailType.FormattingEnabled = true;
            this.cmbSecondaryFormEmailType.Items.AddRange(new object[] {
            "Personal",
            "Business"});
            this.cmbSecondaryFormEmailType.Location = new System.Drawing.Point(335, 42);
            this.cmbSecondaryFormEmailType.Name = "cmbSecondaryFormEmailType";
            this.cmbSecondaryFormEmailType.Size = new System.Drawing.Size(112, 24);
            this.cmbSecondaryFormEmailType.TabIndex = 19;
            // 
            // lblSecondaryFormEmailType
            // 
            this.lblSecondaryFormEmailType.AutoSize = true;
            this.lblSecondaryFormEmailType.Location = new System.Drawing.Point(274, 44);
            this.lblSecondaryFormEmailType.Name = "lblSecondaryFormEmailType";
            this.lblSecondaryFormEmailType.Size = new System.Drawing.Size(44, 17);
            this.lblSecondaryFormEmailType.TabIndex = 17;
            this.lblSecondaryFormEmailType.Text = "Type:";
            // 
            // txtSecondaryFormEmail
            // 
            this.txtSecondaryFormEmail.BackColor = System.Drawing.Color.White;
            this.txtSecondaryFormEmail.Location = new System.Drawing.Point(16, 42);
            this.txtSecondaryFormEmail.Name = "txtSecondaryFormEmail";
            this.txtSecondaryFormEmail.Size = new System.Drawing.Size(234, 22);
            this.txtSecondaryFormEmail.TabIndex = 13;
            // 
            // grbSecondaryFormAddress
            // 
            this.grbSecondaryFormAddress.Controls.Add(this.mtxZip);
            this.grbSecondaryFormAddress.Controls.Add(this.cmbSecondaryFormProvince);
            this.grbSecondaryFormAddress.Controls.Add(this.cmbSecondaryFormAddressType);
            this.grbSecondaryFormAddress.Controls.Add(this.lblSecondaryFormZip);
            this.grbSecondaryFormAddress.Controls.Add(this.lblSecondaryFormProvince);
            this.grbSecondaryFormAddress.Controls.Add(this.txtSecondaryFormCity);
            this.grbSecondaryFormAddress.Controls.Add(this.lblSecondaryFormCity);
            this.grbSecondaryFormAddress.Controls.Add(this.txtSecondaryFormStreet);
            this.grbSecondaryFormAddress.Controls.Add(this.lblSecondaryFormStreet);
            this.grbSecondaryFormAddress.Controls.Add(this.lblSecondaryFormType);
            this.grbSecondaryFormAddress.Location = new System.Drawing.Point(21, 175);
            this.grbSecondaryFormAddress.Name = "grbSecondaryFormAddress";
            this.grbSecondaryFormAddress.Size = new System.Drawing.Size(464, 137);
            this.grbSecondaryFormAddress.TabIndex = 25;
            this.grbSecondaryFormAddress.TabStop = false;
            this.grbSecondaryFormAddress.Text = "Address";
            // 
            // mtxZip
            // 
            this.mtxZip.Location = new System.Drawing.Point(373, 88);
            this.mtxZip.Mask = "L0L 0L0";
            this.mtxZip.Name = "mtxZip";
            this.mtxZip.Size = new System.Drawing.Size(74, 22);
            this.mtxZip.TabIndex = 19;
            // 
            // cmbSecondaryFormProvince
            // 
            this.cmbSecondaryFormProvince.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSecondaryFormProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryFormProvince.FormattingEnabled = true;
            this.cmbSecondaryFormProvince.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.cmbSecondaryFormProvince.Location = new System.Drawing.Point(243, 86);
            this.cmbSecondaryFormProvince.Name = "cmbSecondaryFormProvince";
            this.cmbSecondaryFormProvince.Size = new System.Drawing.Size(86, 24);
            this.cmbSecondaryFormProvince.TabIndex = 18;
            // 
            // cmbSecondaryFormAddressType
            // 
            this.cmbSecondaryFormAddressType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSecondaryFormAddressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryFormAddressType.FormattingEnabled = true;
            this.cmbSecondaryFormAddressType.Items.AddRange(new object[] {
            "Home",
            "Business"});
            this.cmbSecondaryFormAddressType.Location = new System.Drawing.Point(70, 31);
            this.cmbSecondaryFormAddressType.Name = "cmbSecondaryFormAddressType";
            this.cmbSecondaryFormAddressType.Size = new System.Drawing.Size(180, 24);
            this.cmbSecondaryFormAddressType.TabIndex = 17;
            // 
            // lblSecondaryFormZip
            // 
            this.lblSecondaryFormZip.AutoSize = true;
            this.lblSecondaryFormZip.Location = new System.Drawing.Point(335, 91);
            this.lblSecondaryFormZip.Name = "lblSecondaryFormZip";
            this.lblSecondaryFormZip.Size = new System.Drawing.Size(32, 17);
            this.lblSecondaryFormZip.TabIndex = 15;
            this.lblSecondaryFormZip.Text = "Zip:";
            // 
            // lblSecondaryFormProvince
            // 
            this.lblSecondaryFormProvince.AutoSize = true;
            this.lblSecondaryFormProvince.Location = new System.Drawing.Point(170, 91);
            this.lblSecondaryFormProvince.Name = "lblSecondaryFormProvince";
            this.lblSecondaryFormProvince.Size = new System.Drawing.Size(67, 17);
            this.lblSecondaryFormProvince.TabIndex = 13;
            this.lblSecondaryFormProvince.Text = "Province:";
            // 
            // txtSecondaryFormCity
            // 
            this.txtSecondaryFormCity.BackColor = System.Drawing.Color.White;
            this.txtSecondaryFormCity.Location = new System.Drawing.Point(69, 88);
            this.txtSecondaryFormCity.Name = "txtSecondaryFormCity";
            this.txtSecondaryFormCity.Size = new System.Drawing.Size(95, 22);
            this.txtSecondaryFormCity.TabIndex = 12;
            // 
            // lblSecondaryFormCity
            // 
            this.lblSecondaryFormCity.AutoSize = true;
            this.lblSecondaryFormCity.Location = new System.Drawing.Point(28, 89);
            this.lblSecondaryFormCity.Name = "lblSecondaryFormCity";
            this.lblSecondaryFormCity.Size = new System.Drawing.Size(35, 17);
            this.lblSecondaryFormCity.TabIndex = 11;
            this.lblSecondaryFormCity.Text = "City:";
            // 
            // txtSecondaryFormStreet
            // 
            this.txtSecondaryFormStreet.BackColor = System.Drawing.Color.White;
            this.txtSecondaryFormStreet.Location = new System.Drawing.Point(69, 60);
            this.txtSecondaryFormStreet.Name = "txtSecondaryFormStreet";
            this.txtSecondaryFormStreet.Size = new System.Drawing.Size(378, 22);
            this.txtSecondaryFormStreet.TabIndex = 10;
            // 
            // lblSecondaryFormStreet
            // 
            this.lblSecondaryFormStreet.AutoSize = true;
            this.lblSecondaryFormStreet.Location = new System.Drawing.Point(13, 60);
            this.lblSecondaryFormStreet.Name = "lblSecondaryFormStreet";
            this.lblSecondaryFormStreet.Size = new System.Drawing.Size(50, 17);
            this.lblSecondaryFormStreet.TabIndex = 1;
            this.lblSecondaryFormStreet.Text = "Street:";
            // 
            // lblSecondaryFormType
            // 
            this.lblSecondaryFormType.AutoSize = true;
            this.lblSecondaryFormType.Location = new System.Drawing.Point(19, 31);
            this.lblSecondaryFormType.Name = "lblSecondaryFormType";
            this.lblSecondaryFormType.Size = new System.Drawing.Size(44, 17);
            this.lblSecondaryFormType.TabIndex = 0;
            this.lblSecondaryFormType.Text = "Type:";
            // 
            // btnSecondaryFormAddPhoto
            // 
            this.btnSecondaryFormAddPhoto.Location = new System.Drawing.Point(194, 135);
            this.btnSecondaryFormAddPhoto.Name = "btnSecondaryFormAddPhoto";
            this.btnSecondaryFormAddPhoto.Size = new System.Drawing.Size(105, 23);
            this.btnSecondaryFormAddPhoto.TabIndex = 24;
            this.btnSecondaryFormAddPhoto.Text = "Add Photo";
            this.btnSecondaryFormAddPhoto.UseVisualStyleBackColor = true;
            this.btnSecondaryFormAddPhoto.Click += new System.EventHandler(this.btnSecondaryFormAddPhoto_Click);
            // 
            // txtSecondaryFormLastName
            // 
            this.txtSecondaryFormLastName.BackColor = System.Drawing.Color.White;
            this.txtSecondaryFormLastName.Location = new System.Drawing.Point(277, 93);
            this.txtSecondaryFormLastName.Name = "txtSecondaryFormLastName";
            this.txtSecondaryFormLastName.Size = new System.Drawing.Size(208, 22);
            this.txtSecondaryFormLastName.TabIndex = 23;
            // 
            // txtSecondaryFormFirstName
            // 
            this.txtSecondaryFormFirstName.BackColor = System.Drawing.Color.White;
            this.txtSecondaryFormFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtSecondaryFormFirstName.Location = new System.Drawing.Point(278, 53);
            this.txtSecondaryFormFirstName.Name = "txtSecondaryFormFirstName";
            this.txtSecondaryFormFirstName.Size = new System.Drawing.Size(207, 22);
            this.txtSecondaryFormFirstName.TabIndex = 22;
            // 
            // lblSecondaryFormLastName
            // 
            this.lblSecondaryFormLastName.AutoSize = true;
            this.lblSecondaryFormLastName.Location = new System.Drawing.Point(191, 93);
            this.lblSecondaryFormLastName.Name = "lblSecondaryFormLastName";
            this.lblSecondaryFormLastName.Size = new System.Drawing.Size(80, 17);
            this.lblSecondaryFormLastName.TabIndex = 21;
            this.lblSecondaryFormLastName.Text = "Last Name:";
            // 
            // lblSecondaryFormFirstName
            // 
            this.lblSecondaryFormFirstName.AutoSize = true;
            this.lblSecondaryFormFirstName.Location = new System.Drawing.Point(191, 53);
            this.lblSecondaryFormFirstName.Name = "lblSecondaryFormFirstName";
            this.lblSecondaryFormFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblSecondaryFormFirstName.TabIndex = 20;
            this.lblSecondaryFormFirstName.Text = "First Name:";
            // 
            // picSecondaryFormContact
            // 
            this.picSecondaryFormContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSecondaryFormContact.ErrorImage = null;
            this.picSecondaryFormContact.Image = ((System.Drawing.Image)(resources.GetObject("picSecondaryFormContact.Image")));
            this.picSecondaryFormContact.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSecondaryFormContact.InitialImage")));
            this.picSecondaryFormContact.Location = new System.Drawing.Point(21, 12);
            this.picSecondaryFormContact.Name = "picSecondaryFormContact";
            this.picSecondaryFormContact.Size = new System.Drawing.Size(164, 157);
            this.picSecondaryFormContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecondaryFormContact.TabIndex = 19;
            this.picSecondaryFormContact.TabStop = false;
            // 
            // btnSecondaryFormSave
            // 
            this.btnSecondaryFormSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSecondaryFormSave.Location = new System.Drawing.Point(380, 536);
            this.btnSecondaryFormSave.Name = "btnSecondaryFormSave";
            this.btnSecondaryFormSave.Size = new System.Drawing.Size(105, 23);
            this.btnSecondaryFormSave.TabIndex = 28;
            this.btnSecondaryFormSave.Text = "Save";
            this.btnSecondaryFormSave.UseVisualStyleBackColor = true;
            this.btnSecondaryFormSave.Click += new System.EventHandler(this.btnSecondaryFormSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 576);
            this.Controls.Add(this.btnSecondaryFormSave);
            this.Controls.Add(this.grbSecondaryFormPhone);
            this.Controls.Add(this.grbSecondaryFormEmail);
            this.Controls.Add(this.grbSecondaryFormAddress);
            this.Controls.Add(this.btnSecondaryFormAddPhoto);
            this.Controls.Add(this.txtSecondaryFormLastName);
            this.Controls.Add(this.txtSecondaryFormFirstName);
            this.Controls.Add(this.lblSecondaryFormLastName);
            this.Controls.Add(this.lblSecondaryFormFirstName);
            this.Controls.Add(this.picSecondaryFormContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contact";
            this.grbSecondaryFormPhone.ResumeLayout(false);
            this.grbSecondaryFormPhone.PerformLayout();
            this.grbSecondaryFormEmail.ResumeLayout(false);
            this.grbSecondaryFormEmail.PerformLayout();
            this.grbSecondaryFormAddress.ResumeLayout(false);
            this.grbSecondaryFormAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondaryFormContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSecondaryFormPhone;
        private System.Windows.Forms.Label lblSecondaryFormPhoneType;
        private System.Windows.Forms.GroupBox grbSecondaryFormEmail;
        private System.Windows.Forms.Label lblSecondaryFormEmailType;
        private System.Windows.Forms.TextBox txtSecondaryFormEmail;
        private System.Windows.Forms.GroupBox grbSecondaryFormAddress;
        private System.Windows.Forms.Label lblSecondaryFormZip;
        private System.Windows.Forms.Label lblSecondaryFormProvince;
        private System.Windows.Forms.TextBox txtSecondaryFormCity;
        private System.Windows.Forms.Label lblSecondaryFormCity;
        private System.Windows.Forms.TextBox txtSecondaryFormStreet;
        private System.Windows.Forms.Label lblSecondaryFormStreet;
        private System.Windows.Forms.Label lblSecondaryFormType;
        private System.Windows.Forms.Button btnSecondaryFormAddPhoto;
        private System.Windows.Forms.TextBox txtSecondaryFormLastName;
        private System.Windows.Forms.TextBox txtSecondaryFormFirstName;
        private System.Windows.Forms.Label lblSecondaryFormLastName;
        private System.Windows.Forms.Label lblSecondaryFormFirstName;
        private System.Windows.Forms.PictureBox picSecondaryFormContact;
        private System.Windows.Forms.Button btnSecondaryFormSave;
        private System.Windows.Forms.ComboBox cmbSecondaryFormAddressType;
        private System.Windows.Forms.ComboBox cmbSecondaryFormProvince;
        private System.Windows.Forms.ComboBox cmbSecondaryFormEmailType;
        private System.Windows.Forms.ComboBox cmbSecondaryFormPhoneType;
        private System.Windows.Forms.MaskedTextBox mtxZip;
        private System.Windows.Forms.MaskedTextBox mtxPhoneNumber;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}