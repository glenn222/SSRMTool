namespace SSRMToolUI
{
    partial class DefineStaircaseWindowForm
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
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            this.btn_LoadStaircase = new System.Windows.Forms.Button();
            this.btn_CreateStaircase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenStaircases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(125, 9);
            this.lbl_DefineStaircase.Name = "lbl_DefineStaircase";
            this.lbl_DefineStaircase.Size = new System.Drawing.Size(279, 37);
            this.lbl_DefineStaircase.TabIndex = 1;
            this.lbl_DefineStaircase.Text = "Define Staircase";
            // 
            // btn_LoadStaircase
            // 
            this.btn_LoadStaircase.BackColor = System.Drawing.SystemColors.Info;
            this.btn_LoadStaircase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadStaircase.Location = new System.Drawing.Point(25, 90);
            this.btn_LoadStaircase.Name = "btn_LoadStaircase";
            this.btn_LoadStaircase.Size = new System.Drawing.Size(144, 35);
            this.btn_LoadStaircase.TabIndex = 2;
            this.btn_LoadStaircase.Text = "Load Staircase";
            this.btn_LoadStaircase.UseVisualStyleBackColor = false;
            // 
            // btn_CreateStaircase
            // 
            this.btn_CreateStaircase.BackColor = System.Drawing.SystemColors.Info;
            this.btn_CreateStaircase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateStaircase.Location = new System.Drawing.Point(25, 131);
            this.btn_CreateStaircase.Name = "btn_CreateStaircase";
            this.btn_CreateStaircase.Size = new System.Drawing.Size(144, 35);
            this.btn_CreateStaircase.TabIndex = 3;
            this.btn_CreateStaircase.Text = "Create Staircase";
            this.btn_CreateStaircase.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resistivity";
            // 
            // btn_OpenStaircases
            // 
            this.btn_OpenStaircases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OpenStaircases.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenStaircases.Location = new System.Drawing.Point(25, 49);
            this.btn_OpenStaircases.Name = "btn_OpenStaircases";
            this.btn_OpenStaircases.Size = new System.Drawing.Size(144, 35);
            this.btn_OpenStaircases.TabIndex = 5;
            this.btn_OpenStaircases.Text = "Open Staircase";
            this.btn_OpenStaircases.UseVisualStyleBackColor = false;
            this.btn_OpenStaircases.Click += new System.EventHandler(this.btn_OpenStaircases_Click);
            // 
            // DefineStaircaseWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 447);
            this.Controls.Add(this.btn_OpenStaircases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CreateStaircase);
            this.Controls.Add(this.btn_LoadStaircase);
            this.Controls.Add(this.lbl_DefineStaircase);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DefineStaircaseWindowForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_DefineStaircase;
        private System.Windows.Forms.Button btn_LoadStaircase;
        private System.Windows.Forms.Button btn_CreateStaircase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenStaircases;
    }
}

