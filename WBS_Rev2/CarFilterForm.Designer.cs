namespace WBS_Rev2
{
    partial class CarFilterForm
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
            this.TextBoxColor = new System.Windows.Forms.TextBox();
            this.Button_Filter_Color = new System.Windows.Forms.Button();
            this.ChooseColor = new System.Windows.Forms.Label();
            this.TextBox_All_License = new System.Windows.Forms.TextBox();
            this.TextBox_All_Brand = new System.Windows.Forms.TextBox();
            this.TextBox_All_Model = new System.Windows.Forms.TextBox();
            this.TextBox_All_Color = new System.Windows.Forms.TextBox();
            this.Button_Filter_All = new System.Windows.Forms.Button();
            this.Label_All_Features = new System.Windows.Forms.Label();
            this.Button_Return_To_List = new System.Windows.Forms.Button();
            this.GroupBox_Color = new System.Windows.Forms.GroupBox();
            this.GroupBox_All = new System.Windows.Forms.GroupBox();
            this.Label_Color = new System.Windows.Forms.Label();
            this.Label_Model = new System.Windows.Forms.Label();
            this.Label_Brand = new System.Windows.Forms.Label();
            this.Label_License = new System.Windows.Forms.Label();
            this.Button_All_Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Apk_Date = new System.Windows.Forms.ComboBox();
            this.Button_Filter_Apk = new System.Windows.Forms.Button();
            this.Label_Apk_Date = new System.Windows.Forms.Label();
            this.GroupBox_Color.SuspendLayout();
            this.GroupBox_All.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxColor
            // 
            this.TextBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBoxColor.Location = new System.Drawing.Point(13, 58);
            this.TextBoxColor.Name = "TextBoxColor";
            this.TextBoxColor.Size = new System.Drawing.Size(126, 29);
            this.TextBoxColor.TabIndex = 0;
            // 
            // Button_Filter_Color
            // 
            this.Button_Filter_Color.Location = new System.Drawing.Point(149, 58);
            this.Button_Filter_Color.Name = "Button_Filter_Color";
            this.Button_Filter_Color.Size = new System.Drawing.Size(71, 29);
            this.Button_Filter_Color.TabIndex = 2;
            this.Button_Filter_Color.Text = "Go";
            this.Button_Filter_Color.UseVisualStyleBackColor = true;
            this.Button_Filter_Color.Click += new System.EventHandler(this.FilterColorButton_Click);
            // 
            // ChooseColor
            // 
            this.ChooseColor.AutoSize = true;
            this.ChooseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ChooseColor.Location = new System.Drawing.Point(9, 20);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(122, 20);
            this.ChooseColor.TabIndex = 3;
            this.ChooseColor.Text = "Choose a color";
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
            // TextBox_All_Model
            // 
            this.TextBox_All_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox_All_Model.Location = new System.Drawing.Point(26, 184);
            this.TextBox_All_Model.Name = "TextBox_All_Model";
            this.TextBox_All_Model.Size = new System.Drawing.Size(207, 29);
            this.TextBox_All_Model.TabIndex = 4;
            // 
            // TextBox_All_Color
            // 
            this.TextBox_All_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox_All_Color.Location = new System.Drawing.Point(26, 233);
            this.TextBox_All_Color.Name = "TextBox_All_Color";
            this.TextBox_All_Color.Size = new System.Drawing.Size(207, 29);
            this.TextBox_All_Color.TabIndex = 4;
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
            // Button_Return_To_List
            // 
            this.Button_Return_To_List.Location = new System.Drawing.Point(288, 268);
            this.Button_Return_To_List.Name = "Button_Return_To_List";
            this.Button_Return_To_List.Size = new System.Drawing.Size(110, 49);
            this.Button_Return_To_List.TabIndex = 1;
            this.Button_Return_To_List.Text = "Cancel";
            this.Button_Return_To_List.UseVisualStyleBackColor = true;
            this.Button_Return_To_List.Click += new System.EventHandler(this.ReturnToList_Click);
            // 
            // GroupBox_Color
            // 
            this.GroupBox_Color.Controls.Add(this.Button_Filter_Color);
            this.GroupBox_Color.Controls.Add(this.TextBoxColor);
            this.GroupBox_Color.Controls.Add(this.ChooseColor);
            this.GroupBox_Color.Location = new System.Drawing.Point(288, 12);
            this.GroupBox_Color.Name = "GroupBox_Color";
            this.GroupBox_Color.Size = new System.Drawing.Size(240, 112);
            this.GroupBox_Color.TabIndex = 5;
            this.GroupBox_Color.TabStop = false;
            // 
            // GroupBox_All
            // 
            this.GroupBox_All.Controls.Add(this.Label_Color);
            this.GroupBox_All.Controls.Add(this.Label_Model);
            this.GroupBox_All.Controls.Add(this.Label_Brand);
            this.GroupBox_All.Controls.Add(this.Label_License);
            this.GroupBox_All.Controls.Add(this.Label_All_Features);
            this.GroupBox_All.Controls.Add(this.TextBox_All_Color);
            this.GroupBox_All.Controls.Add(this.Button_Filter_All);
            this.GroupBox_All.Controls.Add(this.TextBox_All_Model);
            this.GroupBox_All.Controls.Add(this.TextBox_All_License);
            this.GroupBox_All.Controls.Add(this.TextBox_All_Brand);
            this.GroupBox_All.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_All.Name = "GroupBox_All";
            this.GroupBox_All.Size = new System.Drawing.Size(258, 320);
            this.GroupBox_All.TabIndex = 6;
            this.GroupBox_All.TabStop = false;
            // 
            // Label_Color
            // 
            this.Label_Color.AutoSize = true;
            this.Label_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Color.Location = new System.Drawing.Point(25, 215);
            this.Label_Color.Name = "Label_Color";
            this.Label_Color.Size = new System.Drawing.Size(36, 15);
            this.Label_Color.TabIndex = 5;
            this.Label_Color.Text = "Color";
            // 
            // Label_Model
            // 
            this.Label_Model.AutoSize = true;
            this.Label_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Model.Location = new System.Drawing.Point(25, 166);
            this.Label_Model.Name = "Label_Model";
            this.Label_Model.Size = new System.Drawing.Size(42, 15);
            this.Label_Model.TabIndex = 5;
            this.Label_Model.Text = "Model";
            // 
            // Label_Brand
            // 
            this.Label_Brand.AutoSize = true;
            this.Label_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Brand.Location = new System.Drawing.Point(25, 111);
            this.Label_Brand.Name = "Label_Brand";
            this.Label_Brand.Size = new System.Drawing.Size(40, 15);
            this.Label_Brand.TabIndex = 5;
            this.Label_Brand.Text = "Brand";
            // 
            // Label_License
            // 
            this.Label_License.AutoSize = true;
            this.Label_License.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_License.Location = new System.Drawing.Point(25, 56);
            this.Label_License.Name = "Label_License";
            this.Label_License.Size = new System.Drawing.Size(50, 15);
            this.Label_License.TabIndex = 5;
            this.Label_License.Text = "License";
            // 
            // Button_All_Reset
            // 
            this.Button_All_Reset.Location = new System.Drawing.Point(418, 268);
            this.Button_All_Reset.Name = "Button_All_Reset";
            this.Button_All_Reset.Size = new System.Drawing.Size(110, 48);
            this.Button_All_Reset.TabIndex = 2;
            this.Button_All_Reset.Text = "Reset";
            this.Button_All_Reset.UseVisualStyleBackColor = true;
            this.Button_All_Reset.Click += new System.EventHandler(this.Button_Sort_All_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Apk_Date);
            this.groupBox1.Controls.Add(this.Button_Filter_Apk);
            this.groupBox1.Controls.Add(this.Label_Apk_Date);
            this.groupBox1.Location = new System.Drawing.Point(288, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_Apk_Date
            // 
            this.comboBox_Apk_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Apk_Date.FormattingEnabled = true;
            this.comboBox_Apk_Date.ItemHeight = 20;
            this.comboBox_Apk_Date.Items.AddRange(new object[] {
            "Valid",
            "Expired"});
            this.comboBox_Apk_Date.Location = new System.Drawing.Point(13, 59);
            this.comboBox_Apk_Date.Name = "comboBox_Apk_Date";
            this.comboBox_Apk_Date.Size = new System.Drawing.Size(126, 28);
            this.comboBox_Apk_Date.TabIndex = 7;
            this.comboBox_Apk_Date.Text = "Valid";
            this.comboBox_Apk_Date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_APK_KeyPress);
            // 
            // Button_Filter_Apk
            // 
            this.Button_Filter_Apk.Location = new System.Drawing.Point(149, 58);
            this.Button_Filter_Apk.Name = "Button_Filter_Apk";
            this.Button_Filter_Apk.Size = new System.Drawing.Size(71, 29);
            this.Button_Filter_Apk.TabIndex = 2;
            this.Button_Filter_Apk.Text = "Go";
            this.Button_Filter_Apk.UseVisualStyleBackColor = true;
            this.Button_Filter_Apk.Click += new System.EventHandler(this.Button_Filter_Apk_Click);
            // 
            // Label_Apk_Date
            // 
            this.Label_Apk_Date.AutoSize = true;
            this.Label_Apk_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Label_Apk_Date.Location = new System.Drawing.Point(9, 20);
            this.Label_Apk_Date.Name = "Label_Apk_Date";
            this.Label_Apk_Date.Size = new System.Drawing.Size(89, 20);
            this.Label_Apk_Date.TabIndex = 3;
            this.Label_Apk_Date.Text = "Check Apk";
            // 
            // CarFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 345);
            this.Controls.Add(this.GroupBox_All);
            this.Controls.Add(this.Button_Return_To_List);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_Color);
            this.Controls.Add(this.Button_All_Reset);
            this.Name = "CarFilterForm";
            this.Text = "Filter";
            this.GroupBox_Color.ResumeLayout(false);
            this.GroupBox_Color.PerformLayout();
            this.GroupBox_All.ResumeLayout(false);
            this.GroupBox_All.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxColor;
        private System.Windows.Forms.Button Button_Filter_Color;
        private System.Windows.Forms.Label ChooseColor;
        private System.Windows.Forms.TextBox TextBox_All_License;
        private System.Windows.Forms.TextBox TextBox_All_Brand;
        private System.Windows.Forms.TextBox TextBox_All_Model;
        private System.Windows.Forms.TextBox TextBox_All_Color;
        private System.Windows.Forms.Button Button_Filter_All;
        private System.Windows.Forms.Label Label_All_Features;
        private System.Windows.Forms.Button Button_Return_To_List;
        private System.Windows.Forms.GroupBox GroupBox_Color;
        private System.Windows.Forms.GroupBox GroupBox_All;
        private System.Windows.Forms.Label Label_Color;
        private System.Windows.Forms.Label Label_Model;
        private System.Windows.Forms.Label Label_Brand;
        private System.Windows.Forms.Label Label_License;
        private System.Windows.Forms.Button Button_All_Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Filter_Apk;
        private System.Windows.Forms.Label Label_Apk_Date;
        private System.Windows.Forms.ComboBox comboBox_Apk_Date;
    }
}