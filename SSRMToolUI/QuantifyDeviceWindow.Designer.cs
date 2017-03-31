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
            this.txtField_DeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListBox_DataChannels = new System.Windows.Forms.CheckedListBox();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_SelectRegions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtField_DeviceName
            // 
            this.txtField_DeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_DeviceName.Location = new System.Drawing.Point(32, 84);
            this.txtField_DeviceName.Name = "txtField_DeviceName";
            this.txtField_DeviceName.Size = new System.Drawing.Size(198, 31);
            this.txtField_DeviceName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Device Name";
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.SystemColors.Info;
            this.btn_openFile.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(236, 84);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(144, 31);
            this.btn_openFile.TabIndex = 9;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = false;
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(53, 9);
            this.lbl_DefineStaircase.Name = "lbl_DefineStaircase";
            this.lbl_DefineStaircase.Size = new System.Drawing.Size(293, 37);
            this.lbl_DefineStaircase.TabIndex = 12;
            this.lbl_DefineStaircase.Text = "Quantify Devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Channels";
            // 
            // chkListBox_DataChannels
            // 
            this.chkListBox_DataChannels.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.chkListBox_DataChannels.FormattingEnabled = true;
            this.chkListBox_DataChannels.IntegralHeight = false;
            this.chkListBox_DataChannels.Items.AddRange(new object[] {
            "Height",
            "Thickness"});
            this.chkListBox_DataChannels.Location = new System.Drawing.Point(32, 168);
            this.chkListBox_DataChannels.Name = "chkListBox_DataChannels";
            this.chkListBox_DataChannels.Size = new System.Drawing.Size(181, 191);
            this.chkListBox_DataChannels.TabIndex = 15;
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SaveFile.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveFile.Location = new System.Drawing.Point(32, 424);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(144, 31);
            this.btn_SaveFile.TabIndex = 16;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Calculate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(236, 424);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(144, 31);
            this.btn_Calculate.TabIndex = 17;
            this.btn_Calculate.Text = "Calculate!";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            // 
            // btn_SelectRegions
            // 
            this.btn_SelectRegions.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SelectRegions.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectRegions.Location = new System.Drawing.Point(32, 365);
            this.btn_SelectRegions.Name = "btn_SelectRegions";
            this.btn_SelectRegions.Size = new System.Drawing.Size(144, 31);
            this.btn_SelectRegions.TabIndex = 18;
            this.btn_SelectRegions.Text = "Select Regions";
            this.btn_SelectRegions.UseVisualStyleBackColor = false;
            // 
            // QuantifyDeviceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 467);
            this.Controls.Add(this.btn_SelectRegions);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.chkListBox_DataChannels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_DefineStaircase);
            this.Controls.Add(this.txtField_DeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_openFile);
            this.Name = "QuantifyDeviceWindow";
            this.Text = "QuantifyDeviceWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtField_DeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Label lbl_DefineStaircase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListBox_DataChannels;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_SelectRegions;
    }
}