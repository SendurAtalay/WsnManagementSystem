namespace WsnManagementSystem.GUI
{
    partial class SensorMeasurementTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMeasurementID = new System.Windows.Forms.TextBox();
            this.txtMeasurementName = new System.Windows.Forms.TextBox();
            this.txtMeasurementAbbreviation = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMeasurementTypes = new System.Windows.Forms.DataGridView();
            this.SensorMeasurementTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefinationOfSensorMeasurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor Measurement ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor Measurement Type Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sensor Measurement Abbreviation :";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(40, 222);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMeasurementID
            // 
            this.txtMeasurementID.Location = new System.Drawing.Point(365, 23);
            this.txtMeasurementID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasurementID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtMeasurementID.Multiline = true;
            this.txtMeasurementID.Name = "txtMeasurementID";
            this.txtMeasurementID.Size = new System.Drawing.Size(281, 35);
            this.txtMeasurementID.TabIndex = 2;
            // 
            // txtMeasurementName
            // 
            this.txtMeasurementName.Location = new System.Drawing.Point(365, 86);
            this.txtMeasurementName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasurementName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtMeasurementName.Multiline = true;
            this.txtMeasurementName.Name = "txtMeasurementName";
            this.txtMeasurementName.Size = new System.Drawing.Size(281, 35);
            this.txtMeasurementName.TabIndex = 2;
            // 
            // txtMeasurementAbbreviation
            // 
            this.txtMeasurementAbbreviation.Location = new System.Drawing.Point(365, 142);
            this.txtMeasurementAbbreviation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasurementAbbreviation.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtMeasurementAbbreviation.Multiline = true;
            this.txtMeasurementAbbreviation.Name = "txtMeasurementAbbreviation";
            this.txtMeasurementAbbreviation.Size = new System.Drawing.Size(281, 35);
            this.txtMeasurementAbbreviation.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(213, 222);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(387, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(571, 222);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(157, 50);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMeasurementAbbreviation);
            this.groupBox1.Controls.Add(this.txtMeasurementName);
            this.groupBox1.Controls.Add(this.txtMeasurementID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(871, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Measurement Types";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMeasurementTypes);
            this.groupBox2.Location = new System.Drawing.Point(16, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(860, 331);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvMeasurementTypes
            // 
            this.dgvMeasurementTypes.AllowUserToAddRows = false;
            this.dgvMeasurementTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMeasurementTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMeasurementTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurementTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorMeasurementTypeID,
            this.DefinationOfSensorMeasurements,
            this.SensorMeasurements,
            this.SensorMeasurementTypeName,
            this.SensorMeasurementTypeAbbreviation});
            this.dgvMeasurementTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasurementTypes.Location = new System.Drawing.Point(4, 19);
            this.dgvMeasurementTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMeasurementTypes.Name = "dgvMeasurementTypes";
            this.dgvMeasurementTypes.RowHeadersWidth = 51;
            this.dgvMeasurementTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasurementTypes.Size = new System.Drawing.Size(852, 308);
            this.dgvMeasurementTypes.TabIndex = 0;
            this.dgvMeasurementTypes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeasurementTypes_RowEnter);
            // 
            // SensorMeasurementTypeID
            // 
            this.SensorMeasurementTypeID.DataPropertyName = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.HeaderText = "Sensor Measurement Type No";
            this.SensorMeasurementTypeID.MinimumWidth = 6;
            this.SensorMeasurementTypeID.Name = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.Width = 182;
            // 
            // DefinationOfSensorMeasurements
            // 
            this.DefinationOfSensorMeasurements.DataPropertyName = "DefinationOfSensorMeasurements";
            this.DefinationOfSensorMeasurements.HeaderText = "Defination of Sensor Measurements";
            this.DefinationOfSensorMeasurements.MinimumWidth = 6;
            this.DefinationOfSensorMeasurements.Name = "DefinationOfSensorMeasurements";
            this.DefinationOfSensorMeasurements.Visible = false;
            this.DefinationOfSensorMeasurements.Width = 125;
            // 
            // SensorMeasurements
            // 
            this.SensorMeasurements.DataPropertyName = "SensorMeasurements";
            this.SensorMeasurements.HeaderText = "Sensor Measurements";
            this.SensorMeasurements.MinimumWidth = 6;
            this.SensorMeasurements.Name = "SensorMeasurements";
            this.SensorMeasurements.Visible = false;
            this.SensorMeasurements.Width = 125;
            // 
            // SensorMeasurementTypeName
            // 
            this.SensorMeasurementTypeName.DataPropertyName = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.HeaderText = "Sensor Measurement Type Name";
            this.SensorMeasurementTypeName.MinimumWidth = 6;
            this.SensorMeasurementTypeName.Name = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.Width = 184;
            // 
            // SensorMeasurementTypeAbbreviation
            // 
            this.SensorMeasurementTypeAbbreviation.DataPropertyName = "SensorMeasurementTypeAbbreviation";
            this.SensorMeasurementTypeAbbreviation.HeaderText = "Sensor Measurement Type Abbreviation";
            this.SensorMeasurementTypeAbbreviation.MinimumWidth = 6;
            this.SensorMeasurementTypeAbbreviation.Name = "SensorMeasurementTypeAbbreviation";
            this.SensorMeasurementTypeAbbreviation.Width = 184;
            // 
            // SensorMeasurementTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SensorMeasurementTypes";
            this.Text = "SensorMeasurementTypes";
            this.Load += new System.EventHandler(this.SensorMeasurementTypes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurementTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMeasurementID;
        private System.Windows.Forms.TextBox txtMeasurementName;
        private System.Windows.Forms.TextBox txtMeasurementAbbreviation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMeasurementTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinationOfSensorMeasurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeAbbreviation;
    }
}