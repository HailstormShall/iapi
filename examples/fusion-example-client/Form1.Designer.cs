﻿namespace FusionExampleClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fallingTB = new System.Windows.Forms.TextBox();
            this.risingTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serverConnectedTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.instrumentConnectedTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.instrumentIdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.instrumentNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.systemStateTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.systemModeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.syringeStatusTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.flowrateRB = new System.Windows.Forms.Label();
            this.volumeRB = new System.Windows.Forms.Label();
            this.diamterRB = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rawfileTB = new System.Windows.Forms.TextBox();
            this.methodBrowse = new System.Windows.Forms.Button();
            this.methodTB = new System.Windows.Forms.TextBox();
            this.numberOfMinutesUD = new System.Windows.Forms.NumericUpDown();
            this.numberOfScansUD = new System.Windows.Forms.NumericUpDown();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.openMethodDialog = new System.Windows.Forms.OpenFileDialog();
            this.rawfileDialogSave = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMinutesUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScansUD)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Online Access";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dispose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "GetInstrumentAccess";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "GetScanContainer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(337, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Scans Arrived";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "OffMode";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "OnMode";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(511, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 244);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.serverConnectedTB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.instrumentConnectedTB);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.instrumentIdTB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.instrumentNameTB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.systemStateTB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.systemModeTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ReadBacks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.fallingTB);
            this.groupBox2.Controls.Add(this.risingTB);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(315, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 82);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Closure Events";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Rising Edges";
            // 
            // fallingTB
            // 
            this.fallingTB.Location = new System.Drawing.Point(97, 51);
            this.fallingTB.Name = "fallingTB";
            this.fallingTB.Size = new System.Drawing.Size(100, 20);
            this.fallingTB.TabIndex = 25;
            // 
            // risingTB
            // 
            this.risingTB.Location = new System.Drawing.Point(97, 26);
            this.risingTB.Name = "risingTB";
            this.risingTB.Size = new System.Drawing.Size(100, 20);
            this.risingTB.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Falling Edges";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ready To Receive Next Scan";
            // 
            // serverConnectedTB
            // 
            this.serverConnectedTB.Location = new System.Drawing.Point(110, 7);
            this.serverConnectedTB.Name = "serverConnectedTB";
            this.serverConnectedTB.Size = new System.Drawing.Size(100, 20);
            this.serverConnectedTB.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Server Connected";
            // 
            // instrumentConnectedTB
            // 
            this.instrumentConnectedTB.Location = new System.Drawing.Point(427, 63);
            this.instrumentConnectedTB.Name = "instrumentConnectedTB";
            this.instrumentConnectedTB.Size = new System.Drawing.Size(100, 20);
            this.instrumentConnectedTB.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Instrument Connected";
            // 
            // instrumentIdTB
            // 
            this.instrumentIdTB.Location = new System.Drawing.Point(427, 36);
            this.instrumentIdTB.Name = "instrumentIdTB";
            this.instrumentIdTB.Size = new System.Drawing.Size(100, 20);
            this.instrumentIdTB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Instrument ID";
            // 
            // instrumentNameTB
            // 
            this.instrumentNameTB.Location = new System.Drawing.Point(427, 10);
            this.instrumentNameTB.Name = "instrumentNameTB";
            this.instrumentNameTB.Size = new System.Drawing.Size(100, 20);
            this.instrumentNameTB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Instrument Name";
            // 
            // systemStateTB
            // 
            this.systemStateTB.Location = new System.Drawing.Point(110, 62);
            this.systemStateTB.Name = "systemStateTB";
            this.systemStateTB.Size = new System.Drawing.Size(100, 20);
            this.systemStateTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "System State";
            // 
            // systemModeTB
            // 
            this.systemModeTB.Location = new System.Drawing.Point(110, 36);
            this.systemModeTB.Name = "systemModeTB";
            this.systemModeTB.Size = new System.Drawing.Size(100, 20);
            this.systemModeTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "System Mode";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.syringeStatusTB);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.flowrateRB);
            this.tabPage2.Controls.Add(this.volumeRB);
            this.tabPage2.Controls.Add(this.diamterRB);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.numericUpDown3);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Syringe Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // syringeStatusTB
            // 
            this.syringeStatusTB.Enabled = false;
            this.syringeStatusTB.Location = new System.Drawing.Point(156, 117);
            this.syringeStatusTB.Name = "syringeStatusTB";
            this.syringeStatusTB.Size = new System.Drawing.Size(100, 20);
            this.syringeStatusTB.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(113, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Status";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(20, 168);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 11;
            this.button16.Text = "Toggle";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(20, 139);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 10;
            this.button15.Text = "Stop";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(20, 110);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 9;
            this.button14.Text = "Start";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // flowrateRB
            // 
            this.flowrateRB.AutoSize = true;
            this.flowrateRB.Location = new System.Drawing.Point(211, 77);
            this.flowrateRB.Name = "flowrateRB";
            this.flowrateRB.Size = new System.Drawing.Size(55, 13);
            this.flowrateRB.TabIndex = 8;
            this.flowrateRB.Text = "Flow Rate";
            // 
            // volumeRB
            // 
            this.volumeRB.AutoSize = true;
            this.volumeRB.Location = new System.Drawing.Point(211, 51);
            this.volumeRB.Name = "volumeRB";
            this.volumeRB.Size = new System.Drawing.Size(42, 13);
            this.volumeRB.TabIndex = 7;
            this.volumeRB.Text = "Volume";
            // 
            // diamterRB
            // 
            this.diamterRB.AutoSize = true;
            this.diamterRB.Location = new System.Drawing.Point(211, 25);
            this.diamterRB.Name = "diamterRB";
            this.diamterRB.Size = new System.Drawing.Size(49, 13);
            this.diamterRB.TabIndex = 6;
            this.diamterRB.Text = "Diameter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Flow Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Volume";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Diameter";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Location = new System.Drawing.Point(85, 75);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(85, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(85, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(200, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Send Custom Scan";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 101);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Send Repeating Scan";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(200, 144);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Cancel Repeating Scan";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(200, 173);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Cancel Custom Scan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(337, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Running Number";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Running Number Set";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "Start Acquisition";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(242, 30);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "Stop Acquisition";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rawfileTB);
            this.groupBox1.Controls.Add(this.methodBrowse);
            this.groupBox1.Controls.Add(this.methodTB);
            this.groupBox1.Controls.Add(this.numberOfMinutesUD);
            this.groupBox1.Controls.Add(this.numberOfScansUD);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Location = new System.Drawing.Point(31, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 194);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acquisition Control";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(378, 166);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "Browse";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Rawfile";
            // 
            // rawfileTB
            // 
            this.rawfileTB.Location = new System.Drawing.Point(110, 168);
            this.rawfileTB.Name = "rawfileTB";
            this.rawfileTB.Size = new System.Drawing.Size(262, 20);
            this.rawfileTB.TabIndex = 29;
            // 
            // methodBrowse
            // 
            this.methodBrowse.Location = new System.Drawing.Point(378, 133);
            this.methodBrowse.Name = "methodBrowse";
            this.methodBrowse.Size = new System.Drawing.Size(75, 23);
            this.methodBrowse.TabIndex = 28;
            this.methodBrowse.Text = "Browse";
            this.methodBrowse.UseVisualStyleBackColor = true;
            this.methodBrowse.Click += new System.EventHandler(this.methodBrowse_Click);
            // 
            // methodTB
            // 
            this.methodTB.Location = new System.Drawing.Point(110, 135);
            this.methodTB.Name = "methodTB";
            this.methodTB.Size = new System.Drawing.Size(262, 20);
            this.methodTB.TabIndex = 27;
            // 
            // numberOfMinutesUD
            // 
            this.numberOfMinutesUD.DecimalPlaces = 2;
            this.numberOfMinutesUD.Location = new System.Drawing.Point(110, 109);
            this.numberOfMinutesUD.Name = "numberOfMinutesUD";
            this.numberOfMinutesUD.Size = new System.Drawing.Size(120, 20);
            this.numberOfMinutesUD.TabIndex = 26;
            this.numberOfMinutesUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numberOfScansUD
            // 
            this.numberOfScansUD.Location = new System.Drawing.Point(110, 86);
            this.numberOfScansUD.Name = "numberOfScansUD";
            this.numberOfScansUD.Size = new System.Drawing.Size(120, 20);
            this.numberOfScansUD.TabIndex = 25;
            this.numberOfScansUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 132);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Method";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.acqCheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Minutes";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.acqCheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "# of Scans";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.acqCheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Continuous";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.acqCheckedChanged);
            // 
            // openMethodDialog
            // 
            this.openMethodDialog.Filter = "Method|*.meth";
            this.openMethodDialog.InitialDirectory = "C:\\Xcalibur\\methods";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(511, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 195);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 559);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfMinutesUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScansUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox systemModeTB;
        private System.Windows.Forms.TextBox systemStateTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox instrumentIdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox instrumentNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instrumentConnectedTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverConnectedTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button methodBrowse;
        private System.Windows.Forms.TextBox methodTB;
        private System.Windows.Forms.NumericUpDown numberOfMinutesUD;
        private System.Windows.Forms.NumericUpDown numberOfScansUD;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rawfileTB;
        private System.Windows.Forms.OpenFileDialog openMethodDialog;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.SaveFileDialog rawfileDialogSave;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label flowrateRB;
        private System.Windows.Forms.Label volumeRB;
        private System.Windows.Forms.Label diamterRB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox syringeStatusTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox fallingTB;
        private System.Windows.Forms.TextBox risingTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

