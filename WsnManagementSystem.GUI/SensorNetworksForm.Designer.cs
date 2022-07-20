namespace WsnManagementSystem.GUI
{
    partial class SensorNetworksForm
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
            this.txtSensorNetworkName = new System.Windows.Forms.TextBox();
            this.txtSensorNetworkId = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSensorNetworkDesc = new System.Windows.Forms.TextBox();
            this.dgvSensorNetwork = new System.Windows.Forms.DataGridView();
            this.cmbDomain = new System.Windows.Forms.ComboBox();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.SensorNetworkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworkDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WsnDomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworkCreatedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorNetwork)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSensorNetworkName
            // 
            this.txtSensorNetworkName.Location = new System.Drawing.Point(386, 82);
            this.txtSensorNetworkName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorNetworkName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkName.Multiline = true;
            this.txtSensorNetworkName.Name = "txtSensorNetworkName";
            this.txtSensorNetworkName.Size = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkName.TabIndex = 21;
            // 
            // txtSensorNetworkId
            // 
            this.txtSensorNetworkId.Location = new System.Drawing.Point(386, 19);
            this.txtSensorNetworkId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorNetworkId.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkId.Multiline = true;
            this.txtSensorNetworkId.Name = "txtSensorNetworkId";
            this.txtSensorNetworkId.Size = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkId.TabIndex = 22;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(877, 218);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(157, 50);
            this.btnSet.TabIndex = 17;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(701, 218);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(524, 218);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 50);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(346, 218);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sensor Network Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sensor Network Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sensor Network ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(696, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Domain Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(696, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sensor Network Created Date Time :";
            // 
            // txtSensorNetworkDesc
            // 
            this.txtSensorNetworkDesc.Location = new System.Drawing.Point(386, 144);
            this.txtSensorNetworkDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSensorNetworkDesc.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkDesc.Multiline = true;
            this.txtSensorNetworkDesc.Name = "txtSensorNetworkDesc";
            this.txtSensorNetworkDesc.Size = new System.Drawing.Size(281, 35);
            this.txtSensorNetworkDesc.TabIndex = 21;
            // 
            // dgvSensorNetwork
            // 
            this.dgvSensorNetwork.AllowUserToAddRows = false;
            this.dgvSensorNetwork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvSensorNetwork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSensorNetwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensorNetwork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorNetworkID,
            this.SensorNetworkName,
            this.SensorNetworkDesc,
            this.DomainID,
            this.WsnDomainName,
            this.SensorNetworkCreatedDateTime});
            this.dgvSensorNetwork.Location = new System.Drawing.Point(33, 287);
            this.dgvSensorNetwork.Name = "dgvSensorNetwork";
            this.dgvSensorNetwork.RowHeadersWidth = 51;
            this.dgvSensorNetwork.RowTemplate.Height = 24;
            this.dgvSensorNetwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSensorNetwork.Size = new System.Drawing.Size(1302, 302);
            this.dgvSensorNetwork.TabIndex = 23;
            this.dgvSensorNetwork.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSensorNetwork_RowEnter);
            // 
            // cmbDomain
            // 
            this.cmbDomain.FormattingEnabled = true;
            this.cmbDomain.Location = new System.Drawing.Point(1054, 86);
            this.cmbDomain.Name = "cmbDomain";
            this.cmbDomain.Size = new System.Drawing.Size(281, 24);
            this.cmbDomain.TabIndex = 24;
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreatedDate.Location = new System.Drawing.Point(1054, 29);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCreatedDate.TabIndex = 25;
            // 
            // SensorNetworkID
            // 
            this.SensorNetworkID.DataPropertyName = "SensorNetworkID";
            this.SensorNetworkID.HeaderText = "Sensor Network ID";
            this.SensorNetworkID.MinimumWidth = 6;
            this.SensorNetworkID.Name = "SensorNetworkID";
            this.SensorNetworkID.Width = 123;
            // 
            // SensorNetworkName
            // 
            this.SensorNetworkName.DataPropertyName = "SensorNetworkName";
            this.SensorNetworkName.HeaderText = "Sensor Network Name";
            this.SensorNetworkName.MinimumWidth = 6;
            this.SensorNetworkName.Name = "SensorNetworkName";
            this.SensorNetworkName.Width = 156;
            // 
            // SensorNetworkDesc
            // 
            this.SensorNetworkDesc.DataPropertyName = "SensorNetworkDescription";
            this.SensorNetworkDesc.HeaderText = "Sensor Network Description";
            this.SensorNetworkDesc.MinimumWidth = 6;
            this.SensorNetworkDesc.Name = "SensorNetworkDesc";
            this.SensorNetworkDesc.Width = 184;
            // 
            // DomainID
            // 
            this.DomainID.DataPropertyName = "DomainID";
            this.DomainID.HeaderText = "Domain ID";
            this.DomainID.MinimumWidth = 6;
            this.DomainID.Name = "DomainID";
            this.DomainID.Visible = false;
            this.DomainID.Width = 92;
            // 
            // WsnDomainName
            // 
            this.WsnDomainName.DataPropertyName = "WsnDomainName";
            this.WsnDomainName.HeaderText = "Wsn Domain Name";
            this.WsnDomainName.MinimumWidth = 6;
            this.WsnDomainName.Name = "WsnDomainName";
            this.WsnDomainName.Width = 140;
            // 
            // SensorNetworkCreatedDateTime
            // 
            this.SensorNetworkCreatedDateTime.DataPropertyName = "SensorNetworkCreatedDateTime";
            this.SensorNetworkCreatedDateTime.HeaderText = "Created Date Time";
            this.SensorNetworkCreatedDateTime.MinimumWidth = 6;
            this.SensorNetworkCreatedDateTime.Name = "SensorNetworkCreatedDateTime";
            this.SensorNetworkCreatedDateTime.Width = 110;
            // 
            // SensorNetworksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 601);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.dgvSensorNetwork);
            this.Controls.Add(this.cmbDomain);
            this.Controls.Add(this.txtSensorNetworkDesc);
            this.Controls.Add(this.txtSensorNetworkName);
            this.Controls.Add(this.txtSensorNetworkId);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SensorNetworksForm";
            this.Text = "SensorNetworksForm";
            this.Load += new System.EventHandler(this.SensorNetworksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensorNetwork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSensorNetworkName;
        private System.Windows.Forms.TextBox txtSensorNetworkId;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSensorNetworkDesc;
        private System.Windows.Forms.DataGridView dgvSensorNetwork;
        private System.Windows.Forms.ComboBox cmbDomain;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WsnDomainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworkCreatedDateTime;
    }
}