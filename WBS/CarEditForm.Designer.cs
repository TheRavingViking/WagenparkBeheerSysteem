namespace WBS
{
    partial class CarEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_mileage = new System.Windows.Forms.NumericUpDown();
            this.textBox_manufacturingDate = new System.Windows.Forms.NumericUpDown();
            this.textBox_ApkDate = new System.Windows.Forms.NumericUpDown();
            this.textBox_BHP = new System.Windows.Forms.NumericUpDown();
            this.textBox_seats = new System.Windows.Forms.NumericUpDown();
            this.textBox_wheels = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_fuel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_catagory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_drivetrain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Latitude = new System.Windows.Forms.Label();
            this.textBox_Latitude = new System.Windows.Forms.TextBox();
            this.textBox_Longitude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_update_gps = new System.Windows.Forms.Button();
            this.button_show_on_map = new System.Windows.Forms.Button();
            this.button_car_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_mileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_manufacturingDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_ApkDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_BHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_wheels)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_mileage);
            this.groupBox1.Controls.Add(this.textBox_manufacturingDate);
            this.groupBox1.Controls.Add(this.textBox_ApkDate);
            this.groupBox1.Controls.Add(this.textBox_BHP);
            this.groupBox1.Controls.Add(this.textBox_seats);
            this.groupBox1.Controls.Add(this.textBox_wheels);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_fuel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_catagory);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_model);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_brand);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_license);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.textBox_color);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_drivetrain);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(273, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car";
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.Location = new System.Drawing.Point(94, 280);
            this.textBox_mileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(170, 20);
            this.textBox_mileage.TabIndex = 116;
            // 
            // textBox_manufacturingDate
            // 
            this.textBox_manufacturingDate.Location = new System.Drawing.Point(94, 170);
            this.textBox_manufacturingDate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textBox_manufacturingDate.Name = "textBox_manufacturingDate";
            this.textBox_manufacturingDate.Size = new System.Drawing.Size(170, 20);
            this.textBox_manufacturingDate.TabIndex = 115;
            this.textBox_manufacturingDate.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // textBox_ApkDate
            // 
            this.textBox_ApkDate.Location = new System.Drawing.Point(94, 128);
            this.textBox_ApkDate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textBox_ApkDate.Name = "textBox_ApkDate";
            this.textBox_ApkDate.Size = new System.Drawing.Size(170, 20);
            this.textBox_ApkDate.TabIndex = 114;
            this.textBox_ApkDate.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // textBox_BHP
            // 
            this.textBox_BHP.Location = new System.Drawing.Point(94, 105);
            this.textBox_BHP.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.textBox_BHP.Name = "textBox_BHP";
            this.textBox_BHP.Size = new System.Drawing.Size(170, 20);
            this.textBox_BHP.TabIndex = 113;
            this.textBox_BHP.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // textBox_seats
            // 
            this.textBox_seats.Location = new System.Drawing.Point(94, 63);
            this.textBox_seats.Name = "textBox_seats";
            this.textBox_seats.Size = new System.Drawing.Size(170, 20);
            this.textBox_seats.TabIndex = 112;
            this.textBox_seats.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textBox_wheels
            // 
            this.textBox_wheels.Location = new System.Drawing.Point(94, 40);
            this.textBox_wheels.Name = "textBox_wheels";
            this.textBox_wheels.Size = new System.Drawing.Size(170, 20);
            this.textBox_wheels.TabIndex = 111;
            this.textBox_wheels.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(157, 304);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 109;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Right";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(99, 303);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 108;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Left";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 107;
            this.label15.Text = "Steering wheel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 106;
            this.label14.Text = "Mileage:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 105;
            this.label11.Text = "Fuel type:";
            // 
            // textBox_fuel
            // 
            this.textBox_fuel.AutoCompleteCustomSource.AddRange(new string[] {
            "Gasoline",
            "Diesel",
            "LPG"});
            this.textBox_fuel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_fuel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_fuel.Location = new System.Drawing.Point(94, 258);
            this.textBox_fuel.Name = "textBox_fuel";
            this.textBox_fuel.Size = new System.Drawing.Size(170, 20);
            this.textBox_fuel.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Category:";
            // 
            // textBox_catagory
            // 
            this.textBox_catagory.Location = new System.Drawing.Point(94, 235);
            this.textBox_catagory.Name = "textBox_catagory";
            this.textBox_catagory.Size = new System.Drawing.Size(170, 20);
            this.textBox_catagory.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Type/model:";
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(94, 213);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(170, 20);
            this.textBox_model.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Brand:";
            // 
            // textBox_brand
            // 
            this.textBox_brand.Location = new System.Drawing.Point(94, 191);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(170, 20);
            this.textBox_brand.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Plate nr:";
            // 
            // textBox_license
            // 
            this.textBox_license.Location = new System.Drawing.Point(94, 150);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.Size = new System.Drawing.Size(170, 20);
            this.textBox_license.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Colour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "APK:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 174);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 110;
            this.label29.Text = "Build year:";
            // 
            // textBox_color
            // 
            this.textBox_color.Location = new System.Drawing.Point(94, 18);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(170, 20);
            this.textBox_color.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "BHP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Drivetrain:";
            // 
            // textBox_drivetrain
            // 
            this.textBox_drivetrain.Location = new System.Drawing.Point(94, 83);
            this.textBox_drivetrain.Name = "textBox_drivetrain";
            this.textBox_drivetrain.Size = new System.Drawing.Size(170, 20);
            this.textBox_drivetrain.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Wheels:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Seats:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Latitude);
            this.groupBox2.Controls.Add(this.textBox_Latitude);
            this.groupBox2.Controls.Add(this.textBox_Longitude);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button_update_gps);
            this.groupBox2.Controls.Add(this.button_show_on_map);
            this.groupBox2.Location = new System.Drawing.Point(9, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(273, 116);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPS Location";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(5, 23);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(48, 13);
            this.Latitude.TabIndex = 29;
            this.Latitude.Text = "Latitude:";
            // 
            // textBox_Latitude
            // 
            this.textBox_Latitude.Enabled = false;
            this.textBox_Latitude.Location = new System.Drawing.Point(82, 19);
            this.textBox_Latitude.Name = "textBox_Latitude";
            this.textBox_Latitude.Size = new System.Drawing.Size(170, 20);
            this.textBox_Latitude.TabIndex = 28;
            // 
            // textBox_Longitude
            // 
            this.textBox_Longitude.Enabled = false;
            this.textBox_Longitude.Location = new System.Drawing.Point(82, 41);
            this.textBox_Longitude.Name = "textBox_Longitude";
            this.textBox_Longitude.Size = new System.Drawing.Size(170, 20);
            this.textBox_Longitude.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Longitude:";
            // 
            // button_update_gps
            // 
            this.button_update_gps.Location = new System.Drawing.Point(8, 69);
            this.button_update_gps.Margin = new System.Windows.Forms.Padding(2);
            this.button_update_gps.Name = "button_update_gps";
            this.button_update_gps.Size = new System.Drawing.Size(111, 35);
            this.button_update_gps.TabIndex = 71;
            this.button_update_gps.Text = "Edit";
            this.button_update_gps.UseVisualStyleBackColor = false;
            this.button_update_gps.Click += new System.EventHandler(this.button_update_gps_Click);
            // 
            // button_show_on_map
            // 
            this.button_show_on_map.Location = new System.Drawing.Point(141, 69);
            this.button_show_on_map.Margin = new System.Windows.Forms.Padding(2);
            this.button_show_on_map.Name = "button_show_on_map";
            this.button_show_on_map.Size = new System.Drawing.Size(111, 35);
            this.button_show_on_map.TabIndex = 71;
            this.button_show_on_map.Text = "Show on map";
            this.button_show_on_map.UseVisualStyleBackColor = false;
            this.button_show_on_map.Click += new System.EventHandler(this.button_show_on_map_Click);
            // 
            // button_car_submit
            // 
            this.button_car_submit.Location = new System.Drawing.Point(171, 496);
            this.button_car_submit.Name = "button_car_submit";
            this.button_car_submit.Size = new System.Drawing.Size(111, 38);
            this.button_car_submit.TabIndex = 92;
            this.button_car_submit.Text = "Save/close";
            this.button_car_submit.UseVisualStyleBackColor = true;
            this.button_car_submit.Click += new System.EventHandler(this.SaveCloseClick);
            // 
            // CarEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 544);
            this.Controls.Add(this.button_car_submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarEditForm";
            this.Text = "CarEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_mileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_manufacturingDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_ApkDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_BHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_wheels)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown textBox_mileage;
        private System.Windows.Forms.NumericUpDown textBox_manufacturingDate;
        private System.Windows.Forms.NumericUpDown textBox_ApkDate;
        private System.Windows.Forms.NumericUpDown textBox_BHP;
        private System.Windows.Forms.NumericUpDown textBox_seats;
        private System.Windows.Forms.NumericUpDown textBox_wheels;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_fuel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_catagory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_drivetrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.TextBox textBox_Latitude;
        private System.Windows.Forms.TextBox textBox_Longitude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_update_gps;
        private System.Windows.Forms.Button button_show_on_map;
        private System.Windows.Forms.Button button_car_submit;
    }
}