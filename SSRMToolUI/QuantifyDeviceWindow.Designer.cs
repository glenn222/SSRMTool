namespace SSRMToolUI
{
    partial class QuantifyDeviceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantifyDeviceWindow));
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txtArea_GwyFilePath = new System.Windows.Forms.RichTextBox();
            this.lbl_GwyFileName = new System.Windows.Forms.Label();
            this.dropdown_DataChannels = new System.Windows.Forms.ComboBox();
            this.pictureBox_GwyddionImage = new System.Windows.Forms.PictureBox();
            this.dropdown_Measurements = new System.Windows.Forms.ComboBox();
            this.dropdown_MeasurementFunctions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_OpenStaircase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea_StairCaseMetaData = new System.Windows.Forms.RichTextBox();
            this.txtArea_FunctionExpression = new System.Windows.Forms.RichTextBox();
            this.pictureBox_NewGwyddionImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_ProcessedGwyddionImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GwyddionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NewGwyddionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProcessedGwyddionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_OpenFile.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(32, 79);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(242, 31);
            this.btn_OpenFile.TabIndex = 9;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(491, 9);
            this.lbl_DefineStaircase.Name = "lbl_DefineStaircase";
            this.lbl_DefineStaircase.Size = new System.Drawing.Size(293, 37);
            this.lbl_DefineStaircase.TabIndex = 12;
            this.lbl_DefineStaircase.Text = "Quantify Devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Channels";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Calculate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Calculate.Location = new System.Drawing.Point(1135, 608);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(82, 47);
            this.btn_Calculate.TabIndex = 17;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txtArea_GwyFilePath
            // 
            this.txtArea_GwyFilePath.Enabled = false;
            this.txtArea_GwyFilePath.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea_GwyFilePath.Location = new System.Drawing.Point(299, 79);
            this.txtArea_GwyFilePath.Name = "txtArea_GwyFilePath";
            this.txtArea_GwyFilePath.Size = new System.Drawing.Size(918, 31);
            this.txtArea_GwyFilePath.TabIndex = 19;
            this.txtArea_GwyFilePath.Text = "";
            // 
            // lbl_GwyFileName
            // 
            this.lbl_GwyFileName.AutoSize = true;
            this.lbl_GwyFileName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GwyFileName.Location = new System.Drawing.Point(296, 58);
            this.lbl_GwyFileName.Name = "lbl_GwyFileName";
            this.lbl_GwyFileName.Size = new System.Drawing.Size(85, 18);
            this.lbl_GwyFileName.TabIndex = 20;
            this.lbl_GwyFileName.Text = "File Name";
            // 
            // dropdown_DataChannels
            // 
            this.dropdown_DataChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_DataChannels.FormattingEnabled = true;
            this.dropdown_DataChannels.Location = new System.Drawing.Point(35, 138);
            this.dropdown_DataChannels.Name = "dropdown_DataChannels";
            this.dropdown_DataChannels.Size = new System.Drawing.Size(239, 28);
            this.dropdown_DataChannels.TabIndex = 21;
            this.dropdown_DataChannels.SelectedIndexChanged += new System.EventHandler(this.dropdown_DataChannels_SelectedIndexChanged);
            // 
            // pictureBox_GwyddionImage
            // 
            this.pictureBox_GwyddionImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_GwyddionImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GwyddionImage.Image")));
            this.pictureBox_GwyddionImage.InitialImage = null;
            this.pictureBox_GwyddionImage.Location = new System.Drawing.Point(303, 138);
            this.pictureBox_GwyddionImage.Name = "pictureBox_GwyddionImage";
            this.pictureBox_GwyddionImage.Size = new System.Drawing.Size(450, 450);
            this.pictureBox_GwyddionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GwyddionImage.TabIndex = 22;
            this.pictureBox_GwyddionImage.TabStop = false;
            this.pictureBox_GwyddionImage.WaitOnLoad = true;
            // 
            // dropdown_Measurements
            // 
            this.dropdown_Measurements.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_Measurements.FormattingEnabled = true;
            this.dropdown_Measurements.Location = new System.Drawing.Point(40, 416);
            this.dropdown_Measurements.Name = "dropdown_Measurements";
            this.dropdown_Measurements.Size = new System.Drawing.Size(235, 26);
            this.dropdown_Measurements.TabIndex = 24;
            this.dropdown_Measurements.SelectedIndexChanged += new System.EventHandler(this.dropdown_Measurements_SelectedIndexChanged);
            // 
            // dropdown_MeasurementFunctions
            // 
            this.dropdown_MeasurementFunctions.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_MeasurementFunctions.FormattingEnabled = true;
            this.dropdown_MeasurementFunctions.Items.AddRange(new object[] {
            "Resistivity vs Resistance (R)",
            "Resistivity vs Resistance Amplitude (dR)",
            "Dopants vs Resistance (R)",
            "Dopants vs Resistance Amplitude (dR)"});
            this.dropdown_MeasurementFunctions.Location = new System.Drawing.Point(40, 471);
            this.dropdown_MeasurementFunctions.Name = "dropdown_MeasurementFunctions";
            this.dropdown_MeasurementFunctions.Size = new System.Drawing.Size(235, 26);
            this.dropdown_MeasurementFunctions.TabIndex = 25;
            this.dropdown_MeasurementFunctions.SelectedIndexChanged += new System.EventHandler(this.dropdown_MeasurementFunctions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Measurements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Function";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(300, 591);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(90, 18);
            this.lbl_Message.TabIndex = 29;
            this.lbl_Message.Text = "Expression";
            // 
            // btn_OpenStaircase
            // 
            this.btn_OpenStaircase.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_OpenStaircase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenStaircase.Location = new System.Drawing.Point(32, 181);
            this.btn_OpenStaircase.Name = "btn_OpenStaircase";
            this.btn_OpenStaircase.Size = new System.Drawing.Size(243, 31);
            this.btn_OpenStaircase.TabIndex = 30;
            this.btn_OpenStaircase.Text = "Open Staircase";
            this.btn_OpenStaircase.UseVisualStyleBackColor = false;
            this.btn_OpenStaircase.Click += new System.EventHandler(this.btn_OpenStaircase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Staircase Metadata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gwyddion Image";
            // 
            // txtArea_StairCaseMetaData
            // 
            this.txtArea_StairCaseMetaData.Enabled = false;
            this.txtArea_StairCaseMetaData.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea_StairCaseMetaData.Location = new System.Drawing.Point(39, 242);
            this.txtArea_StairCaseMetaData.Name = "txtArea_StairCaseMetaData";
            this.txtArea_StairCaseMetaData.Size = new System.Drawing.Size(236, 149);
            this.txtArea_StairCaseMetaData.TabIndex = 34;
            this.txtArea_StairCaseMetaData.Text = "Staircase Name:\nStaircase Description:\nStaircase Material:";
            // 
            // txtArea_FunctionExpression
            // 
            this.txtArea_FunctionExpression.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea_FunctionExpression.Location = new System.Drawing.Point(303, 610);
            this.txtArea_FunctionExpression.Name = "txtArea_FunctionExpression";
            this.txtArea_FunctionExpression.Size = new System.Drawing.Size(826, 47);
            this.txtArea_FunctionExpression.TabIndex = 35;
            this.txtArea_FunctionExpression.Text = "";
            // 
            // pictureBox_NewGwyddionImage
            // 
            this.pictureBox_NewGwyddionImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_NewGwyddionImage.Name = "pictureBox_NewGwyddionImage";
            this.pictureBox_NewGwyddionImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_NewGwyddionImage.TabIndex = 0;
            this.pictureBox_NewGwyddionImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(759, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Processed Image";
            // 
            // pictureBox_ProcessedGwyddionImage
            // 
            this.pictureBox_ProcessedGwyddionImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_ProcessedGwyddionImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ProcessedGwyddionImage.Image")));
            this.pictureBox_ProcessedGwyddionImage.InitialImage = null;
            this.pictureBox_ProcessedGwyddionImage.Location = new System.Drawing.Point(767, 138);
            this.pictureBox_ProcessedGwyddionImage.Name = "pictureBox_ProcessedGwyddionImage";
            this.pictureBox_ProcessedGwyddionImage.Size = new System.Drawing.Size(450, 450);
            this.pictureBox_ProcessedGwyddionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ProcessedGwyddionImage.TabIndex = 36;
            this.pictureBox_ProcessedGwyddionImage.TabStop = false;
            this.pictureBox_ProcessedGwyddionImage.WaitOnLoad = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(764, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Processed Image";
            // 
            // QuantifyDeviceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1238, 667);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_ProcessedGwyddionImage);
            this.Controls.Add(this.txtArea_FunctionExpression);
            this.Controls.Add(this.txtArea_StairCaseMetaData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_OpenStaircase);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropdown_MeasurementFunctions);
            this.Controls.Add(this.dropdown_Measurements);
            this.Controls.Add(this.pictureBox_GwyddionImage);
            this.Controls.Add(this.dropdown_DataChannels);
            this.Controls.Add(this.lbl_GwyFileName);
            this.Controls.Add(this.txtArea_GwyFilePath);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_DefineStaircase);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "QuantifyDeviceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuantifyDeviceWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GwyddionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NewGwyddionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProcessedGwyddionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label lbl_DefineStaircase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.RichTextBox txtArea_GwyFilePath;
        private System.Windows.Forms.Label lbl_GwyFileName;
        private System.Windows.Forms.ComboBox dropdown_DataChannels;
        private System.Windows.Forms.PictureBox pictureBox_GwyddionImage;
        private System.Windows.Forms.ComboBox dropdown_Measurements;
        private System.Windows.Forms.ComboBox dropdown_MeasurementFunctions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_OpenStaircase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtArea_StairCaseMetaData;
        private System.Windows.Forms.RichTextBox txtArea_FunctionExpression;
        private System.Windows.Forms.PictureBox pictureBox_NewGwyddionImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_ProcessedGwyddionImage;
        private System.Windows.Forms.Label label7;
    }
}