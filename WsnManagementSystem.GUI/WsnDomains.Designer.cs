namespace WsnManagementSystem.GUI
{
    partial class WsnDomains
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
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtDomainID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDomains = new System.Windows.Forms.DataGridView();
            this.WsnDomainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensorNetworks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WsnDomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDomainName);
            this.groupBox1.Controls.Add(this.txtDomainID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WsnDomains";
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(365, 86);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomainName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDomainName.Multiline = true;
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(281, 35);
            this.txtDomainName.TabIndex = 2;
            // 
            // txtDomainID
            // 
            this.txtDomainID.Location = new System.Drawing.Point(365, 23);
            this.txtDomainID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomainID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDomainID.Multiline = true;
            this.txtDomainID.Name = "txtDomainID";
            this.txtDomainID.Size = new System.Drawing.Size(281, 35);
            this.txtDomainID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(567, 158);
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
            this.btnDelete.Location = new System.Drawing.Point(389, 158);
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
            this.btnUpdate.Location = new System.Drawing.Point(212, 158);
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
            this.btnInsert.Location = new System.Drawing.Point(35, 158);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wsn Domain Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WsnDomain ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDomains);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(776, 258);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvDomains
            // 
            this.dgvDomains.AllowUserToAddRows = false;
            this.dgvDomains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDomains.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDomains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WsnDomainID,
            this.SensorNetworks,
            this.WsnDomainName});
            this.dgvDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDomains.Location = new System.Drawing.Point(4, 19);
            this.dgvDomains.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDomains.Name = "dgvDomains";
            this.dgvDomains.RowHeadersWidth = 51;
            this.dgvDomains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomains.Size = new System.Drawing.Size(768, 235);
            this.dgvDomains.TabIndex = 0;
            this.dgvDomains.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDomains_RowEnter);
            // 
            // WsnDomainID
            // 
            this.WsnDomainID.DataPropertyName = "WsnDomainID";
            this.WsnDomainID.HeaderText = "Domain No";
            this.WsnDomainID.MinimumWidth = 6;
            this.WsnDomainID.Name = "WsnDomainID";
            this.WsnDomainID.Width = 104;
            // 
            // SensorNetworks
            // 
            this.SensorNetworks.DataPropertyName = "SensorNetworks";
            this.SensorNetworks.HeaderText = "Sensor Networks";
            this.SensorNetworks.MinimumWidth = 6;
            this.SensorNetworks.Name = "SensorNetworks";
            this.SensorNetworks.Visible = false;
            this.SensorNetworks.Width = 125;
            // 
            // WsnDomainName
            // 
            this.WsnDomainName.DataPropertyName = "WsnDomainName";
            this.WsnDomainName.HeaderText = "Domain Name";
            this.WsnDomainName.MinimumWidth = 6;
            this.WsnDomainName.Name = "WsnDomainName";
            this.WsnDomainName.Width = 123;
            // 
            // WsnDomains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WsnDomains";
            this.Text = "WsnDomains";
            this.Load += new System.EventHandler(this.WsnDomains_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtDomainID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDomains;
        private System.Windows.Forms.DataGridViewTextBoxColumn WsnDomainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensorNetworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn WsnDomainName;
    }
}