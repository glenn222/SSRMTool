namespace SSRMToolUI
{
    partial class OpenStaircaseDataWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrdView_StairCaseTable = new System.Windows.Forms.DataGridView();
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            this.Staircases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView_StairCaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdView_StairCaseTable
            // 
            this.dataGrdView_StairCaseTable.AllowUserToAddRows = false;
            this.dataGrdView_StairCaseTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGrdView_StairCaseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrdView_StairCaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrdView_StairCaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdView_StairCaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staircases,
            this.CreationDate,
            this.Select});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrdView_StairCaseTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrdView_StairCaseTable.Location = new System.Drawing.Point(12, 60);
            this.dataGrdView_StairCaseTable.Name = "dataGrdView_StairCaseTable";
            this.dataGrdView_StairCaseTable.Size = new System.Drawing.Size(740, 168);
            this.dataGrdView_StairCaseTable.TabIndex = 0;
            this.dataGrdView_StairCaseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdView_StairCaseTable_CellContentClick);
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(220, 9);
            this.lbl_DefineStaircase.Name = "lbl_DefineStaircase";
            this.lbl_DefineStaircase.Size = new System.Drawing.Size(341, 37);
            this.lbl_DefineStaircase.TabIndex = 2;
            this.lbl_DefineStaircase.Text = "Available Staircases";
            // 
            // Staircases
            // 
            this.Staircases.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Staircases.FillWeight = 200F;
            this.Staircases.HeaderText = "Staircase Name";
            this.Staircases.Name = "Staircases";
            this.Staircases.ReadOnly = true;
            this.Staircases.ToolTipText = "Staircase Measurement";
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "Date Created";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Width = 200;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Select.HeaderText = "Selection";
            this.Select.Name = "Select";
            this.Select.Text = "Select Staircase";
            this.Select.ToolTipText = "Select this staircase to use for SSRM.";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 150;
            // 
            // OpenStaircaseDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 369);
            this.Controls.Add(this.lbl_DefineStaircase);
            this.Controls.Add(this.dataGrdView_StairCaseTable);
            this.Name = "OpenStaircaseDataWindow";
            this.Text = "Staircase Selection Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView_StairCaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdView_StairCaseTable;
        private System.Windows.Forms.Label lbl_DefineStaircase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staircases;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
    }
}