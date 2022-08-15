namespace WinFormAppPhoneBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpAddContact = new System.Windows.Forms.GroupBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxHomePhone = new System.Windows.Forms.TextBox();
            this.txtbxCellPhone = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpDisplayContact = new System.Windows.Forms.GroupBox();
            this.dtGrdContacts = new System.Windows.Forms.DataGridView();
            this.grpSearchContact = new System.Windows.Forms.GroupBox();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDeleteContact = new System.Windows.Forms.GroupBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplayAllContacts = new System.Windows.Forms.Button();
            this.grpAddContact.SuspendLayout();
            this.grpDisplayContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdContacts)).BeginInit();
            this.grpSearchContact.SuspendLayout();
            this.grpDeleteContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddContact
            // 
            this.grpAddContact.Controls.Add(this.btnAddContact);
            this.grpAddContact.Controls.Add(this.txtbxAddress);
            this.grpAddContact.Controls.Add(this.txtbxHomePhone);
            this.grpAddContact.Controls.Add(this.txtbxCellPhone);
            this.grpAddContact.Controls.Add(this.txtbxLastName);
            this.grpAddContact.Controls.Add(this.txtbxFirstName);
            this.grpAddContact.Controls.Add(this.lblAddress);
            this.grpAddContact.Controls.Add(this.lblWorkPhone);
            this.grpAddContact.Controls.Add(this.lblCellPhone);
            this.grpAddContact.Controls.Add(this.lblLastName);
            this.grpAddContact.Controls.Add(this.lblFirstName);
            this.grpAddContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddContact.Location = new System.Drawing.Point(14, 674);
            this.grpAddContact.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddContact.Name = "grpAddContact";
            this.grpAddContact.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddContact.Size = new System.Drawing.Size(427, 286);
            this.grpAddContact.TabIndex = 0;
            this.grpAddContact.TabStop = false;
            this.grpAddContact.Text = "Add A New Contact";
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddContact.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(134, 237);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(150, 29);
            this.btnAddContact.TabIndex = 10;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxAddress.Location = new System.Drawing.Point(106, 180);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(301, 44);
            this.txtbxAddress.TabIndex = 9;
            // 
            // txtbxHomePhone
            // 
            this.txtbxHomePhone.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxHomePhone.Location = new System.Drawing.Point(106, 139);
            this.txtbxHomePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxHomePhone.Name = "txtbxHomePhone";
            this.txtbxHomePhone.Size = new System.Drawing.Size(301, 28);
            this.txtbxHomePhone.TabIndex = 8;
            // 
            // txtbxCellPhone
            // 
            this.txtbxCellPhone.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxCellPhone.Location = new System.Drawing.Point(106, 103);
            this.txtbxCellPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCellPhone.Name = "txtbxCellPhone";
            this.txtbxCellPhone.Size = new System.Drawing.Size(301, 28);
            this.txtbxCellPhone.TabIndex = 7;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxLastName.Location = new System.Drawing.Point(106, 68);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(301, 28);
            this.txtbxLastName.TabIndex = 6;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxFirstName.Location = new System.Drawing.Point(106, 32);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(301, 28);
            this.txtbxFirstName.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(18, 180);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkPhone.Location = new System.Drawing.Point(18, 142);
            this.lblWorkPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(76, 17);
            this.lblWorkPhone.TabIndex = 3;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.Location = new System.Drawing.Point(18, 105);
            this.lblCellPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(67, 17);
            this.lblCellPhone.TabIndex = 2;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(18, 72);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 36);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // grpDisplayContact
            // 
            this.grpDisplayContact.Controls.Add(this.btnDisplayAllContacts);
            this.grpDisplayContact.Controls.Add(this.dtGrdContacts);
            this.grpDisplayContact.Location = new System.Drawing.Point(14, 14);
            this.grpDisplayContact.Margin = new System.Windows.Forms.Padding(4);
            this.grpDisplayContact.Name = "grpDisplayContact";
            this.grpDisplayContact.Padding = new System.Windows.Forms.Padding(4);
            this.grpDisplayContact.Size = new System.Drawing.Size(1022, 651);
            this.grpDisplayContact.TabIndex = 1;
            this.grpDisplayContact.TabStop = false;
            this.grpDisplayContact.Text = "Contacts Display   (Currently displaying all contacts)";
            // 
            // dtGrdContacts
            // 
            this.dtGrdContacts.AllowUserToAddRows = false;
            this.dtGrdContacts.AllowUserToDeleteRows = false;
            this.dtGrdContacts.AllowUserToOrderColumns = true;
            this.dtGrdContacts.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtGrdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdContacts.Location = new System.Drawing.Point(4, 54);
            this.dtGrdContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdContacts.Name = "dtGrdContacts";
            this.dtGrdContacts.ReadOnly = true;
            this.dtGrdContacts.Size = new System.Drawing.Size(1018, 597);
            this.dtGrdContacts.TabIndex = 0;
            // 
            // grpSearchContact
            // 
            this.grpSearchContact.Controls.Add(this.btnSearchContact);
            this.grpSearchContact.Controls.Add(this.label2);
            this.grpSearchContact.Controls.Add(this.txtbxSearchName);
            this.grpSearchContact.Controls.Add(this.label1);
            this.grpSearchContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchContact.Location = new System.Drawing.Point(448, 674);
            this.grpSearchContact.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearchContact.Name = "grpSearchContact";
            this.grpSearchContact.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearchContact.Size = new System.Drawing.Size(588, 197);
            this.grpSearchContact.TabIndex = 1;
            this.grpSearchContact.TabStop = false;
            this.grpSearchContact.Text = "Search Contact";
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearchContact.Enabled = false;
            this.btnSearchContact.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.Location = new System.Drawing.Point(350, 50);
            this.btnSearchContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(150, 29);
            this.btnSearchContact.TabIndex = 11;
            this.btnSearchContact.Text = "Search Contact";
            this.btnSearchContact.UseVisualStyleBackColor = false;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // txtbxSearchName
            // 
            this.txtbxSearchName.BackColor = System.Drawing.Color.Honeydew;
            this.txtbxSearchName.Location = new System.Drawing.Point(90, 69);
            this.txtbxSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSearchName.Name = "txtbxSearchName";
            this.txtbxSearchName.Size = new System.Drawing.Size(211, 28);
            this.txtbxSearchName.TabIndex = 7;
            this.txtbxSearchName.TextChanged += new System.EventHandler(this.txtbxSearchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the name of the person you wish to search:";
            // 
            // grpDeleteContact
            // 
            this.grpDeleteContact.Controls.Add(this.btnDeleteContact);
            this.grpDeleteContact.Controls.Add(this.label3);
            this.grpDeleteContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeleteContact.Location = new System.Drawing.Point(449, 871);
            this.grpDeleteContact.Margin = new System.Windows.Forms.Padding(4);
            this.grpDeleteContact.Name = "grpDeleteContact";
            this.grpDeleteContact.Padding = new System.Windows.Forms.Padding(4);
            this.grpDeleteContact.Size = new System.Drawing.Size(587, 89);
            this.grpDeleteContact.TabIndex = 2;
            this.grpDeleteContact.TabStop = false;
            this.grpDeleteContact.Text = "Delete Contact";
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeleteContact.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(262, 51);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(150, 29);
            this.btnDeleteContact.TabIndex = 13;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select the contact that you wish to delete in the Contacts Display above and then" +
    " \r\nclick Delete Contact below:";
            // 
            // btnDisplayAllContacts
            // 
            this.btnDisplayAllContacts.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDisplayAllContacts.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllContacts.Location = new System.Drawing.Point(396, 17);
            this.btnDisplayAllContacts.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayAllContacts.Name = "btnDisplayAllContacts";
            this.btnDisplayAllContacts.Size = new System.Drawing.Size(178, 29);
            this.btnDisplayAllContacts.TabIndex = 12;
            this.btnDisplayAllContacts.Text = "Display All Contacts";
            this.btnDisplayAllContacts.UseVisualStyleBackColor = false;
            this.btnDisplayAllContacts.Click += new System.EventHandler(this.btnDisplayAllContacts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1058, 981);
            this.Controls.Add(this.grpDeleteContact);
            this.Controls.Add(this.grpSearchContact);
            this.Controls.Add(this.grpDisplayContact);
            this.Controls.Add(this.grpAddContact);
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Contact Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddContact.ResumeLayout(false);
            this.grpAddContact.PerformLayout();
            this.grpDisplayContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdContacts)).EndInit();
            this.grpSearchContact.ResumeLayout(false);
            this.grpSearchContact.PerformLayout();
            this.grpDeleteContact.ResumeLayout(false);
            this.grpDeleteContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddContact;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpDisplayContact;
        private System.Windows.Forms.DataGridView dtGrdContacts;
        private System.Windows.Forms.GroupBox grpSearchContact;
        private System.Windows.Forms.GroupBox grpDeleteContact;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxHomePhone;
        private System.Windows.Forms.TextBox txtbxCellPhone;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisplayAllContacts;
    }
}

