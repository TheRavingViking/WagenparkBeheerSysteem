namespace WBS
{
    partial class PersonFilterForm
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
            this.GroupBox_All = new System.Windows.Forms.GroupBox();
            this.ComboBox_Gender = new System.Windows.Forms.ComboBox();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.Label_Lastname = new System.Windows.Forms.Label();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.Label_All_Features = new System.Windows.Forms.Label();
            this.Button_Filter_All = new System.Windows.Forms.Button();
            this.TextBox_All_License = new System.Windows.Forms.TextBox();
            this.TextBox_All_Brand = new System.Windows.Forms.TextBox();
            this.Button_Return_To_List = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_License_expriy = new System.Windows.Forms.ComboBox();
            this.Button_Filter_license_Expiry = new System.Windows.Forms.Button();
            this.Label_License_Date = new System.Windows.Forms.Label();
            this.GroupBox_Color = new System.Windows.Forms.GroupBox();
            this.Button_Filter_Firstname = new System.Windows.Forms.Button();
            this.TextBox_Firstname = new System.Windows.Forms.TextBox();
            this.ChooseColor = new System.Windows.Forms.Label();
            this.Button_All_Reset = new System.Windows.Forms.Button();
            this.GroupBox_All.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox_Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_All
            // 
            this.GroupBox_All.Controls.Add(this.ComboBox_Gender);
            this.GroupBox_All.Controls.Add(this.Label_Gender);
            this.GroupBox_All.Controls.Add(this.Label_Lastname);
            this.GroupBox_All.Controls.Add(this.Label_FirstName);
            this.GroupBox_All.Controls.Add(this.Label_All_Features);
            this.GroupBox_All.Controls.Add(this.Button_Filter_All);
            this.GroupBox_All.Controls.Add(this.TextBox_All_License);
            this.GroupBox_All.Controls.Add(this.TextBox_All_Brand);
            this.GroupBox_All.Location = new System.Drawing.Point(19, 12);
            this.GroupBox_All.Name = "GroupBox_All";
            this.GroupBox_All.Size = new System.Drawing.Size(258, 320);
            this.GroupBox_All.TabIndex = 11;
            this.GroupBox_All.TabStop = false;
            // 
            // ComboBox_Gender
            // 
            this.ComboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Gender.FormattingEnabled = true;
            this.ComboBox_Gender.ItemHeight = 20;
            this.ComboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ComboBox_Gender.Location = new System.Drawing.Point(26, 184);
            this.ComboBox_Gender.Name = "ComboBox_Gender";
            this.ComboBox_Gender.Size = new System.Drawing.Size(207, 28);
            this.ComboBox_Gender.TabIndex = 7;
            this.ComboBox_Gender.Text = "Male";
            this.ComboBox_Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_Key_Press);
            // 
            // Label_Gender
            // 
            this.Label_Gender.AutoSize = true;
            this.Label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Gender.Location = new System.Drawing.Point(25, 166);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(48, 15);
            this.Label_Gender.TabIndex = 5;
            this.Label_Gender.Text = "Gender";
            // 
            // Label_Lastname
            // 
            this.Label_Lastname.AutoSize = true;
            this.Label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Lastname.Location = new System.Drawing.Point(25, 111);
            this.Label_Lastname.Name = "Label_Lastname";
            this.Label_Lastname.Size = new System.Drawing.Size(62, 15);
            this.Label_Lastname.TabIndex = 5;
            this.Label_Lastname.Text = "Lastname";
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FirstName.Location = new System.Drawing.Point(25, 56);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(62, 15);
            this.Label_FirstName.TabIndex = 5;
            this.Label_FirstName.Text = "Firstname";
            // 
            // Label_All_Features
            // 
            this.Label_All_Features.AutoSize = true;
            this.Label_All_Features.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Label_All_Features.Location = new System.Drawing.Point(22, 20);
            this.Label_All_Features.Name = "Label_All_Features";
            this.Label_All_Features.Size = new System.Drawing.Size(126, 20);
            this.Label_All_Features.TabIndex = 3;
            this.Label_All_Features.Text = "Filter by feature";
            // 
            // Button_Filter_All
            // 
            this.Button_Filter_All.Location = new System.Drawing.Point(133, 271);
            this.Button_Filter_All.Name = "Button_Filter_All";
            this.Button_Filter_All.Size = new System.Drawing.Size(100, 34);
            this.Button_Filter_All.TabIndex = 2;
            this.Button_Filter_All.Text = "Go";
            this.Button_Filter_All.UseVisualStyleBackColor = true;
            this.Button_Filter_All.Click += new System.EventHandler(this.Button_Sort_All_Click);
            // 
            // TextBox_All_License
            // 
            this.TextBox_All_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox_All_License.Location = new System.Drawing.Point(26, 73);
            this.TextBox_All_License.Name = "TextBox_All_License";
            this.TextBox_All_License.Size = new System.Drawing.Size(207, 29);
            this.TextBox_All_License.TabIndex = 4;
            // 
            // TextBox_All_Brand
            // 
            this.TextBox_All_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox_All_Brand.Location = new System.Drawing.Point(26, 129);
            this.TextBox_All_Brand.Name = "TextBox_All_Brand";
            this.TextBox_All_Brand.Size = new System.Drawing.Size(207, 29);
            this.TextBox_All_Brand.TabIndex = 4;
            // 
            // Button_Return_To_List
            // 
            this.Button_Return_To_List.Location = new System.Drawing.Point(295, 274);
            this.Button_Return_To_List.Name = "Button_Return_To_List";
            this.Button_Return_To_List.Size = new System.Drawing.Size(110, 49);
            this.Button_Return_To_List.TabIndex = 7;
            this.Button_Return_To_List.Text = "Cancel";
            this.Button_Return_To_List.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_License_expriy);
            this.groupBox1.Controls.Add(this.Button_Filter_license_Expiry);
            this.groupBox1.Controls.Add(this.Label_License_Date);
            this.groupBox1.Location = new System.Drawing.Point(295, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 112);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_License_expriy
            // 
            this.comboBox_License_expriy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_License_expriy.FormattingEnabled = true;
            this.comboBox_License_expriy.ItemHeight = 20;
            this.comboBox_License_expriy.Items.AddRange(new object[] {
            "Valid",
            "Expired"});
            this.comboBox_License_expriy.Location = new System.Drawing.Point(13, 59);
            this.comboBox_License_expriy.Name = "comboBox_License_expriy";
            this.comboBox_License_expriy.Size = new System.Drawing.Size(126, 28);
            this.comboBox_License_expriy.TabIndex = 7;
            this.comboBox_License_expriy.Text = "Valid";
            this.comboBox_License_expriy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_Key_Press);
            // 
            // Button_Filter_license_Expiry
            // 
            this.Button_Filter_license_Expiry.Location = new System.Drawing.Point(149, 58);
            this.Button_Filter_license_Expiry.Name = "Button_Filter_license_Expiry";
            this.Button_Filter_license_Expiry.Size = new System.Drawing.Size(71, 29);
            this.Button_Filter_license_Expiry.TabIndex = 2;
            this.Button_Filter_license_Expiry.Text = "Go";
            this.Button_Filter_license_Expiry.UseVisualStyleBackColor = true;
            this.Button_Filter_license_Expiry.Click += new System.EventHandler(this.FilterLicenseExpiryButton_Click);
            // 
            // Label_License_Date
            // 
            this.Label_License_Date.AutoSize = true;
            this.Label_License_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Label_License_Date.Location = new System.Drawing.Point(9, 20);
            this.Label_License_Date.Name = "Label_License_Date";
            this.Label_License_Date.Size = new System.Drawing.Size(169, 20);
            this.Label_License_Date.TabIndex = 3;
            this.Label_License_Date.Text = "Check License expiry";
            // 
            // GroupBox_Color
            // 
            this.GroupBox_Color.Controls.Add(this.Button_Filter_Firstname);
            this.GroupBox_Color.Controls.Add(this.TextBox_Firstname);
            this.GroupBox_Color.Controls.Add(this.ChooseColor);
            this.GroupBox_Color.Location = new System.Drawing.Point(295, 12);
            this.GroupBox_Color.Name = "GroupBox_Color";
            this.GroupBox_Color.Size = new System.Drawing.Size(240, 112);
            this.GroupBox_Color.TabIndex = 10;
            this.GroupBox_Color.TabStop = false;
            // 
            // Button_Filter_Firstname
            // 
            this.Button_Filter_Firstname.Location = new System.Drawing.Point(149, 58);
            this.Button_Filter_Firstname.Name = "Button_Filter_Firstname";
            this.Button_Filter_Firstname.Size = new System.Drawing.Size(71, 29);
            this.Button_Filter_Firstname.TabIndex = 2;
            this.Button_Filter_Firstname.Text = "Go";
            this.Button_Filter_Firstname.UseVisualStyleBackColor = true;
            this.Button_Filter_Firstname.Click += new System.EventHandler(this.FilterFirstnameButton_Click);
            // 
            // TextBox_Firstname
            // 
            this.TextBox_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox_Firstname.Location = new System.Drawing.Point(13, 58);
            this.TextBox_Firstname.Name = "TextBox_Firstname";
            this.TextBox_Firstname.Size = new System.Drawing.Size(126, 29);
            this.TextBox_Firstname.TabIndex = 0;
            // 
            // ChooseColor
            // 
            this.ChooseColor.AutoSize = true;
            this.ChooseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ChooseColor.Location = new System.Drawing.Point(9, 20);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(146, 20);
            this.ChooseColor.TabIndex = 3;
            this.ChooseColor.Text = "Choose Firstname";
            // 
            // Button_All_Reset
            // 
            this.Button_All_Reset.Location = new System.Drawing.Point(425, 274);
            this.Button_All_Reset.Name = "Button_All_Reset";
            this.Button_All_Reset.Size = new System.Drawing.Size(110, 48);
            this.Button_All_Reset.TabIndex = 8;
            this.Button_All_Reset.Text = "Reset";
            this.Button_All_Reset.UseVisualStyleBackColor = true;
            // 
            // PersonFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 348);
            this.Controls.Add(this.GroupBox_All);
            this.Controls.Add(this.Button_Return_To_List);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_Color);
            this.Controls.Add(this.Button_All_Reset);
            this.Name = "PersonFilterForm";
            this.Text = "PersonFilterForm";
            this.GroupBox_All.ResumeLayout(false);
            this.GroupBox_All.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox_Color.ResumeLayout(false);
            this.GroupBox_Color.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_All;
        private System.Windows.Forms.Label Label_Gender;
        private System.Windows.Forms.Label Label_Lastname;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.Label Label_All_Features;
        private System.Windows.Forms.Button Button_Filter_All;
        private System.Windows.Forms.TextBox TextBox_All_License;
        private System.Windows.Forms.TextBox TextBox_All_Brand;
        private System.Windows.Forms.Button Button_Return_To_List;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_License_expriy;
        private System.Windows.Forms.Button Button_Filter_license_Expiry;
        private System.Windows.Forms.Label Label_License_Date;
        private System.Windows.Forms.GroupBox GroupBox_Color;
        private System.Windows.Forms.Button Button_Filter_Firstname;
        private System.Windows.Forms.TextBox TextBox_Firstname;
        private System.Windows.Forms.Label ChooseColor;
        private System.Windows.Forms.Button Button_All_Reset;
        private System.Windows.Forms.ComboBox ComboBox_Gender;
    }
}