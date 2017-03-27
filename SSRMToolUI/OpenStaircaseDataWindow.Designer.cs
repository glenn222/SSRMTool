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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrdView_StairCaseTable = new System.Windows.Forms.DataGridView();
            this.Staircases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView_StairCaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdView_StairCaseTable
            // 
            this.dataGrdView_StairCaseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrdView_StairCaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrdView_StairCaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdView_StairCaseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staircases,
            this.CreationDate,
            this.Select});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrdView_StairCaseTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrdView_StairCaseTable.Location = new System.Drawing.Point(12, 60);
            this.dataGrdView_StairCaseTable.Name = "dataGrdView_StairCaseTable";
            this.dataGrdView_StairCaseTable.Size = new System.Drawing.Size(740, 168);
            this.dataGrdView_StairCaseTable.TabIndex = 0;
            this.dataGrdView_StairCaseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdView_StairCaseTable_CellContentClick);
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
            this.CreationDate.Width = 150;
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