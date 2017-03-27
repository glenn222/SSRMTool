namespace SSRMToolUI
{
    partial class MainSSRMWindowForm
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
            this.btn_DefineStaircases = new System.Windows.Forms.Button();
            this.btn_QuantifyDevices = new System.Windows.Forms.Button();
            this.lbl_MainSSRMLabel = new System.Windows.Forms.Label();
            this.btn_QuitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DefineStaircases
            // 
            this.btn_DefineStaircases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DefineStaircases.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DefineStaircases.Location = new System.Drawing.Point(124, 89);
            this.btn_DefineStaircases.Name = "btn_DefineStaircases";
            this.btn_DefineStaircases.Size = new System.Drawing.Size(268, 49);
            this.btn_DefineStaircases.TabIndex = 0;
            this.btn_DefineStaircases.Text = "Define Staircases";
            this.btn_DefineStaircases.UseVisualStyleBackColor = false;
            this.btn_DefineStaircases.Click += new System.EventHandler(this.btn_DefineStaircases_Click);
            // 
            // btn_QuantifyDevices
            // 
            this.btn_QuantifyDevices.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuantifyDevices.Location = new System.Drawing.Point(124, 165);
            this.btn_QuantifyDevices.Name = "btn_QuantifyDevices";
            this.btn_QuantifyDevices.Size = new System.Drawing.Size(268, 49);
            this.btn_QuantifyDevices.TabIndex = 1;
            this.btn_QuantifyDevices.Text = "Quantify Devices";
            this.btn_QuantifyDevices.UseVisualStyleBackColor = true;
            this.btn_QuantifyDevices.Click += new System.EventHandler(this.btn_QuantifyDevices_Click);
            // 
            // lbl_MainSSRMLabel
            // 
            this.lbl_MainSSRMLabel.AutoSize = true;
            this.lbl_MainSSRMLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainSSRMLabel.Location = new System.Drawing.Point(3, 9);
            this.lbl_MainSSRMLabel.Name = "lbl_MainSSRMLabel";
            this.lbl_MainSSRMLabel.Size = new System.Drawing.Size(522, 24);
            this.lbl_MainSSRMLabel.TabIndex = 2;
            this.lbl_MainSSRMLabel.Text = "Spreading Scanning Resistance Microscopy (SSRM)";
            // 
            // btn_QuitProgram
            // 
            this.btn_QuitProgram.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_QuitProgram.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuitProgram.Location = new System.Drawing.Point(124, 245);
            this.btn_QuitProgram.Name = "btn_QuitProgram";
            this.btn_QuitProgram.Size = new System.Drawing.Size(268, 49);
            this.btn_QuitProgram.TabIndex = 3;
            this.btn_QuitProgram.Text = "Quit";
            this.btn_QuitProgram.UseVisualStyleBackColor = false;
            this.btn_QuitProgram.Click += new System.EventHandler(this.btn_QuitProgram_Click);
            // 
            // MainSSRMWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 377);
            this.Controls.Add(this.btn_QuitProgram);
            this.Controls.Add(this.lbl_MainSSRMLabel);
            this.Controls.Add(this.btn_QuantifyDevices);
            this.Controls.Add(this.btn_DefineStaircases);
            this.Name = "MainSSRMWindowForm";
            this.Text = "SSRM - Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DefineStaircases;
        private System.Windows.Forms.Button btn_QuantifyDevices;
        private System.Windows.Forms.Label lbl_MainSSRMLabel;
        private System.Windows.Forms.Button btn_QuitProgram;
    }
}