namespace WsnManagementSystem.GUI
{
    partial class WsnCoordinatorsForm
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
            this.cmbSensorNetwork = new System.Windows.Forms.ComboBox();
            this.cmbCoordinator = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWsnCoordinator = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordinatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordinatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWsnCoordinator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSensorNetwork);
            this.groupBox1.Controls.Add(this.cmbCoordinator);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 260);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WsnCoordinatorForm";
            // 
            // cmbSensorNetwork
            // 
            this.cmbSensorNetwork.FormattingEnabled = true;
            this.cmbSensorNetwork.Location = new System.Drawing.Point(403, 83);
            this.cmbSensorNetwork.Name = "cmbSensorNetwork";
            this.cmbSensorNetwork.Size = new System.Drawing.Size(281, 28);
            this.cmbSensorNetwork.TabIndex = 3;
            // 
            // cmbCoordinator
            // 
            this.cmbCoordinator.FormattingEnabled = true;
            this.cmbCoordinator.Location = new System.Drawing.Point(403, 139);
            this.cmbCoordinator.Name = "cmbCoordinator";
            this.cmbCoordinator.Size = new System.Drawing.Size(281, 28);
            this.cmbCoordinator.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(403, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(281, 35);
            this.txtId.TabIndex = 2;
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
            this.label5.Size = new System.Drawing.Size(208, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wsn Sensor Network :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coordinator :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dgvWsnCoordinator
            // 
            this.dgvWsnCoordinator.AllowUserToAddRows = false;
            this.dgvWsnCoordinator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWsnCoordinator.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvWsnCoordinator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWsnCoordinator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SensorNetworkID,
            this.SensorNetworkName,
            this.CoordinatorID,
            this.CoordinatorName});
            this.dgvWsnCoordinator.Location = new System.Drawing.Point(24, 302);
            this.dgvWsnCoordinator.Name = "dgvWsnCoordinator";
            this.dgvWsnCoordinator.RowHeadersWidth = 51;
            this.dgvWsnCoordinator.RowTemplate.Height = 24;
            this.dgvWsnCoordinator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWsnCoordinator.Size = new System.Drawing.Size(764, 194);
            this.dgvWsnCoordinator.TabIndex = 10;
            this.dgvWsnCoordinator.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWsnCoordinator_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 49;
            // 
            // SensorNetworkID
            // 
            this.SensorNetworkID.DataPropertyName = "SensorNetworkID";
            this.SensorNetworkID.HeaderText = "Wsn SensorNetwork ID";
            this.SensorNetworkID.MinimumWidth = 6;
            this.SensorNetworkID.Name = "SensorNetworkID";
            this.SensorNetworkID.Visible = false;
            this.SensorNetworkID.Width = 125;
            // 
            // SensorNetworkName
            // 
            this.SensorNetworkName.DataPropertyName = "SensorNetworkName";
            this.SensorNetworkName.HeaderText = "Wsn Sensor Network";
            this.SensorNetworkName.MinimumWidth = 6;
            this.SensorNetworkName.Name = "SensorNetworkName";
            this.SensorNetworkName.Width = 147;
            // 
            // CoordinatorID
            // 
            this.CoordinatorID.DataPropertyName = "CoordinatorID";
            this.CoordinatorID.HeaderText = "CoordinatorID";
            this.CoordinatorID.MinimumWidth = 6;
            this.CoordinatorID.Name = "CoordinatorID";
            this.CoordinatorID.Visible = false;
            this.CoordinatorID.Width = 125;
            // 
            // CoordinatorName
            // 
            this.CoordinatorName.DataPropertyName = "CoordinatorName";
            this.CoordinatorName.HeaderText = "Coordinator";
            this.CoordinatorName.MinimumWidth = 6;
            this.CoordinatorName.Name = "CoordinatorName";
            this.CoordinatorName.Width = 106;
            // 
            // WsnCoordinatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 508);
            this.Controls.Add(this.dgvWsnCoordinator);
            this.Controls.Add(this.groupBox1);
            this.Name = "WsnCoordinatorsForm";
            this.Text = "WsnCoordinatorsForm";
            this.Load += new System.EventHandler(this.WsnCoordinatorsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWsnCoordinator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCoordinator;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSensorNetwork;
        private System.Windows.Forms.DataGridView dgvWsnCoordinator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordinatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordinatorName;
    }
}