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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_OpenStaircase = new System.Windows.Forms.Button();
            this.txtField_StairCaseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.SystemColors.Info;
            this.btn_OpenFile.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(32, 79);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(144, 31);
            this.btn_OpenFile.TabIndex = 9;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(322, 9);
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
            this.btn_Calculate.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Calculate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(165, 426);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(109, 31);
            this.btn_Calculate.TabIndex = 17;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            // 
            // txtArea_GwyFilePath
            // 
            this.txtArea_GwyFilePath.Enabled = false;
            this.txtArea_GwyFilePath.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea_GwyFilePath.Location = new System.Drawing.Point(182, 79);
            this.txtArea_GwyFilePath.Name = "txtArea_GwyFilePath";
            this.txtArea_GwyFilePath.Size = new System.Drawing.Size(682, 31);
            this.txtArea_GwyFilePath.TabIndex = 19;
            this.txtArea_GwyFilePath.Text = "";
            // 
            // lbl_GwyFileName
            // 
            this.lbl_GwyFileName.AutoSize = true;
            this.lbl_GwyFileName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GwyFileName.Location = new System.Drawing.Point(182, 58);
            this.lbl_GwyFileName.Name = "lbl_GwyFileName";
            this.lbl_GwyFileName.Size = new System.Drawing.Size(85, 18);
            this.lbl_GwyFileName.TabIndex = 20;
            this.lbl_GwyFileName.Text = "File Name";
            // 
            // dropdown_DataChannels
            // 
            this.dropdown_DataChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_DataChannels.FormattingEnabled = true;
            this.dropdown_DataChannels.Items.AddRange(new object[] {
            "Default"});
            this.dropdown_DataChannels.Location = new System.Drawing.Point(35, 138);
            this.dropdown_DataChannels.Name = "dropdown_DataChannels";
            this.dropdown_DataChannels.Size = new System.Drawing.Size(261, 28);
            this.dropdown_DataChannels.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(299, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(32, 328);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 26);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Resistivity vs Resistance (R)",
            "Resistivity vs Resistance Amplitude (dR)",
            "Carrier Concentration vs Resistance (R)",
            "Carrier Concentration vs Resistance Amplitude (dR)"});
            this.comboBox3.Location = new System.Drawing.Point(32, 383);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(242, 26);
            this.comboBox3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Measurement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Function";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(35, 537);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(79, 18);
            this.lbl_Message.TabIndex = 29;
            this.lbl_Message.Text = "Message:";
            // 
            // btn_OpenStaircase
            // 
            this.btn_OpenStaircase.BackColor = System.Drawing.SystemColors.Info;
            this.btn_OpenStaircase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenStaircase.Location = new System.Drawing.Point(31, 203);
            this.btn_OpenStaircase.Name = "btn_OpenStaircase";
            this.btn_OpenStaircase.Size = new System.Drawing.Size(262, 31);
            this.btn_OpenStaircase.TabIndex = 30;
            this.btn_OpenStaircase.Text = "Open Staircase";
            this.btn_OpenStaircase.UseVisualStyleBackColor = false;
            // 
            // txtField_StairCaseName
            // 
            this.txtField_StairCaseName.Enabled = false;
            this.txtField_StairCaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_StairCaseName.Location = new System.Drawing.Point(31, 277);
            this.txtField_StairCaseName.Name = "txtField_StairCaseName";
            this.txtField_StairCaseName.Size = new System.Drawing.Size(243, 26);
            this.txtField_StairCaseName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Staircase Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gwyddion Image";
            // 
            // QuantifyDeviceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtField_StairCaseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_OpenStaircase);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_OpenStaircase;
        private System.Windows.Forms.TextBox txtField_StairCaseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}