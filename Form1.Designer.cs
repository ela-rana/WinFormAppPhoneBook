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
            this.grpDisplayContact = new System.Windows.Forms.GroupBox();
            this.grpSearchContact = new System.Windows.Forms.GroupBox();
            this.grpDeleteContact = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAddContact.SuspendLayout();
            this.grpDisplayContact.SuspendLayout();
            this.grpSearchContact.SuspendLayout();
            this.grpDeleteContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddContact
            // 
            this.grpAddContact.Controls.Add(this.btnAddContact);
            this.grpAddContact.Controls.Add(this.textBox5);
            this.grpAddContact.Controls.Add(this.textBox4);
            this.grpAddContact.Controls.Add(this.textBox3);
            this.grpAddContact.Controls.Add(this.textBox2);
            this.grpAddContact.Controls.Add(this.textBox1);
            this.grpAddContact.Controls.Add(this.lblAddress);
            this.grpAddContact.Controls.Add(this.lblWorkPhone);
            this.grpAddContact.Controls.Add(this.lblCellPhone);
            this.grpAddContact.Controls.Add(this.lblLastName);
            this.grpAddContact.Controls.Add(this.lblFirstName);
            this.grpAddContact.Location = new System.Drawing.Point(14, 674);
            this.grpAddContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddContact.Name = "grpAddContact";
            this.grpAddContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddContact.Size = new System.Drawing.Size(427, 286);
            this.grpAddContact.TabIndex = 0;
            this.grpAddContact.TabStop = false;
            this.grpAddContact.Text = "Add A New Contact";
            // 
            // grpDisplayContact
            // 
            this.grpDisplayContact.Controls.Add(this.dataGridView1);
            this.grpDisplayContact.Location = new System.Drawing.Point(14, 14);
            this.grpDisplayContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDisplayContact.Name = "grpDisplayContact";
            this.grpDisplayContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDisplayContact.Size = new System.Drawing.Size(1022, 651);
            this.grpDisplayContact.TabIndex = 1;
            this.grpDisplayContact.TabStop = false;
            this.grpDisplayContact.Text = "Contacts Display";
            // 
            // grpSearchContact
            // 
            this.grpSearchContact.Controls.Add(this.btnSearchContact);
            this.grpSearchContact.Controls.Add(this.label2);
            this.grpSearchContact.Controls.Add(this.textBox6);
            this.grpSearchContact.Controls.Add(this.label1);
            this.grpSearchContact.Location = new System.Drawing.Point(448, 674);
            this.grpSearchContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchContact.Name = "grpSearchContact";
            this.grpSearchContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchContact.Size = new System.Drawing.Size(588, 134);
            this.grpSearchContact.TabIndex = 1;
            this.grpSearchContact.TabStop = false;
            this.grpSearchContact.Text = "Search Contact";
            // 
            // grpDeleteContact
            // 
            this.grpDeleteContact.Controls.Add(this.btnDeleteContact);
            this.grpDeleteContact.Controls.Add(this.label3);
            this.grpDeleteContact.Location = new System.Drawing.Point(449, 816);
            this.grpDeleteContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDeleteContact.Name = "grpDeleteContact";
            this.grpDeleteContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDeleteContact.Size = new System.Drawing.Size(587, 144);
            this.grpDeleteContact.TabIndex = 2;
            this.grpDeleteContact.TabStop = false;
            this.grpDeleteContact.Text = "Delete Contact";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 632);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 36);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 72);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(18, 105);
            this.lblCellPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(60, 16);
            this.lblCellPhone.TabIndex = 2;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(18, 142);
            this.lblWorkPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(68, 16);
            this.lblWorkPhone.TabIndex = 3;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 180);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.Location = new System.Drawing.Point(106, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 25);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Honeydew;
            this.textBox2.Location = new System.Drawing.Point(106, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Honeydew;
            this.textBox3.Location = new System.Drawing.Point(106, 103);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Honeydew;
            this.textBox4.Location = new System.Drawing.Point(106, 139);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Honeydew;
            this.textBox5.Location = new System.Drawing.Point(106, 180);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(301, 44);
            this.textBox5.TabIndex = 9;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(134, 237);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(150, 29);
            this.btnAddContact.TabIndex = 10;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Honeydew;
            this.textBox6.Location = new System.Drawing.Point(90, 69);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 25);
            this.textBox6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the name of the person you wish to search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearchContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.Location = new System.Drawing.Point(350, 50);
            this.btnSearchContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(150, 29);
            this.btnSearchContact.TabIndex = 11;
            this.btnSearchContact.Text = "Search Contact";
            this.btnSearchContact.UseVisualStyleBackColor = false;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeleteContact.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(266, 95);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(150, 29);
            this.btnDeleteContact.TabIndex = 13;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select the contact that you wish to delete in the Contacts Display above and then" +
    " \r\nclick Delete Contact below:";
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Contact Book";
            this.grpAddContact.ResumeLayout(false);
            this.grpAddContact.PerformLayout();
            this.grpDisplayContact.ResumeLayout(false);
            this.grpSearchContact.ResumeLayout(false);
            this.grpSearchContact.PerformLayout();
            this.grpDeleteContact.ResumeLayout(false);
            this.grpDeleteContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddContact;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpDisplayContact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpSearchContact;
        private System.Windows.Forms.GroupBox grpDeleteContact;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Label label3;
    }
}

