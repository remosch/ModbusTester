namespace ModbusTester
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.DataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxRedLamp = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBoxYellowLamp = new System.Windows.Forms.ComboBox();
            this.comboBoxGreenLamp = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBoxBlueLamp = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBoxWhiteLamp = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.comboBoxSounder = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to Modbus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "FC1 Read Coils [16 Outputs]";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.readOutputs_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "FC2 Read Discrete [16 Inputs]";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.readInputs_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "Read Single Coil [1 Output]";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.readSingleCoil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Output 1 - Stacklight (Red)";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "512 - Output 1 - Stacklight (Red)",
            "513 - Output 2 - Stacklight (Yellow)",
            "514 - Output 3 - Stacklight (Green)",
            "515 - Output 4 - Stacklight (Blue)",
            "516 - Output 5 - Stacklight (White)",
            "517 - Output 6 - Stacklight (Audible Alarm)",
            "518 - Output 7 - Not Assigned",
            "519 - Output 8 - Not Assigned",
            "520 - Output 9 - Customer Output 1",
            "521 - Output 10 - Customer Output 2",
            "522 - Output 11 - Customer Output 3",
            "523 - Output 12 - Customer Output 4",
            "524 - Output 13 - ECS Output 1",
            "525 - Output 14 - ECS Output 2",
            "526 - Output 15 - ECS Output 3",
            "527 - Output 16 - ECS Output 4"});
            this.comboBox1.Location = new System.Drawing.Point(223, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(445, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 22);
            this.textBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "Write Single Coil [1 Output]";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Output 1 - Stacklight (Red)";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox2.Location = new System.Drawing.Point(223, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Tag = "Output 1 - Stacklight (Red)";
            this.comboBox2.ValueMember = "Output 1 - Stacklight (Red)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(445, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 22);
            this.textBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "Output 1 - Stacklight (Red)";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Items.AddRange(new object[] {
            "0 - Input1 - Tile Sensor",
            "1 - Input2 - UPS Alarm (Env. Monitoring)",
            "2 - Input3 - UPS Alarm (LED Lighting)",
            "3 - Input4 - Not Assigned",
            "4 - Input5 - Customer Input 1",
            "5 - Input6 - Customer Input 2",
            "6 - Input7 - Customer Input 3",
            "7 - Input8 - Customer Input 4",
            "8 - Input9 - ECS Input 1",
            "9 - Input10 - ECS Input 2",
            "10 - Input11 - ECS Input 3",
            "11 - Input12 - ECS Input 4",
            "12 - Input13 - Not Assigned",
            "13 - Input14 - Not Assigned",
            "14 - Input15 - Not Assigned",
            "15 - Input16 - Not Assigned            "});
            this.comboBox3.Location = new System.Drawing.Point(223, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 24);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Tag = "";
            this.toolTip1.SetToolTip(this.comboBox3, "Select input");
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 31);
            this.button6.TabIndex = 9;
            this.button6.Text = "Read Single Discrete [1 Input]";
            this.toolTip1.SetToolTip(this.button6, "Select requested input and click this button to read input state");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataType,
            this.Value});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 167);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(325, 347);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DataType
            // 
            this.DataType.Text = "Data Type / Description";
            this.DataType.Width = 255;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 130;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 386);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modbus IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "TCP Port (default 502)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(349, 435);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 22);
            this.textBox4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Read Timeout (default 1000 ms)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(349, 489);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 22);
            this.textBox5.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(344, 253);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(210, 31);
            this.button7.TabIndex = 20;
            this.button7.Text = "FC15 Write Coils [16 Outputs]";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.writeMultipleCoils_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Modbus / El. Drawing / Label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Modbus / El. Drawing / Label";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(622, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 21);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Test Red Lamp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxRedLamp
            // 
            this.comboBoxRedLamp.DisplayMember = "Off";
            this.comboBoxRedLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRedLamp.FormattingEnabled = true;
            this.comboBoxRedLamp.Items.AddRange(new object[] {
            "Off",
            "On",
            "Flashing"});
            this.comboBoxRedLamp.Location = new System.Drawing.Point(622, 39);
            this.comboBoxRedLamp.Name = "comboBoxRedLamp";
            this.comboBoxRedLamp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRedLamp.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(622, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 21);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Test Yellow Lamp";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBoxYellowLamp
            // 
            this.comboBoxYellowLamp.DisplayMember = "Off";
            this.comboBoxYellowLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYellowLamp.FormattingEnabled = true;
            this.comboBoxYellowLamp.Items.AddRange(new object[] {
            "Off",
            "On",
            "Flashing"});
            this.comboBoxYellowLamp.Location = new System.Drawing.Point(622, 110);
            this.comboBoxYellowLamp.Name = "comboBoxYellowLamp";
            this.comboBoxYellowLamp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYellowLamp.TabIndex = 27;
            // 
            // comboBoxGreenLamp
            // 
            this.comboBoxGreenLamp.DisplayMember = "Off";
            this.comboBoxGreenLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGreenLamp.FormattingEnabled = true;
            this.comboBoxGreenLamp.Items.AddRange(new object[] {
            "Off",
            "On",
            "Flashing"});
            this.comboBoxGreenLamp.Location = new System.Drawing.Point(622, 178);
            this.comboBoxGreenLamp.Name = "comboBoxGreenLamp";
            this.comboBoxGreenLamp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGreenLamp.TabIndex = 29;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(622, 151);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 21);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Test Green Lamp";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBoxBlueLamp
            // 
            this.comboBoxBlueLamp.DisplayMember = "Off";
            this.comboBoxBlueLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlueLamp.FormattingEnabled = true;
            this.comboBoxBlueLamp.Items.AddRange(new object[] {
            "Off",
            "On",
            "Flashing"});
            this.comboBoxBlueLamp.Location = new System.Drawing.Point(622, 247);
            this.comboBoxBlueLamp.Name = "comboBoxBlueLamp";
            this.comboBoxBlueLamp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBlueLamp.TabIndex = 31;
            this.comboBoxBlueLamp.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(622, 220);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(129, 21);
            this.checkBox4.TabIndex = 30;
            this.checkBox4.Text = "Test Blue Lamp";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // comboBoxWhiteLamp
            // 
            this.comboBoxWhiteLamp.DisplayMember = "Off";
            this.comboBoxWhiteLamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhiteLamp.FormattingEnabled = true;
            this.comboBoxWhiteLamp.Items.AddRange(new object[] {
            "Off",
            "On",
            "Flashing"});
            this.comboBoxWhiteLamp.Location = new System.Drawing.Point(622, 315);
            this.comboBoxWhiteLamp.Name = "comboBoxWhiteLamp";
            this.comboBoxWhiteLamp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWhiteLamp.TabIndex = 33;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(622, 288);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(137, 21);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "Test White Lamp";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // comboBoxSounder
            // 
            this.comboBoxSounder.DisplayMember = "Off";
            this.comboBoxSounder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSounder.FormattingEnabled = true;
            this.comboBoxSounder.Items.AddRange(new object[] {
            "Off",
            "On",
            "Pulse"});
            this.comboBoxSounder.Location = new System.Drawing.Point(622, 384);
            this.comboBoxSounder.Name = "comboBoxSounder";
            this.comboBoxSounder.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSounder.TabIndex = 35;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(622, 357);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(156, 21);
            this.checkBox6.TabIndex = 34;
            this.checkBox6.Text = "Test Sounder Alarm";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 528);
            this.Controls.Add(this.comboBoxSounder);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.comboBoxWhiteLamp);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.comboBoxBlueLamp);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.comboBoxGreenLamp);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.comboBoxYellowLamp);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.comboBoxRedLamp);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ModbusTester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DataType;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxRedLamp;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBoxYellowLamp;
        private System.Windows.Forms.ComboBox comboBoxGreenLamp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBoxBlueLamp;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBoxWhiteLamp;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox comboBoxSounder;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

