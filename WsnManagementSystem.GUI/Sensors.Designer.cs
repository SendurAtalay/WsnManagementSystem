namespace WsnManagementSystem.GUI
{
    partial class Sensors
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
            this.txtSensorDefinition = new System.Windows.Forms.TextBox();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.txtSensorID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.SensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefinationOfSensorMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterSensors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorMeasurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorDefination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSensorDefinition);
            this.groupBox1.Controls.Add(this.txtSensorName);
            this.groupBox1.Controls.Add(this.txtSensorID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(829, 298);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // txtSensorDefinition
            // 
            this.txtSensorDefinition.Location = new System.Drawing.Point(365, 142);
            this.txtSensorDefinition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorDefinition.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorDefinition.Multiline = true;
            this.txtSensorDefinition.Name = "txtSensorDefinition";
            this.txtSensorDefinition.Size = new System.Drawing.Size(281, 35);
            this.txtSensorDefinition.TabIndex = 2;
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(365, 86);
            this.txtSensorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorName.Multiline = true;
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(281, 35);
            this.txtSensorName.TabIndex = 2;
            // 
            // txtSensorID
            // 
            this.txtSensorID.Location = new System.Drawing.Point(365, 23);
            this.txtSensorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorID.Multiline = true;
            this.txtSensorID.Name = "txtSensorID";
            this.txtSensorID.Size = new System.Drawing.Size(281, 35);
            this.txtSensorID.TabIndex = 2;
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
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(40, 222);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sensor Definition :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 86);
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
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSensors);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(828, 278);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvSensors
            // 
            this.dgvSensors.AllowUserToAddRows = false;
            this.dgvSensors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSensors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorID,
            this.DefinationOfSensorMeasurement,
            this.RouterSensors,
            this.SensorMeasurements,
            this.SensorName,
            this.SensorDefination});
            this.dgvSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSensors.Location = new System.Drawing.Point(4, 19);
            this.dgvSensors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.RowHeadersWidth = 51;
            this.dgvSensors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensors.Size = new System.Drawing.Size(820, 255);
            this.dgvSensors.TabIndex = 0;
            this.dgvSensors.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSensors_RowEnter);
            // 
            // SensorID
            // 
            this.SensorID.DataPropertyName = "SensorID";
            this.SensorID.HeaderText = "Sensor No";
            this.SensorID.MinimumWidth = 6;
            this.SensorID.Name = "SensorID";
            this.SensorID.Width = 92;
            // 
            // DefinationOfSensorMeasurement
            // 
            this.DefinationOfSensorMeasurement.DataPropertyName = "DefinationOfSensorMeasurements";
            this.DefinationOfSensorMeasurement.HeaderText = "Definition of Sensor Measurement";
            this.DefinationOfSensorMeasurement.MinimumWidth = 6;
            this.DefinationOfSensorMeasurement.Name = "DefinationOfSensorMeasurement";
            this.DefinationOfSensorMeasurement.Visible = false;
            this.DefinationOfSensorMeasurement.Width = 125;
            // 
            // RouterSensors
            // 
            this.RouterSensors.DataPropertyName = "RouterSensors";
            this.RouterSensors.HeaderText = "Router Sensors";
            this.RouterSensors.MinimumWidth = 6;
            this.RouterSensors.Name = "RouterSensors";
            this.RouterSensors.Visible = false;
            this.RouterSensors.Width = 125;
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
            // SensorName
            // 
            this.SensorName.DataPropertyName = "SensorName";
            this.SensorName.HeaderText = "Sensor Name";
            this.SensorName.MinimumWidth = 6;
            this.SensorName.Name = "SensorName";
            this.SensorName.Width = 110;
            // 
            // SensorDefination
            // 
            this.SensorDefination.DataPropertyName = "SensorDefination";
            this.SensorDefination.HeaderText = "Sensor Definition";
            this.SensorDefination.MinimumWidth = 6;
            this.SensorDefination.Name = "SensorDefination";
            this.SensorDefination.Width = 126;
            // 
            // Sensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sensors";
            this.Text = "Sensorscs";
            this.Load += new System.EventHandler(this.Sensorscs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSensorDefinition;
        private System.Windows.Forms.TextBox txtSensorName;
        private System.Windows.Forms.TextBox txtSensorID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefinationOfSensorMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterSensors;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorMeasurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorDefination;
    }
}