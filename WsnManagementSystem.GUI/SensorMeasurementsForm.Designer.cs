namespace WsnManagementSystem.GUI
{
    partial class SensorMeasurementsForm
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
            this.cmbRouter = new System.Windows.Forms.ComboBox();
            this.cmbSensorMeasurementType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSensorMeasurementValue = new System.Windows.Forms.TextBox();
            this.txtSensorMeasurementID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSensorMeasurement = new System.Windows.Forms.DataGridView();
            this.SensorMeasurementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurementValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpCreatedTime = new System.Windows.Forms.DateTimePicker();
            this.cmbSensor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpCreatedTime);
            this.groupBox1.Controls.Add(this.cmbRouter);
            this.groupBox1.Controls.Add(this.cmbSensorMeasurementType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSensor);
            this.groupBox1.Controls.Add(this.txtSensorMeasurementValue);
            this.groupBox1.Controls.Add(this.txtSensorMeasurementID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1218, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Measurements";
            // 
            // cmbRouter
            // 
            this.cmbRouter.FormattingEnabled = true;
            this.cmbRouter.Location = new System.Drawing.Point(898, 87);
            this.cmbRouter.Name = "cmbRouter";
            this.cmbRouter.Size = new System.Drawing.Size(281, 28);
            this.cmbRouter.TabIndex = 8;
            // 
            // cmbSensorMeasurementType
            // 
            this.cmbSensorMeasurementType.FormattingEnabled = true;
            this.cmbSensorMeasurementType.Location = new System.Drawing.Point(898, 142);
            this.cmbSensorMeasurementType.Name = "cmbSensorMeasurementType";
            this.cmbSensorMeasurementType.Size = new System.Drawing.Size(281, 28);
            this.cmbSensorMeasurementType.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(624, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Router :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(624, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sensor Measurement Type :";
            // 
            // txtSensorMeasurementValue
            // 
            this.txtSensorMeasurementValue.Location = new System.Drawing.Point(337, 136);
            this.txtSensorMeasurementValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorMeasurementValue.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorMeasurementValue.Multiline = true;
            this.txtSensorMeasurementValue.Name = "txtSensorMeasurementValue";
            this.txtSensorMeasurementValue.Size = new System.Drawing.Size(281, 35);
            this.txtSensorMeasurementValue.TabIndex = 2;
            // 
            // txtSensorMeasurementID
            // 
            this.txtSensorMeasurementID.Location = new System.Drawing.Point(337, 23);
            this.txtSensorMeasurementID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorMeasurementID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorMeasurementID.Multiline = true;
            this.txtSensorMeasurementID.Name = "txtSensorMeasurementID";
            this.txtSensorMeasurementID.Size = new System.Drawing.Size(281, 35);
            this.txtSensorMeasurementID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(770, 190);
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
            this.btnDelete.Location = new System.Drawing.Point(607, 190);
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
            this.btnUpdate.Location = new System.Drawing.Point(444, 190);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor Measurement Value :";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(281, 190);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sensor Measurement DateTime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(624, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor :";
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
            // dgvSensorMeasurement
            // 
            this.dgvSensorMeasurement.AllowUserToAddRows = false;
            this.dgvSensorMeasurement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSensorMeasurement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSensorMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensorMeasurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorMeasurementID,
            this.SensorID,
            this.SensorName,
            this.RouterID,
            this.RouterName,
            this.SensorMeasurementTypeID,
            this.SensorMeasurementTypeName,
            this.SensorMeasurementDateTime,
            this.SensorMeasurementValue});
            this.dgvSensorMeasurement.Location = new System.Drawing.Point(24, 294);
            this.dgvSensorMeasurement.Name = "dgvSensorMeasurement";
            this.dgvSensorMeasurement.RowHeadersWidth = 51;
            this.dgvSensorMeasurement.RowTemplate.Height = 24;
            this.dgvSensorMeasurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensorMeasurement.Size = new System.Drawing.Size(1206, 212);
            this.dgvSensorMeasurement.TabIndex = 12;
            this.dgvSensorMeasurement.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSensorMeasurement_RowEnter);
            // 
            // SensorMeasurementID
            // 
            this.SensorMeasurementID.DataPropertyName = "SensorMeasurementID";
            this.SensorMeasurementID.HeaderText = "Sensor Measurement ID";
            this.SensorMeasurementID.MinimumWidth = 6;
            this.SensorMeasurementID.Name = "SensorMeasurementID";
            this.SensorMeasurementID.Width = 150;
            // 
            // SensorID
            // 
            this.SensorID.DataPropertyName = "SensorID";
            this.SensorID.HeaderText = "Sensor ID";
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
            // RouterID
            // 
            this.RouterID.DataPropertyName = "RouterID";
            this.RouterID.HeaderText = "Router ID";
            this.RouterID.MinimumWidth = 6;
            this.RouterID.Name = "RouterID";
            this.RouterID.Visible = false;
            this.RouterID.Width = 125;
            // 
            // RouterName
            // 
            this.RouterName.DataPropertyName = "RouterName";
            this.RouterName.HeaderText = "Router Name";
            this.RouterName.MinimumWidth = 6;
            this.RouterName.Name = "RouterName";
            this.RouterName.Width = 107;
            // 
            // SensorMeasurementTypeID
            // 
            this.SensorMeasurementTypeID.DataPropertyName = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.HeaderText = "S.Measurement Type ID";
            this.SensorMeasurementTypeID.MinimumWidth = 6;
            this.SensorMeasurementTypeID.Name = "SensorMeasurementTypeID";
            this.SensorMeasurementTypeID.Visible = false;
            this.SensorMeasurementTypeID.Width = 125;
            // 
            // SensorMeasurementTypeName
            // 
            this.SensorMeasurementTypeName.DataPropertyName = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.HeaderText = "S.Measurement Type Name";
            this.SensorMeasurementTypeName.MinimumWidth = 6;
            this.SensorMeasurementTypeName.Name = "SensorMeasurementTypeName";
            this.SensorMeasurementTypeName.Width = 154;
            // 
            // SensorMeasurementDateTime
            // 
            this.SensorMeasurementDateTime.DataPropertyName = "SensorMeasurementDateTime";
            this.SensorMeasurementDateTime.HeaderText = "S.Measurement DateTime";
            this.SensorMeasurementDateTime.MinimumWidth = 6;
            this.SensorMeasurementDateTime.Name = "SensorMeasurementDateTime";
            this.SensorMeasurementDateTime.Width = 176;
            // 
            // SensorMeasurementValue
            // 
            this.SensorMeasurementValue.DataPropertyName = "SensorMeasurementValue";
            this.SensorMeasurementValue.HeaderText = "S.Measurement Value";
            this.SensorMeasurementValue.MinimumWidth = 6;
            this.SensorMeasurementValue.Name = "SensorMeasurementValue";
            this.SensorMeasurementValue.Width = 154;
            // 
            // dtpCreatedTime
            // 
            this.dtpCreatedTime.Location = new System.Drawing.Point(337, 87);
            this.dtpCreatedTime.Name = "dtpCreatedTime";
            this.dtpCreatedTime.Size = new System.Drawing.Size(281, 26);
            this.dtpCreatedTime.TabIndex = 10;
            // 
            // cmbSensor
            // 
            this.cmbSensor.FormattingEnabled = true;
            this.cmbSensor.Location = new System.Drawing.Point(898, 30);
            this.cmbSensor.Name = "cmbSensor";
            this.cmbSensor.Size = new System.Drawing.Size(281, 28);
            this.cmbSensor.TabIndex = 3;
            // 
            // SensorMeasurementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 518);
            this.Controls.Add(this.dgvSensorMeasurement);
            this.Controls.Add(this.groupBox1);
            this.Name = "SensorMeasurementsForm";
            this.Text = "SensorMeasurementsForm";
            this.Load += new System.EventHandler(this.SensorMeasurementsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorMeasurement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSensorMeasurementID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRouter;
        private System.Windows.Forms.ComboBox cmbSensorMeasurementType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSensorMeasurementValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSensorMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurementValue;
        private System.Windows.Forms.DateTimePicker dtpCreatedTime;
        private System.Windows.Forms.ComboBox cmbSensor;
    }
}