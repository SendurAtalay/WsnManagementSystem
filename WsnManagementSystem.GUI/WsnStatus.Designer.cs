namespace WsnManagementSystem.GUI
{
    partial class WsnStatus
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
            this.txtStatueName = new System.Windows.Forms.TextBox();
            this.txtStatueID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvWsnStatus = new System.Windows.Forms.DataGridView();
            this.WsnStatueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WsnStatueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWsnStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatueName);
            this.groupBox1.Controls.Add(this.txtStatueID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WsnStatus";
            // 
            // txtStatueName
            // 
            this.txtStatueName.Location = new System.Drawing.Point(274, 70);
            this.txtStatueName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatueName.MinimumSize = new System.Drawing.Size(212, 29);
            this.txtStatueName.Multiline = true;
            this.txtStatueName.Name = "txtStatueName";
            this.txtStatueName.Size = new System.Drawing.Size(212, 29);
            this.txtStatueName.TabIndex = 2;
            // 
            // txtStatueID
            // 
            this.txtStatueID.Location = new System.Drawing.Point(274, 19);
            this.txtStatueID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatueID.MinimumSize = new System.Drawing.Size(212, 29);
            this.txtStatueID.Multiline = true;
            this.txtStatueID.Name = "txtStatueID";
            this.txtStatueID.Size = new System.Drawing.Size(212, 29);
            this.txtStatueID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(425, 128);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(118, 41);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(292, 128);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(159, 128);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 41);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(26, 128);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 41);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "WsnStatue Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WsnStatue ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvWsnStatus);
            this.groupBox2.Location = new System.Drawing.Point(11, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 193);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvWsnStatus
            // 
            this.dgvWsnStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWsnStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WsnStatueID,
            this.WsnStatueName,
            this.SensorNetworks});
            this.dgvWsnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWsnStatus.Location = new System.Drawing.Point(3, 16);
            this.dgvWsnStatus.Name = "dgvWsnStatus";
            this.dgvWsnStatus.Size = new System.Drawing.Size(576, 174);
            this.dgvWsnStatus.TabIndex = 0;
            // 
            // WsnStatueID
            // 
            this.WsnStatueID.DataPropertyName = "WsnStatueID";
            this.WsnStatueID.HeaderText = "Statue No";
            this.WsnStatueID.Name = "WsnStatueID";
            // 
            // WsnStatueName
            // 
            this.WsnStatueName.DataPropertyName = "WsnStatueName";
            this.WsnStatueName.HeaderText = "Statue Name";
            this.WsnStatueName.Name = "WsnStatueName";
            // 
            // SensorNetworks
            // 
            this.SensorNetworks.DataPropertyName = "SensorNetworks";
            this.SensorNetworks.HeaderText = "Sensor Networks";
            this.SensorNetworks.Name = "SensorNetworks";
            this.SensorNetworks.Visible = false;
            // 
            // WsnStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WsnStatus";
            this.Text = "WsnStatus";
            this.Load += new System.EventHandler(this.WsnStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWsnStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatueName;
        private System.Windows.Forms.TextBox txtStatueID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvWsnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn WsnStatueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WsnStatueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworks;
    }
}