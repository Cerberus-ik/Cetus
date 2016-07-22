namespace Cetus
{
    partial class cetusForm
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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panelControl = new System.Windows.Forms.Panel();
			this.minimapPictureBox = new System.Windows.Forms.PictureBox();
			this.btnMoveCameraHome = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.checkBoxEnergyMode = new System.Windows.Forms.CheckBox();
			this.checkBoxFollowAmeise = new System.Windows.Forms.CheckBox();
			this.checkBoxDrawMinimap = new System.Windows.Forms.CheckBox();
			this.checkBoxSaveIfFinished = new System.Windows.Forms.CheckBox();
			this.checkBoxAutoCenter = new System.Windows.Forms.CheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnApply = new System.Windows.Forms.Button();
			this.txtBoxWidth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Fieldsize = new System.Windows.Forms.Label();
			this.txtBoxHeight = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBoxPixelsPerField = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBarScalingLevel = new System.Windows.Forms.TrackBar();
			this.txtBoxScalingLevel = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnRandomise = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBarFieldPercent = new System.Windows.Forms.TrackBar();
			this.txtBoxSliderFieldPercent = new System.Windows.Forms.TextBox();
			this.btnRandomAmeisenPosition = new System.Windows.Forms.Button();
			this.btnResetCustomField = new System.Windows.Forms.Button();
			this.btnAmeisePosition = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnSwitchColor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBoxX = new System.Windows.Forms.TextBox();
			this.PosY = new System.Windows.Forms.Label();
			this.txtBoxY = new System.Windows.Forms.TextBox();
			this.PosX = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.sliderSpeed = new System.Windows.Forms.TrackBar();
			this.txtBoxSliderValue = new System.Windows.Forms.TextBox();
			this.rdBtnLive = new System.Windows.Forms.RadioButton();
			this.rdBtnFast = new System.Windows.Forms.RadioButton();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.drawingPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minimapPictureBox)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScalingLevel)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFieldPercent)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSpeed)).BeginInit();
			this.drawingPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
			this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox.Location = new System.Drawing.Point(10, 10);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(324, 234);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 8;
			this.pictureBox.TabStop = false;
			// 
			// panelControl
			// 
			this.panelControl.AutoScroll = true;
			this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelControl.Controls.Add(this.minimapPictureBox);
			this.panelControl.Controls.Add(this.btnMoveCameraHome);
			this.panelControl.Controls.Add(this.panel2);
			this.panelControl.Controls.Add(this.panel3);
			this.panelControl.Controls.Add(this.panel6);
			this.panelControl.Controls.Add(this.panel5);
			this.panelControl.Controls.Add(this.btnRandomAmeisenPosition);
			this.panelControl.Controls.Add(this.btnResetCustomField);
			this.panelControl.Controls.Add(this.btnAmeisePosition);
			this.panelControl.Controls.Add(this.panel4);
			this.panelControl.Controls.Add(this.btnStart);
			this.panelControl.Controls.Add(this.btnReset);
			this.panelControl.Controls.Add(this.panel1);
			this.panelControl.Controls.Add(this.btnStop);
			this.panelControl.Controls.Add(this.btnClear);
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelControl.Location = new System.Drawing.Point(716, 3);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(312, 596);
			this.panelControl.TabIndex = 12;
			// 
			// minimapPictureBox
			// 
			this.minimapPictureBox.Location = new System.Drawing.Point(17, 70);
			this.minimapPictureBox.Name = "minimapPictureBox";
			this.minimapPictureBox.Size = new System.Drawing.Size(279, 142);
			this.minimapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.minimapPictureBox.TabIndex = 18;
			this.minimapPictureBox.TabStop = false;
			// 
			// btnMoveCameraHome
			// 
			this.btnMoveCameraHome.Location = new System.Drawing.Point(13, 41);
			this.btnMoveCameraHome.Name = "btnMoveCameraHome";
			this.btnMoveCameraHome.Size = new System.Drawing.Size(68, 23);
			this.btnMoveCameraHome.TabIndex = 17;
			this.btnMoveCameraHome.Text = "Center Cm.";
			this.btnMoveCameraHome.UseVisualStyleBackColor = true;
			this.btnMoveCameraHome.Click += new System.EventHandler(this.btnMoveCameraHome_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.checkBoxEnergyMode);
			this.panel2.Controls.Add(this.checkBoxFollowAmeise);
			this.panel2.Controls.Add(this.checkBoxDrawMinimap);
			this.panel2.Controls.Add(this.checkBoxSaveIfFinished);
			this.panel2.Controls.Add(this.checkBoxAutoCenter);
			this.panel2.Location = new System.Drawing.Point(162, 463);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(133, 122);
			this.panel2.TabIndex = 16;
			// 
			// checkBoxEnergyMode
			// 
			this.checkBoxEnergyMode.AutoSize = true;
			this.checkBoxEnergyMode.Location = new System.Drawing.Point(10, 97);
			this.checkBoxEnergyMode.Name = "checkBoxEnergyMode";
			this.checkBoxEnergyMode.Size = new System.Drawing.Size(89, 17);
			this.checkBoxEnergyMode.TabIndex = 4;
			this.checkBoxEnergyMode.Text = "Energy Mode";
			this.checkBoxEnergyMode.UseVisualStyleBackColor = true;
			// 
			// checkBoxFollowAmeise
			// 
			this.checkBoxFollowAmeise.AutoSize = true;
			this.checkBoxFollowAmeise.Location = new System.Drawing.Point(10, 74);
			this.checkBoxFollowAmeise.Name = "checkBoxFollowAmeise";
			this.checkBoxFollowAmeise.Size = new System.Drawing.Size(75, 17);
			this.checkBoxFollowAmeise.TabIndex = 3;
			this.checkBoxFollowAmeise.Text = "Follow Ant";
			this.checkBoxFollowAmeise.UseVisualStyleBackColor = true;
			// 
			// checkBoxDrawMinimap
			// 
			this.checkBoxDrawMinimap.AutoSize = true;
			this.checkBoxDrawMinimap.Checked = true;
			this.checkBoxDrawMinimap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDrawMinimap.Location = new System.Drawing.Point(10, 51);
			this.checkBoxDrawMinimap.Name = "checkBoxDrawMinimap";
			this.checkBoxDrawMinimap.Size = new System.Drawing.Size(101, 17);
			this.checkBoxDrawMinimap.TabIndex = 2;
			this.checkBoxDrawMinimap.Text = "Enable Minimap";
			this.checkBoxDrawMinimap.UseVisualStyleBackColor = true;
			// 
			// checkBoxSaveIfFinished
			// 
			this.checkBoxSaveIfFinished.AutoSize = true;
			this.checkBoxSaveIfFinished.Location = new System.Drawing.Point(10, 28);
			this.checkBoxSaveIfFinished.Name = "checkBoxSaveIfFinished";
			this.checkBoxSaveIfFinished.Size = new System.Drawing.Size(123, 17);
			this.checkBoxSaveIfFinished.TabIndex = 1;
			this.checkBoxSaveIfFinished.Text = "Save picture to a file";
			this.checkBoxSaveIfFinished.UseVisualStyleBackColor = true;
			// 
			// checkBoxAutoCenter
			// 
			this.checkBoxAutoCenter.AutoSize = true;
			this.checkBoxAutoCenter.Checked = true;
			this.checkBoxAutoCenter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoCenter.Location = new System.Drawing.Point(10, 5);
			this.checkBoxAutoCenter.Name = "checkBoxAutoCenter";
			this.checkBoxAutoCenter.Size = new System.Drawing.Size(81, 17);
			this.checkBoxAutoCenter.TabIndex = 0;
			this.checkBoxAutoCenter.Text = "Auto center";
			this.checkBoxAutoCenter.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.btnApply);
			this.panel3.Controls.Add(this.txtBoxWidth);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.Fieldsize);
			this.panel3.Controls.Add(this.txtBoxHeight);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(17, 218);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(133, 111);
			this.panel3.TabIndex = 15;
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(9, 77);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 16;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// txtBoxWidth
			// 
			this.txtBoxWidth.Location = new System.Drawing.Point(9, 25);
			this.txtBoxWidth.Name = "txtBoxWidth";
			this.txtBoxWidth.Size = new System.Drawing.Size(75, 20);
			this.txtBoxWidth.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(90, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Height";
			// 
			// Fieldsize
			// 
			this.Fieldsize.AutoSize = true;
			this.Fieldsize.Location = new System.Drawing.Point(3, 9);
			this.Fieldsize.Name = "Fieldsize";
			this.Fieldsize.Size = new System.Drawing.Size(50, 13);
			this.Fieldsize.TabIndex = 0;
			this.Fieldsize.Text = "Field size";
			// 
			// txtBoxHeight
			// 
			this.txtBoxHeight.Location = new System.Drawing.Point(9, 51);
			this.txtBoxHeight.Name = "txtBoxHeight";
			this.txtBoxHeight.Size = new System.Drawing.Size(75, 20);
			this.txtBoxHeight.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(90, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Width";
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.label8);
			this.panel6.Controls.Add(this.txtBoxPixelsPerField);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Controls.Add(this.trackBarScalingLevel);
			this.panel6.Controls.Add(this.txtBoxScalingLevel);
			this.panel6.Location = new System.Drawing.Point(17, 335);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(133, 122);
			this.panel6.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(49, 97);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Pixels per Field";
			// 
			// txtBoxPixelsPerField
			// 
			this.txtBoxPixelsPerField.Location = new System.Drawing.Point(9, 94);
			this.txtBoxPixelsPerField.Name = "txtBoxPixelsPerField";
			this.txtBoxPixelsPerField.Size = new System.Drawing.Size(33, 20);
			this.txtBoxPixelsPerField.TabIndex = 7;
			this.txtBoxPixelsPerField.Text = "1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(49, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Zoom Level";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Scale level";
			// 
			// trackBarScalingLevel
			// 
			this.trackBarScalingLevel.Location = new System.Drawing.Point(3, 21);
			this.trackBarScalingLevel.Maximum = 7;
			this.trackBarScalingLevel.Minimum = 1;
			this.trackBarScalingLevel.Name = "trackBarScalingLevel";
			this.trackBarScalingLevel.Size = new System.Drawing.Size(125, 45);
			this.trackBarScalingLevel.TabIndex = 2;
			this.trackBarScalingLevel.Value = 1;
			this.trackBarScalingLevel.Scroll += new System.EventHandler(this.trackBarZoomLevel_Scroll);
			// 
			// txtBoxScalingLevel
			// 
			this.txtBoxScalingLevel.Location = new System.Drawing.Point(9, 66);
			this.txtBoxScalingLevel.Name = "txtBoxScalingLevel";
			this.txtBoxScalingLevel.Size = new System.Drawing.Size(33, 20);
			this.txtBoxScalingLevel.TabIndex = 4;
			this.txtBoxScalingLevel.Text = "1";
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.btnRandomise);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.trackBarFieldPercent);
			this.panel5.Controls.Add(this.txtBoxSliderFieldPercent);
			this.panel5.Location = new System.Drawing.Point(162, 335);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(133, 122);
			this.panel5.TabIndex = 14;
			// 
			// btnRandomise
			// 
			this.btnRandomise.Location = new System.Drawing.Point(10, 92);
			this.btnRandomise.Name = "btnRandomise";
			this.btnRandomise.Size = new System.Drawing.Size(85, 23);
			this.btnRandomise.TabIndex = 14;
			this.btnRandomise.Text = "Randomise";
			this.btnRandomise.UseVisualStyleBackColor = true;
			this.btnRandomise.Click += new System.EventHandler(this.btnRandomise_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Black";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Randomise Fields";
			// 
			// trackBarFieldPercent
			// 
			this.trackBarFieldPercent.Location = new System.Drawing.Point(3, 21);
			this.trackBarFieldPercent.Maximum = 25;
			this.trackBarFieldPercent.Minimum = 1;
			this.trackBarFieldPercent.Name = "trackBarFieldPercent";
			this.trackBarFieldPercent.Size = new System.Drawing.Size(125, 45);
			this.trackBarFieldPercent.TabIndex = 7;
			this.trackBarFieldPercent.Value = 5;
			this.trackBarFieldPercent.Scroll += new System.EventHandler(this.trackBarFieldPercent_Scroll);
			// 
			// txtBoxSliderFieldPercent
			// 
			this.txtBoxSliderFieldPercent.Location = new System.Drawing.Point(10, 66);
			this.txtBoxSliderFieldPercent.Name = "txtBoxSliderFieldPercent";
			this.txtBoxSliderFieldPercent.Size = new System.Drawing.Size(46, 20);
			this.txtBoxSliderFieldPercent.TabIndex = 7;
			this.txtBoxSliderFieldPercent.Text = "5%";
			// 
			// btnRandomAmeisenPosition
			// 
			this.btnRandomAmeisenPosition.Location = new System.Drawing.Point(156, 41);
			this.btnRandomAmeisenPosition.Name = "btnRandomAmeisenPosition";
			this.btnRandomAmeisenPosition.Size = new System.Drawing.Size(68, 23);
			this.btnRandomAmeisenPosition.TabIndex = 15;
			this.btnRandomAmeisenPosition.Text = "Rdm. Am.";
			this.btnRandomAmeisenPosition.UseVisualStyleBackColor = true;
			this.btnRandomAmeisenPosition.Click += new System.EventHandler(this.btnRandomAmeisenPosition_Click);
			// 
			// btnResetCustomField
			// 
			this.btnResetCustomField.Location = new System.Drawing.Point(230, 12);
			this.btnResetCustomField.Name = "btnResetCustomField";
			this.btnResetCustomField.Size = new System.Drawing.Size(68, 23);
			this.btnResetCustomField.TabIndex = 13;
			this.btnResetCustomField.Text = "Reset Field";
			this.btnResetCustomField.UseVisualStyleBackColor = true;
			this.btnResetCustomField.Click += new System.EventHandler(this.btnResetCustomField_Click);
			// 
			// btnAmeisePosition
			// 
			this.btnAmeisePosition.Location = new System.Drawing.Point(85, 41);
			this.btnAmeisePosition.Name = "btnAmeisePosition";
			this.btnAmeisePosition.Size = new System.Drawing.Size(68, 23);
			this.btnAmeisePosition.TabIndex = 12;
			this.btnAmeisePosition.Text = "Home Am.";
			this.btnAmeisePosition.UseVisualStyleBackColor = true;
			this.btnAmeisePosition.Click += new System.EventHandler(this.btnAmeisePosition_Click);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.btnSwitchColor);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.txtBoxX);
			this.panel4.Controls.Add(this.PosY);
			this.panel4.Controls.Add(this.txtBoxY);
			this.panel4.Controls.Add(this.PosX);
			this.panel4.Location = new System.Drawing.Point(162, 218);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(133, 111);
			this.panel4.TabIndex = 13;
			// 
			// btnSwitchColor
			// 
			this.btnSwitchColor.Location = new System.Drawing.Point(10, 77);
			this.btnSwitchColor.Name = "btnSwitchColor";
			this.btnSwitchColor.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchColor.TabIndex = 15;
			this.btnSwitchColor.Text = "Switch Color";
			this.btnSwitchColor.UseVisualStyleBackColor = true;
			this.btnSwitchColor.Click += new System.EventHandler(this.btnSwitchColor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Switch Color of Fields";
			// 
			// txtBoxX
			// 
			this.txtBoxX.Location = new System.Drawing.Point(9, 25);
			this.txtBoxX.Name = "txtBoxX";
			this.txtBoxX.Size = new System.Drawing.Size(75, 20);
			this.txtBoxX.TabIndex = 8;
			// 
			// PosY
			// 
			this.PosY.AutoSize = true;
			this.PosY.Location = new System.Drawing.Point(93, 54);
			this.PosY.Name = "PosY";
			this.PosY.Size = new System.Drawing.Size(32, 13);
			this.PosY.TabIndex = 12;
			this.PosY.Text = "PosY";
			// 
			// txtBoxY
			// 
			this.txtBoxY.Location = new System.Drawing.Point(9, 51);
			this.txtBoxY.Name = "txtBoxY";
			this.txtBoxY.Size = new System.Drawing.Size(75, 20);
			this.txtBoxY.TabIndex = 9;
			// 
			// PosX
			// 
			this.PosX.AutoSize = true;
			this.PosX.Location = new System.Drawing.Point(93, 28);
			this.PosX.Name = "PosX";
			this.PosX.Size = new System.Drawing.Size(32, 13);
			this.PosX.TabIndex = 11;
			this.PosX.Text = "PosX";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(13, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(68, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(156, 12);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(68, 23);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "Reset Game";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.sliderSpeed);
			this.panel1.Controls.Add(this.txtBoxSliderValue);
			this.panel1.Controls.Add(this.rdBtnLive);
			this.panel1.Controls.Add(this.rdBtnFast);
			this.panel1.Location = new System.Drawing.Point(17, 463);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(133, 122);
			this.panel1.TabIndex = 13;
			// 
			// sliderSpeed
			// 
			this.sliderSpeed.Location = new System.Drawing.Point(1, 6);
			this.sliderSpeed.Name = "sliderSpeed";
			this.sliderSpeed.Size = new System.Drawing.Size(124, 45);
			this.sliderSpeed.TabIndex = 2;
			this.sliderSpeed.Scroll += new System.EventHandler(this.trackBSpeed_Scroll);
			// 
			// txtBoxSliderValue
			// 
			this.txtBoxSliderValue.Location = new System.Drawing.Point(12, 54);
			this.txtBoxSliderValue.Name = "txtBoxSliderValue";
			this.txtBoxSliderValue.Size = new System.Drawing.Size(75, 20);
			this.txtBoxSliderValue.TabIndex = 4;
			this.txtBoxSliderValue.Text = "500 ms";
			// 
			// rdBtnLive
			// 
			this.rdBtnLive.AutoSize = true;
			this.rdBtnLive.Checked = true;
			this.rdBtnLive.Location = new System.Drawing.Point(12, 81);
			this.rdBtnLive.Name = "rdBtnLive";
			this.rdBtnLive.Size = new System.Drawing.Size(74, 17);
			this.rdBtnLive.TabIndex = 5;
			this.rdBtnLive.TabStop = true;
			this.rdBtnLive.Text = "Live mode";
			this.rdBtnLive.UseVisualStyleBackColor = true;
			// 
			// rdBtnFast
			// 
			this.rdBtnFast.AutoSize = true;
			this.rdBtnFast.Location = new System.Drawing.Point(12, 101);
			this.rdBtnFast.Name = "rdBtnFast";
			this.rdBtnFast.Size = new System.Drawing.Size(74, 17);
			this.rdBtnFast.TabIndex = 6;
			this.rdBtnFast.Text = "Fast mode";
			this.rdBtnFast.UseVisualStyleBackColor = true;
			this.rdBtnFast.CheckedChanged += new System.EventHandler(this.rdBtnFast_CheckedChanged);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(85, 12);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(68, 23);
			this.btnStop.TabIndex = 0;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(230, 41);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(68, 23);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Clear Screen";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// drawingPanel
			// 
			this.drawingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.drawingPanel.Controls.Add(this.pictureBox);
			this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawingPanel.Location = new System.Drawing.Point(3, 3);
			this.drawingPanel.Name = "drawingPanel";
			this.drawingPanel.Size = new System.Drawing.Size(707, 596);
			this.drawingPanel.TabIndex = 9;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
			this.tableLayoutPanel1.Controls.Add(this.drawingPanel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelControl, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1031, 602);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// cetusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 602);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(1000, 640);
			this.Name = "cetusForm";
			this.Text = "Cetus";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panelControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.minimapPictureBox)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarScalingLevel)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFieldPercent)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSpeed)).EndInit();
			this.drawingPanel.ResumeLayout(false);
			this.drawingPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		public System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Panel panelControl;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TextBox txtBoxWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Fieldsize;
		private System.Windows.Forms.TextBox txtBoxHeight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBarScalingLevel;
		private System.Windows.Forms.TextBox txtBoxScalingLevel;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnRandomise;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBarFieldPercent;
		private System.Windows.Forms.TextBox txtBoxSliderFieldPercent;
		private System.Windows.Forms.Button btnRandomAmeisenPosition;
		private System.Windows.Forms.Button btnResetCustomField;
		private System.Windows.Forms.Button btnAmeisePosition;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnSwitchColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBoxX;
		private System.Windows.Forms.Label PosY;
		private System.Windows.Forms.TextBox txtBoxY;
		private System.Windows.Forms.Label PosX;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TrackBar sliderSpeed;
		private System.Windows.Forms.TextBox txtBoxSliderValue;
		private System.Windows.Forms.RadioButton rdBtnLive;
		private System.Windows.Forms.RadioButton rdBtnFast;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Panel drawingPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBoxPixelsPerField;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox checkBoxAutoCenter;
		private System.Windows.Forms.CheckBox checkBoxSaveIfFinished;
		private System.Windows.Forms.Button btnMoveCameraHome;
		private System.Windows.Forms.PictureBox minimapPictureBox;
		private System.Windows.Forms.CheckBox checkBoxDrawMinimap;
		private System.Windows.Forms.CheckBox checkBoxFollowAmeise;
		private System.Windows.Forms.CheckBox checkBoxEnergyMode;

    }
}

