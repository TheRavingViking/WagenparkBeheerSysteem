namespace WBS_Rev2
{
    partial class CarOverview
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
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Return_To_Main_Menu = new System.Windows.Forms.Button();
            this.Button_Edit_Car = new System.Windows.Forms.Button();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.LicenseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrandHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Delete_Car = new System.Windows.Forms.Button();
            this.Button_Filter_Car = new System.Windows.Forms.Button();
            this.Button_Reset_Filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Button_Return_To_Main_Menu
            // 
            this.Button_Return_To_Main_Menu.Location = new System.Drawing.Point(12, 509);
            this.Button_Return_To_Main_Menu.Name = "Button_Return_To_Main_Menu";
            this.Button_Return_To_Main_Menu.Size = new System.Drawing.Size(212, 61);
            this.Button_Return_To_Main_Menu.TabIndex = 4;
            this.Button_Return_To_Main_Menu.Text = "Return";
            this.Button_Return_To_Main_Menu.UseVisualStyleBackColor = true;
            this.Button_Return_To_Main_Menu.Click += new System.EventHandler(this.ReturnToMainMenuFromCarList_Click);
            // 
            // Button_Edit_Car
            // 
            this.Button_Edit_Car.Location = new System.Drawing.Point(230, 509);
            this.Button_Edit_Car.Name = "Button_Edit_Car";
            this.Button_Edit_Car.Size = new System.Drawing.Size(212, 61);
            this.Button_Edit_Car.TabIndex = 4;
            this.Button_Edit_Car.Text = "Edit car";
            this.Button_Edit_Car.UseVisualStyleBackColor = true;
            this.Button_Edit_Car.Click += new System.EventHandler(this.EditCarClick);
            // 
            // listViewCar
            // 
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LicenseHeader,
            this.BrandHeader,
            this.modelHeader,
            this.ColorHeader});
            this.listViewCar.FullRowSelect = true;
            this.listViewCar.GridLines = true;
            this.listViewCar.Location = new System.Drawing.Point(12, 12);
            this.listViewCar.MultiSelect = false;
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(503, 424);
            this.listViewCar.TabIndex = 5;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            // 
            // LicenseHeader
            // 
            this.LicenseHeader.Text = "License";
            this.LicenseHeader.Width = 120;
            // 
            // BrandHeader
            // 
            this.BrandHeader.Text = "Brand";
            this.BrandHeader.Width = 120;
            // 
            // modelHeader
            // 
            this.modelHeader.Text = "Model";
            this.modelHeader.Width = 120;
            // 
            // ColorHeader
            // 
            this.ColorHeader.Text = "Color";
            this.ColorHeader.Width = 125;
            // 
            // Button_Delete_Car
            // 
            this.Button_Delete_Car.Location = new System.Drawing.Point(448, 446);
            this.Button_Delete_Car.Name = "Button_Delete_Car";
            this.Button_Delete_Car.Size = new System.Drawing.Size(67, 124);
            this.Button_Delete_Car.TabIndex = 7;
            this.Button_Delete_Car.Text = "Delete";
            this.Button_Delete_Car.UseVisualStyleBackColor = true;
            this.Button_Delete_Car.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Button_Filter_Car
            // 
            this.Button_Filter_Car.Location = new System.Drawing.Point(12, 446);
            this.Button_Filter_Car.Name = "Button_Filter_Car";
            this.Button_Filter_Car.Size = new System.Drawing.Size(212, 57);
            this.Button_Filter_Car.TabIndex = 8;
            this.Button_Filter_Car.Text = "Filter ( karim dit is onze linq)";
            this.Button_Filter_Car.UseVisualStyleBackColor = true;
            this.Button_Filter_Car.Click += new System.EventHandler(this.FilterCar);
            // 
            // Button_Reset_Filter
            // 
            this.Button_Reset_Filter.Location = new System.Drawing.Point(230, 446);
            this.Button_Reset_Filter.Name = "Button_Reset_Filter";
            this.Button_Reset_Filter.Size = new System.Drawing.Size(212, 57);
            this.Button_Reset_Filter.TabIndex = 9;
            this.Button_Reset_Filter.Text = "Reset Filter";
            this.Button_Reset_Filter.UseVisualStyleBackColor = true;
            this.Button_Reset_Filter.Click += new System.EventHandler(this.Button_Reset_Filter_Click);
            // 
            // CarOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 582);
            this.Controls.Add(this.Button_Reset_Filter);
            this.Controls.Add(this.Button_Filter_Car);
            this.Controls.Add(this.Button_Delete_Car);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.Button_Edit_Car);
            this.Controls.Add(this.Button_Return_To_Main_Menu);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarOverview";
            this.Text = "CarList";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Return_To_Main_Menu;
        private System.Windows.Forms.Button Button_Edit_Car;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.ColumnHeader LicenseHeader;
        private System.Windows.Forms.ColumnHeader BrandHeader;
        private System.Windows.Forms.ColumnHeader modelHeader;
        private System.Windows.Forms.ColumnHeader ColorHeader;
        private System.Windows.Forms.Button Button_Delete_Car;
        private System.Windows.Forms.Button Button_Filter_Car;
        private System.Windows.Forms.Button Button_Reset_Filter;
    }
}