namespace WsnManagementSystem.GUI
{
    partial class DistrictsForm
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
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtDistrictID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDistrict = new System.Windows.Forms.DataGridView();
            this.DistrictID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrict)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCounty);
            this.groupBox1.Controls.Add(this.txtDistrictName);
            this.groupBox1.Controls.Add(this.txtDistrictID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 283);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counties";
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(365, 135);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(281, 28);
            this.cmbCounty.TabIndex = 3;
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(365, 86);
            this.txtDistrictName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistrictName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDistrictName.Multiline = true;
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(281, 35);
            this.txtDistrictName.TabIndex = 2;
            // 
            // txtDistrictID
            // 
            this.txtDistrictID.Location = new System.Drawing.Point(365, 23);
            this.txtDistrictID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistrictID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtDistrictID.Multiline = true;
            this.txtDistrictID.Name = "txtDistrictID";
            this.txtDistrictID.Size = new System.Drawing.Size(281, 35);
            this.txtDistrictID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(559, 209);
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
            this.btnDelete.Location = new System.Drawing.Point(381, 209);
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
            this.btnUpdate.Location = new System.Drawing.Point(209, 209);
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
            this.btnInsert.Location = new System.Drawing.Point(35, 209);
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
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "County Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "District Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "District ID :";
            // 
            // dgvDistrict
            // 
            this.dgvDistrict.AllowUserToAddRows = false;
            this.dgvDistrict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDistrict.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDistrict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistrict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DistrictID,
            this.DistrictName,
            this.CountyID,
            this.CountyName});
            this.dgvDistrict.Location = new System.Drawing.Point(12, 330);
            this.dgvDistrict.Name = "dgvDistrict";
            this.dgvDistrict.RowHeadersWidth = 51;
            this.dgvDistrict.RowTemplate.Height = 24;
            this.dgvDistrict.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistrict.Size = new System.Drawing.Size(776, 187);
            this.dgvDistrict.TabIndex = 8;
            this.dgvDistrict.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistrict_RowEnter);
            // 
            // DistrictID
            // 
            this.DistrictID.DataPropertyName = "DistrictID";
            this.DistrictID.HeaderText = "District ID";
            this.DistrictID.MinimumWidth = 6;
            this.DistrictID.Name = "DistrictID";
            this.DistrictID.Width = 92;
            // 
            // DistrictName
            // 
            this.DistrictName.DataPropertyName = "DistrictName";
            this.DistrictName.HeaderText = "District Name";
            this.DistrictName.MinimumWidth = 6;
            this.DistrictName.Name = "DistrictName";
            this.DistrictName.Width = 116;
            // 
            // CountyID
            // 
            this.CountyID.DataPropertyName = "CountyID";
            this.CountyID.HeaderText = "CountyID";
            this.CountyID.MinimumWidth = 6;
            this.CountyID.Name = "CountyID";
            this.CountyID.Visible = false;
            this.CountyID.Width = 125;
            // 
            // CountyName
            // 
            this.CountyName.DataPropertyName = "CountyName";
            this.CountyName.HeaderText = "County Name";
            this.CountyName.MinimumWidth = 6;
            this.CountyName.Name = "CountyName";
            this.CountyName.Width = 117;
            // 
            // DistrictsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 549);
            this.Controls.Add(this.dgvDistrict);
            this.Controls.Add(this.groupBox1);
            this.Name = "DistrictsForm";
            this.Text = "DistrictsForm";
            this.Load += new System.EventHandler(this.DistrictsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtDistrictID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyName;
    }
}