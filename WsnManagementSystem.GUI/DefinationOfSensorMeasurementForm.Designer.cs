namespace WsnManagementSystem.GUI
{
    partial class DefinationOfSensorMeasurementForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSensor = new System.Windows.Forms.ComboBox();
            this.cmbSensorMeasurementTypes = new System.Windows.Forms.ComboBox();
            this.txtDataTypeOfMeasurement = new System.Windows.Forms.TextBox();
            this.txtDefinationOfSensorMeasurementID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbSensorMeasurementType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDefinationOfSensorMeasurement = new System.Windows.Forms.DataGridView();
            this.DefinationOfSensorMeasurementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTypeOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinationOfSensorMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSensor);
            this.groupBox1.Controls.Add(this.cmbSensorMeasurementTypes);
            this.groupBox1.Controls.Add(this.txtDataTypeOfMeasurement);
            this.groupBox1.Controls.Add(this.txtDefinationOfSensorMeasurementID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.cmbSensorMeasurementType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(862, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counties";
            // 
            // cmbSensor
            // 
            this.cmbSensor.FormattingEnabled = true;
            this.cmbSensor.Location = new System.Drawing.Point(403, 139);
            this.cmbSensor.Name = "cmbSensor";
            this.cmbSensor.Size = new System.Drawing.Size(281, 28);
            this.cmbSensor.TabIndex = 3;
            // 
            // cmbSensorMeasurementTypes
            // 
            this.cmbSensorMeasurementTypes.FormattingEnabled = true;
            this.cmbSensorMeasurementTypes.Location = new System.Drawing.Point(403, 195);
            this.cmbSensorMeasurementTypes.Name = "cmbSensorMeasurementTypes";
            this.cmbSensorMeasurementTypes.Size = new System.Drawing.Size(281, 28);
            this.cmbSensorMeasurementTypes.TabIndex = 3;
            // 
            // txtDataTypeOfMeasurement
            // 
            this.txtDataTypeOfMeasurement.Location = new System.Drawing.Point(403, 86);
            this.txtDataTypeOfMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataTypeOfMeasurement.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDataTypeOfMeasurement.Multiline = true;
            this.txtDataTypeOfMeasurement.Name = "txtDataTypeOfMeasurement";
            this.txtDataTypeOfMeasurement.Size = new System.Drawing.Size(281, 35);
            this.txtDataTypeOfMeasurement.TabIndex = 2;
            // 
            // txtDefinationOfSensorMeasurementID
            // 
            this.txtDefinationOfSensorMeasurementID.Location = new System.Drawing.Point(403, 23);
            this.txtDefinationOfSensorMeasurementID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDefinationOfSensorMeasurementID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDefinationOfSensorMeasurementID.Multiline = true;
            this.txtDefinationOfSensorMeasurementID.Name = "txtDefinationOfSensorMeasurementID";
            this.txtDefinationOfSensorMeasurementID.Size = new System.Drawing.Size(281, 35);
            this.txtDefinationOfSensorMeasurementID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(592, 269);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(157, 50);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(417, 269);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(241, 269);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(61, 269);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbSensorMeasurementType
            // 
            this.cmbSensorMeasurementType.AutoSize = true;
            this.cmbSensorMeasurementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSensorMeasurementType.Location = new System.Drawing.Point(6, 195);
            this.cmbSensorMeasurementType.Name = "cmbSensorMeasurementType";
            this.cmbSensorMeasurementType.Size = new System.Drawing.Size(261, 25);
            this.cmbSensorMeasurementType.TabIndex = 0;
            this.cmbSensorMeasurementType.Text = "Sensor Measurement Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Type Of Measurement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defination Of Sensor Measurement ID :";
            // 
            // dgvDefinationOfSensorMeasurement
            // 
            this.dgvDefinationOfSensorMeasurement.AllowUserToAddRows = false;
            this.dgvDefinationOfSensorMeasurement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDefinationOfSensorMeasurement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDefinationOfSensorMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefinationOfSensorMeasurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DefinationOfSensorMeasurementID,
            this.DataTypeOfMeasurement,
            this.SensorID,
            this.SensorName,
            this.SensorMeasurementTypeID,
            this.SensorMeasurementTypeName});
            this.dgvDefinationOfSensorMeasurement.Location = new System.Drawing.Point(12, 376);
            this.dgvDefinationOfSensorMeasurement.Name = "dgvDefinationOfSensorMeasurement";
            this.dgvDefinationOfSensorMeasurement.RowHeadersWidth = 51;
            this.dgvDefinationOfSensorMeasurement.RowTemplate.Height = 24;
            this.dgvDefinationOfSensorMeasurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefinationOfSensorMeasurement.Size = new System.Drawing.Size(862, 158);
            this.dgvDefinationOfSensorMeasurement.TabIndex = 9;
            this.dgvDefinationOfSensorMeasurement.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefinationOfSensorMeasurement_RowEnter);
            // 
            // DefinationOfSensorMeasurementID
            // 
            this.DefinationOfSensorMeasurementID.DataPropertyName = "DefinationOfSensorMeasurementID";
            this.DefinationOfSensorMeasurementID.HeaderText = "Defination Of Sensor Measurement ID";
            this.DefinationOfSensorMeasurementID.MinimumWidth = 6;
            this.DefinationOfSensorMeasurementID.Name = "DefinationOfSensorMeasurementID";
            this.DefinationOfSensorMeasurementID.Width = 123;
            // 
            // DataTypeOfMeasurement
            // 
            this.DataTypeOfMeasurement.DataPropertyName = "DataTypeOfMeasurement";
            this.DataTypeOfMeasurement.HeaderText = "Data Type Of Measurement";
            this.DataTypeOfMeasurement.MinimumWidth = 6;
            this.DataTypeOfMeasurement.Name = "DataTypeOfMeasurement";
            this.DataTypeOfMeasurement.Width = 183;
            // 
            // SensorID
            // 
            this.SensorID.DataPropertyName = "SensorID";
            this.SensorID.HeaderText = "SensorID";
            this.SensorID.MinimumWidth = 6;
            this.SensorID.Name = "SensorID";
            this.SensorID.Visible = false;
            this.SensorID.Width = 125;
            // 
            // SensorName
            // 
            this.SensorName.DataPropertyName = "SensorName";
            this.SensorName.HeaderText = "Sensor Name";
            this.SensorName.MinimumWidth = 6;
            this.SensorName.Name = "SensorName";
            this.SensorName.Width = 110;
            // 
            // SensorMeasurementTypeID
            // 
            this.SensorMeasurementTypeID.DataPropertyName = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.HeaderText = "Sensor Measurement Type ID";
            this.SensorMeasurementTypeID.MinimumWidth = 6;
            this.SensorMeasurementTypeID.Name = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.Visible = false;
            this.SensorMeasurementTypeID.Width = 125;
            // 
            // SensorMeasurementTypeName
            // 
            this.SensorMeasurementTypeName.DataPropertyName = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.HeaderText = "Sensor Measurement Type Name";
            this.SensorMeasurementTypeName.MinimumWidth = 6;
            this.SensorMeasurementTypeName.Name = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.Width = 140;
            // 
            // DefinationOfSensorMeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 546);
            this.Controls.Add(this.dgvDefinationOfSensorMeasurement);
            this.Controls.Add(this.groupBox1);
            this.Name = "DefinationOfSensorMeasurementForm";
            this.Text = "DefinationOfSensorMeasurementForm";
            this.Load += new System.EventHandler(this.DefinationOfSensorMeasurementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinationOfSensorMeasurement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSensor;
        private System.Windows.Forms.ComboBox cmbSensorMeasurementTypes;
        private System.Windows.Forms.TextBox txtDataTypeOfMeasurement;
        private System.Windows.Forms.TextBox txtDefinationOfSensorMeasurementID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label cmbSensorMeasurementType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDefinationOfSensorMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinationOfSensorMeasurementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTypeOfMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeName;
    }
}