namespace WsnManagementSystem.GUI
{
    partial class RouterSensorsForm
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
            this.cmbSensor = new System.Windows.Forms.ComboBox();
            this.txtRouterSensorID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRouterSensor = new System.Windows.Forms.DataGridView();
            this.RouterSensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouterSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRouter);
            this.groupBox1.Controls.Add(this.cmbSensor);
            this.groupBox1.Controls.Add(this.txtRouterSensorID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WsnCoordinatorForm";
            // 
            // cmbRouter
            // 
            this.cmbRouter.FormattingEnabled = true;
            this.cmbRouter.Location = new System.Drawing.Point(403, 83);
            this.cmbRouter.Name = "cmbRouter";
            this.cmbRouter.Size = new System.Drawing.Size(281, 28);
            this.cmbRouter.TabIndex = 3;
            // 
            // cmbSensor
            // 
            this.cmbSensor.FormattingEnabled = true;
            this.cmbSensor.Location = new System.Drawing.Point(403, 139);
            this.cmbSensor.Name = "cmbSensor";
            this.cmbSensor.Size = new System.Drawing.Size(281, 28);
            this.cmbSensor.TabIndex = 3;
            // 
            // txtRouterSensorID
            // 
            this.txtRouterSensorID.Location = new System.Drawing.Point(403, 23);
            this.txtRouterSensorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRouterSensorID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtRouterSensorID.Multiline = true;
            this.txtRouterSensorID.Name = "txtRouterSensorID";
            this.txtRouterSensorID.Size = new System.Drawing.Size(281, 35);
            this.txtRouterSensorID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(597, 190);
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
            this.btnDelete.Location = new System.Drawing.Point(419, 190);
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
            this.btnUpdate.Location = new System.Drawing.Point(241, 190);
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
            this.btnInsert.Location = new System.Drawing.Point(67, 190);
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
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Router :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 142);
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
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Router Sensor ID :";
            // 
            // dgvRouterSensor
            // 
            this.dgvRouterSensor.AllowUserToAddRows = false;
            this.dgvRouterSensor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRouterSensor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvRouterSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRouterSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouterSensorID,
            this.RouterID,
            this.RouterName,
            this.SensorID,
            this.SensorName});
            this.dgvRouterSensor.Location = new System.Drawing.Point(13, 300);
            this.dgvRouterSensor.Name = "dgvRouterSensor";
            this.dgvRouterSensor.RowHeadersWidth = 51;
            this.dgvRouterSensor.RowTemplate.Height = 24;
            this.dgvRouterSensor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRouterSensor.Size = new System.Drawing.Size(775, 150);
            this.dgvRouterSensor.TabIndex = 11;
            this.dgvRouterSensor.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRouterSensor_RowEnter);
            // 
            // RouterSensorID
            // 
            this.RouterSensorID.DataPropertyName = "RouterSensorID";
            this.RouterSensorID.HeaderText = "RouterSensor ID";
            this.RouterSensorID.MinimumWidth = 6;
            this.RouterSensorID.Name = "RouterSensorID";
            this.RouterSensorID.Width = 124;
            // 
            // RouterID
            // 
            this.RouterID.DataPropertyName = "RouterID";
            this.RouterID.HeaderText = "RouterID";
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
            this.SensorName.HeaderText = "SensorName";
            this.SensorName.MinimumWidth = 6;
            this.SensorName.Name = "SensorName";
            this.SensorName.Width = 116;
            // 
            // RouterSensorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 473);
            this.Controls.Add(this.dgvRouterSensor);
            this.Controls.Add(this.groupBox1);
            this.Name = "RouterSensorsForm";
            this.Text = "RouterSensorsForm";
            this.Load += new System.EventHandler(this.RouterSensorsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouterSensor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRouter;
        private System.Windows.Forms.ComboBox cmbSensor;
        private System.Windows.Forms.TextBox txtRouterSensorID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRouterSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterSensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
    }
}