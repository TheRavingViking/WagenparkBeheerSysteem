namespace WBS
{
    partial class PersonOverview
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
            this.Button_Edit_Person = new System.Windows.Forms.Button();
            this.Button_Return_To_Main_Menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.FirstnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driverslicense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Delete_Person = new System.Windows.Forms.Button();
            this.Button_Filter = new System.Windows.Forms.Button();
            this.button_Reset_Filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Edit_Person
            // 
            this.Button_Edit_Person.Location = new System.Drawing.Point(230, 509);
            this.Button_Edit_Person.Name = "Button_Edit_Person";
            this.Button_Edit_Person.Size = new System.Drawing.Size(212, 61);
            this.Button_Edit_Person.TabIndex = 6;
            this.Button_Edit_Person.Text = "Edit Person";
            this.Button_Edit_Person.UseVisualStyleBackColor = true;
            this.Button_Edit_Person.Click += new System.EventHandler(this.editPersonClick);
            // 
            // Button_Return_To_Main_Menu
            // 
            this.Button_Return_To_Main_Menu.Location = new System.Drawing.Point(12, 509);
            this.Button_Return_To_Main_Menu.Name = "Button_Return_To_Main_Menu";
            this.Button_Return_To_Main_Menu.Size = new System.Drawing.Size(212, 61);
            this.Button_Return_To_Main_Menu.TabIndex = 7;
            this.Button_Return_To_Main_Menu.Text = "Return";
            this.Button_Return_To_Main_Menu.UseVisualStyleBackColor = true;
            this.Button_Return_To_Main_Menu.Click += new System.EventHandler(this.ReturnToMainMenuFromPersonList_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listViewPerson
            // 
            this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstnameHeader,
            this.lastname,
            this.birthday,
            this.driverslicense});
            this.listViewPerson.FullRowSelect = true;
            this.listViewPerson.GridLines = true;
            this.listViewPerson.Location = new System.Drawing.Point(9, 12);
            this.listViewPerson.MultiSelect = false;
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(503, 424);
            this.listViewPerson.TabIndex = 9;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.View = System.Windows.Forms.View.Details;
            // 
            // FirstnameHeader
            // 
            this.FirstnameHeader.Text = "Firstname";
            this.FirstnameHeader.Width = 120;
            // 
            // lastname
            // 
            this.lastname.Text = "Lastname";
            this.lastname.Width = 120;
            // 
            // birthday
            // 
            this.birthday.Text = "birthday";
            this.birthday.Width = 120;
            // 
            // driverslicense
            // 
            this.driverslicense.Text = "license";
            this.driverslicense.Width = 125;
            // 
            // Button_Delete_Person
            // 
            this.Button_Delete_Person.Location = new System.Drawing.Point(448, 442);
            this.Button_Delete_Person.Name = "Button_Delete_Person";
            this.Button_Delete_Person.Size = new System.Drawing.Size(64, 128);
            this.Button_Delete_Person.TabIndex = 10;
            this.Button_Delete_Person.Text = "Delete";
            this.Button_Delete_Person.UseVisualStyleBackColor = true;
            this.Button_Delete_Person.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Button_Filter
            // 
            this.Button_Filter.Location = new System.Drawing.Point(12, 442);
            this.Button_Filter.Name = "Button_Filter";
            this.Button_Filter.Size = new System.Drawing.Size(212, 61);
            this.Button_Filter.TabIndex = 7;
            this.Button_Filter.Text = "Filter";
            this.Button_Filter.UseVisualStyleBackColor = true;
            this.Button_Filter.Click += new System.EventHandler(this.Button_Filter_Click);
            // 
            // button_Reset_Filter
            // 
            this.button_Reset_Filter.Location = new System.Drawing.Point(230, 442);
            this.button_Reset_Filter.Name = "button_Reset_Filter";
            this.button_Reset_Filter.Size = new System.Drawing.Size(212, 61);
            this.button_Reset_Filter.TabIndex = 7;
            this.button_Reset_Filter.Text = "Reset filter";
            this.button_Reset_Filter.UseVisualStyleBackColor = true;
            this.button_Reset_Filter.Click += new System.EventHandler(this.Button_Reset_Filter_Click);
            // 
            // PersonOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 579);
            this.Controls.Add(this.Button_Delete_Person);
            this.Controls.Add(this.listViewPerson);
            this.Controls.Add(this.Button_Edit_Person);
            this.Controls.Add(this.button_Reset_Filter);
            this.Controls.Add(this.Button_Filter);
            this.Controls.Add(this.Button_Return_To_Main_Menu);
            this.Controls.Add(this.button1);
            this.Name = "PersonOverview";
            this.Text = "PersonList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Edit_Person;
        private System.Windows.Forms.Button Button_Return_To_Main_Menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.ColumnHeader FirstnameHeader;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader birthday;
        private System.Windows.Forms.ColumnHeader driverslicense;
        private System.Windows.Forms.Button Button_Delete_Person;
        private System.Windows.Forms.Button Button_Filter;
        private System.Windows.Forms.Button button_Reset_Filter;
    }
}