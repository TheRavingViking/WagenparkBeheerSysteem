namespace WBS_Rev2
{
    partial class WbsMainForm
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
            this.Button_Add_Car = new System.Windows.Forms.Button();
            this.Button_Person_List = new System.Windows.Forms.Button();
            this.Button_Car_List = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Add_Person = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectFleet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedFleet = new System.Windows.Forms.Label();
            this.label_fleet = new System.Windows.Forms.Label();
            this.cb_Fleet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Add_Car
            // 
            this.Button_Add_Car.Location = new System.Drawing.Point(395, 328);
            this.Button_Add_Car.Name = "Button_Add_Car";
            this.Button_Add_Car.Size = new System.Drawing.Size(149, 39);
            this.Button_Add_Car.TabIndex = 5;
            this.Button_Add_Car.Text = "Add car";
            this.Button_Add_Car.UseVisualStyleBackColor = true;
            this.Button_Add_Car.Click += new System.EventHandler(this.AddCarButtonClick);
            // 
            // Button_Person_List
            // 
            this.Button_Person_List.Location = new System.Drawing.Point(240, 328);
            this.Button_Person_List.Name = "Button_Person_List";
            this.Button_Person_List.Size = new System.Drawing.Size(149, 39);
            this.Button_Person_List.TabIndex = 4;
            this.Button_Person_List.Text = "Person list";
            this.Button_Person_List.UseVisualStyleBackColor = true;
            this.Button_Person_List.Click += new System.EventHandler(this.PersonListClick);
            // 
            // Button_Car_List
            // 
            this.Button_Car_List.Location = new System.Drawing.Point(85, 328);
            this.Button_Car_List.Name = "Button_Car_List";
            this.Button_Car_List.Size = new System.Drawing.Size(149, 39);
            this.Button_Car_List.TabIndex = 3;
            this.Button_Car_List.Text = "Car list";
            this.Button_Car_List.UseVisualStyleBackColor = true;
            this.Button_Car_List.Click += new System.EventHandler(this.CarListClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WBS_Rev2.Properties.Resources.wbs_logov2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Add_Person
            // 
            this.Button_Add_Person.Location = new System.Drawing.Point(550, 328);
            this.Button_Add_Person.Name = "Button_Add_Person";
            this.Button_Add_Person.Size = new System.Drawing.Size(149, 39);
            this.Button_Add_Person.TabIndex = 1;
            this.Button_Add_Person.Text = "Add person";
            this.Button_Add_Person.UseVisualStyleBackColor = true;
            this.Button_Add_Person.Click += new System.EventHandler(this.AddPersonButtonClick);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(188, 247);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(417, 50);
            this.label30.TabIndex = 0;
            this.label30.Text = "Welcome at WBS\r\nThe car park manage system of the future.\r\n";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelectFleet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelectedFleet);
            this.panel1.Controls.Add(this.label_fleet);
            this.panel1.Controls.Add(this.cb_Fleet);
            this.panel1.Controls.Add(this.Button_Add_Car);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Button_Person_List);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.Button_Car_List);
            this.panel1.Controls.Add(this.Button_Add_Person);
            this.panel1.Location = new System.Drawing.Point(45, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 428);
            this.panel1.TabIndex = 71;
            // 
            // SelectFleet
            // 
            this.SelectFleet.Location = new System.Drawing.Point(206, 11);
            this.SelectFleet.Name = "SelectFleet";
            this.SelectFleet.Size = new System.Drawing.Size(75, 23);
            this.SelectFleet.TabIndex = 10;
            this.SelectFleet.Text = "Select Fleet";
            this.SelectFleet.UseVisualStyleBackColor = true;
            this.SelectFleet.Click += new System.EventHandler(this.SelectFleet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Fleet:";
            // 
            // SelectedFleet
            // 
            this.SelectedFleet.AutoSize = true;
            this.SelectedFleet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFleet.Location = new System.Drawing.Point(413, 380);
            this.SelectedFleet.Name = "SelectedFleet";
            this.SelectedFleet.Size = new System.Drawing.Size(49, 24);
            this.SelectedFleet.TabIndex = 8;
            this.SelectedFleet.Text = "fleet";
            // 
            // label_fleet
            // 
            this.label_fleet.AutoSize = true;
            this.label_fleet.Location = new System.Drawing.Point(8, 16);
            this.label_fleet.Name = "label_fleet";
            this.label_fleet.Size = new System.Drawing.Size(65, 13);
            this.label_fleet.TabIndex = 7;
            this.label_fleet.Text = "Select WBS";
            // 
            // cb_Fleet
            // 
            this.cb_Fleet.FormattingEnabled = true;
            this.cb_Fleet.Location = new System.Drawing.Point(79, 13);
            this.cb_Fleet.Name = "cb_Fleet";
            this.cb_Fleet.Size = new System.Drawing.Size(121, 21);
            this.cb_Fleet.TabIndex = 6;
            this.cb_Fleet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_slectedFleet_KeyPress);
            // 
            // WbsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WBS_Rev2.Properties.Resources.A_car_park_taken_from_abo_008;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 499);
            this.Controls.Add(this.panel1);
            this.Name = "WbsMainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.WbsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button Button_Add_Person;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Car_List;
        private System.Windows.Forms.Button Button_Add_Car;
        private System.Windows.Forms.Button Button_Person_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fleet;
        private System.Windows.Forms.ComboBox cb_Fleet;
        private System.Windows.Forms.Label SelectedFleet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectFleet;
    }
}

