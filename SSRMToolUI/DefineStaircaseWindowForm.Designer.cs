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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_DefineStaircase = new System.Windows.Forms.Label();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.btn_ComputeStaircase = new System.Windows.Forms.Button();
            this.btn_OpenStaircases = new System.Windows.Forms.Button();
            this.dataGridView_StairCaseMeasurements = new System.Windows.Forms.DataGridView();
            this.Resistivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dopants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResistanceAmplitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtField_StairCaseName = new System.Windows.Forms.TextBox();
            this.dropdown_StairCaseMeasurements = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SaveStairCase = new System.Windows.Forms.Button();
            this.btn_deleteRow = new System.Windows.Forms.Button();
            this.txtField_StairCaseDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtField_MeasurementDescription = new System.Windows.Forms.TextBox();
            this.TxtArea_StairCaseOutput = new System.Windows.Forms.RichTextBox();
            this.txtField_TipName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtField_StaircaseMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StairCaseMeasurements)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DefineStaircase
            // 
            this.lbl_DefineStaircase.AutoSize = true;
            this.lbl_DefineStaircase.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefineStaircase.Location = new System.Drawing.Point(383, 9);
            this.lbl_DefineStaircase.Name = "lbl_DefineStaircase";
            this.lbl_DefineStaircase.Size = new System.Drawing.Size(279, 37);
            this.lbl_DefineStaircase.TabIndex = 1;
            this.lbl_DefineStaircase.Text = "Define Staircase";
            // 
            // btn_addRow
            // 
            this.btn_addRow.BackColor = System.Drawing.SystemColors.Info;
            this.btn_addRow.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRow.Location = new System.Drawing.Point(25, 408);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(144, 35);
            this.btn_addRow.TabIndex = 2;
            this.btn_addRow.Text = "Add Row (+)";
            this.btn_addRow.UseVisualStyleBackColor = false;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
            // 
            // btn_ComputeStaircase
            // 
            this.btn_ComputeStaircase.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ComputeStaircase.Enabled = false;
            this.btn_ComputeStaircase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ComputeStaircase.Location = new System.Drawing.Point(853, 409);
            this.btn_ComputeStaircase.Name = "btn_ComputeStaircase";
            this.btn_ComputeStaircase.Size = new System.Drawing.Size(166, 35);
            this.btn_ComputeStaircase.TabIndex = 3;
            this.btn_ComputeStaircase.Text = "Compute Staircase";
            this.btn_ComputeStaircase.UseVisualStyleBackColor = false;
            this.btn_ComputeStaircase.Click += new System.EventHandler(this.btn_ComputeStaircase_Click);
            // 
            // btn_OpenStaircases
            // 
            this.btn_OpenStaircases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OpenStaircases.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenStaircases.Location = new System.Drawing.Point(25, 59);
            this.btn_OpenStaircases.Name = "btn_OpenStaircases";
            this.btn_OpenStaircases.Size = new System.Drawing.Size(144, 35);
            this.btn_OpenStaircases.TabIndex = 5;
            this.btn_OpenStaircases.Text = "Load Staircase";
            this.btn_OpenStaircases.UseVisualStyleBackColor = false;
            this.btn_OpenStaircases.Click += new System.EventHandler(this.btn_OpenStaircases_Click);
            // 
            // dataGridView_StairCaseMeasurements
            // 
            this.dataGridView_StairCaseMeasurements.AllowUserToAddRows = false;
            this.dataGridView_StairCaseMeasurements.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_StairCaseMeasurements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_StairCaseMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StairCaseMeasurements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resistivity,
            this.Dopants,
            this.Resistance,
            this.ResistanceAmplitude});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_StairCaseMeasurements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_StairCaseMeasurements.Location = new System.Drawing.Point(25, 216);
            this.dataGridView_StairCaseMeasurements.Name = "dataGridView_StairCaseMeasurements";
            this.dataGridView_StairCaseMeasurements.Size = new System.Drawing.Size(994, 187);
            this.dataGridView_StairCaseMeasurements.TabIndex = 6;
            // 
            // Resistivity
            // 
            this.Resistivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Resistivity.HeaderText = "Resistivity";
            this.Resistivity.Name = "Resistivity";
            // 
            // Dopants
            // 
            this.Dopants.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dopants.HeaderText = "Dopants";
            this.Dopants.Name = "Dopants";
            // 
            // Resistance
            // 
            this.Resistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Resistance.HeaderText = "Resistance (R)";
            this.Resistance.Name = "Resistance";
            // 
            // ResistanceAmplitude
            // 
            this.ResistanceAmplitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResistanceAmplitude.HeaderText = "Resistance Amplitude (dR)";
            this.ResistanceAmplitude.Name = "ResistanceAmplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staircase Name";
            // 
            // txtField_StairCaseName
            // 
            this.txtField_StairCaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_StairCaseName.Location = new System.Drawing.Point(25, 130);
            this.txtField_StairCaseName.Name = "txtField_StairCaseName";
            this.txtField_StairCaseName.Size = new System.Drawing.Size(198, 26);
            this.txtField_StairCaseName.TabIndex = 8;
            // 
            // dropdown_StairCaseMeasurements
            // 
            this.dropdown_StairCaseMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_StairCaseMeasurements.FormattingEnabled = true;
            this.dropdown_StairCaseMeasurements.Items.AddRange(new object[] {
            "New Measurement"});
            this.dropdown_StairCaseMeasurements.Location = new System.Drawing.Point(584, 130);
            this.dropdown_StairCaseMeasurements.Name = "dropdown_StairCaseMeasurements";
            this.dropdown_StairCaseMeasurements.Size = new System.Drawing.Size(195, 28);
            this.dropdown_StairCaseMeasurements.TabIndex = 9;
            this.dropdown_StairCaseMeasurements.SelectedIndexChanged += new System.EventHandler(this.dropdown_StairCaseMeasurements_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Staircase Measurements";
            // 
            // btn_SaveStairCase
            // 
            this.btn_SaveStairCase.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SaveStairCase.Enabled = false;
            this.btn_SaveStairCase.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveStairCase.Location = new System.Drawing.Point(875, 642);
            this.btn_SaveStairCase.Name = "btn_SaveStairCase";
            this.btn_SaveStairCase.Size = new System.Drawing.Size(144, 35);
            this.btn_SaveStairCase.TabIndex = 11;
            this.btn_SaveStairCase.Text = "Save Staircase";
            this.btn_SaveStairCase.UseVisualStyleBackColor = false;
            this.btn_SaveStairCase.Click += new System.EventHandler(this.btn_SaveStairCase_Click);
            // 
            // btn_deleteRow
            // 
            this.btn_deleteRow.BackColor = System.Drawing.SystemColors.Info;
            this.btn_deleteRow.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRow.Location = new System.Drawing.Point(175, 408);
            this.btn_deleteRow.Name = "btn_deleteRow";
            this.btn_deleteRow.Size = new System.Drawing.Size(165, 35);
            this.btn_deleteRow.TabIndex = 12;
            this.btn_deleteRow.Text = "Delete Last Row (-)";
            this.btn_deleteRow.UseVisualStyleBackColor = false;
            this.btn_deleteRow.Click += new System.EventHandler(this.btn_deleteRow_Click);
            // 
            // txtField_StairCaseDescription
            // 
            this.txtField_StairCaseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_StairCaseDescription.Location = new System.Drawing.Point(25, 182);
            this.txtField_StairCaseDescription.Name = "txtField_StairCaseDescription";
            this.txtField_StairCaseDescription.Size = new System.Drawing.Size(198, 26);
            this.txtField_StairCaseDescription.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sample Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Measurement Description";
            // 
            // txtField_MeasurementDescription
            // 
            this.txtField_MeasurementDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_MeasurementDescription.Location = new System.Drawing.Point(802, 182);
            this.txtField_MeasurementDescription.Name = "txtField_MeasurementDescription";
            this.txtField_MeasurementDescription.Size = new System.Drawing.Size(217, 26);
            this.txtField_MeasurementDescription.TabIndex = 15;
            // 
            // TxtArea_StairCaseOutput
            // 
            this.TxtArea_StairCaseOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtArea_StairCaseOutput.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea_StairCaseOutput.Location = new System.Drawing.Point(25, 448);
            this.TxtArea_StairCaseOutput.Margin = new System.Windows.Forms.Padding(2);
            this.TxtArea_StairCaseOutput.Name = "TxtArea_StairCaseOutput";
            this.TxtArea_StairCaseOutput.ReadOnly = true;
            this.TxtArea_StairCaseOutput.Size = new System.Drawing.Size(994, 189);
            this.TxtArea_StairCaseOutput.TabIndex = 23;
            this.TxtArea_StairCaseOutput.Text = "";
            // 
            // txtField_TipName
            // 
            this.txtField_TipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_TipName.Location = new System.Drawing.Point(584, 182);
            this.txtField_TipName.Name = "txtField_TipName";
            this.txtField_TipName.Size = new System.Drawing.Size(198, 26);
            this.txtField_TipName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tip Name";
            // 
            // txtField_StaircaseMaterial
            // 
            this.txtField_StaircaseMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_StaircaseMaterial.Location = new System.Drawing.Point(245, 182);
            this.txtField_StaircaseMaterial.Name = "txtField_StaircaseMaterial";
            this.txtField_StaircaseMaterial.Size = new System.Drawing.Size(198, 26);
            this.txtField_StaircaseMaterial.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Material";
            // 
            // DefineStaircaseWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 689);
            this.Controls.Add(this.txtField_StaircaseMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtField_TipName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtArea_StairCaseOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtField_MeasurementDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtField_StairCaseDescription);
            this.Controls.Add(this.btn_deleteRow);
            this.Controls.Add(this.btn_SaveStairCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdown_StairCaseMeasurements);
            this.Controls.Add(this.txtField_StairCaseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_StairCaseMeasurements);
            this.Controls.Add(this.btn_OpenStaircases);
            this.Controls.Add(this.btn_ComputeStaircase);
            this.Controls.Add(this.btn_addRow);
            this.Controls.Add(this.lbl_DefineStaircase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DefineStaircaseWindowForm";
            this.Text = "SSRM - Define Staircase Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StairCaseMeasurements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_DefineStaircase;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.Button btn_ComputeStaircase;
        private System.Windows.Forms.Button btn_OpenStaircases;
        private System.Windows.Forms.DataGridView dataGridView_StairCaseMeasurements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtField_StairCaseName;
        private System.Windows.Forms.ComboBox dropdown_StairCaseMeasurements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveStairCase;
        private System.Windows.Forms.Button btn_deleteRow;
        private System.Windows.Forms.TextBox txtField_StairCaseDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtField_MeasurementDescription;
        private System.Windows.Forms.RichTextBox TxtArea_StairCaseOutput;
        private System.Windows.Forms.TextBox txtField_TipName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtField_StaircaseMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resistivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dopants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResistanceAmplitude;
    }
}

