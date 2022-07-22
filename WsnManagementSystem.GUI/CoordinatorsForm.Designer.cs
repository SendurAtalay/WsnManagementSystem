namespace WsnManagementSystem.GUI
{
    partial class CoordinatorsForm
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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtCoordinatorName = new System.Windows.Forms.TextBox();
            this.txtCoordinatorDescription = new System.Windows.Forms.TextBox();
            this.txtCoordinatorID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLongtitude = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.dgvCoordinators = new System.Windows.Forms.DataGridView();
            this.CoordinatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordinatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordinatorDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longtitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinators)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDistrict);
            this.groupBox1.Controls.Add(this.cmbCounty);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.cmbCountry);
            this.groupBox1.Controls.Add(this.txtLongtitude);
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.txtCoordinatorName);
            this.groupBox1.Controls.Add(this.txtCoordinatorDescription);
            this.groupBox1.Controls.Add(this.txtCoordinatorID);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1167, 395);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counties";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(241, 212);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(281, 28);
            this.cmbCountry.TabIndex = 3;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(758, 207);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLatitude.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtLatitude.Multiline = true;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(281, 35);
            this.txtLatitude.TabIndex = 2;
            // 
            // txtCoordinatorName
            // 
            this.txtCoordinatorName.Location = new System.Drawing.Point(241, 82);
            this.txtCoordinatorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoordinatorName.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtCoordinatorName.Multiline = true;
            this.txtCoordinatorName.Name = "txtCoordinatorName";
            this.txtCoordinatorName.Size = new System.Drawing.Size(281, 35);
            this.txtCoordinatorName.TabIndex = 2;
            // 
            // txtCoordinatorDescription
            // 
            this.txtCoordinatorDescription.Location = new System.Drawing.Point(241, 143);
            this.txtCoordinatorDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoordinatorDescription.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtCoordinatorDescription.Multiline = true;
            this.txtCoordinatorDescription.Name = "txtCoordinatorDescription";
            this.txtCoordinatorDescription.Size = new System.Drawing.Size(281, 35);
            this.txtCoordinatorDescription.TabIndex = 2;
            // 
            // txtCoordinatorID
            // 
            this.txtCoordinatorID.Location = new System.Drawing.Point(241, 23);
            this.txtCoordinatorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCoordinatorID.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtCoordinatorID.Multiline = true;
            this.txtCoordinatorID.Name = "txtCoordinatorID";
            this.txtCoordinatorID.Size = new System.Drawing.Size(281, 35);
            this.txtCoordinatorID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSet.Location = new System.Drawing.Point(720, 322);
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
            this.btnDelete.Location = new System.Drawing.Point(542, 322);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(562, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "County :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(365, 322);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(562, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Latitude :";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(178, 322);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(562, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Country :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(562, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "District :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(562, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Longtitude :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Coordinator Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coordinator Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordinator ID :";
            // 
            // txtLongtitude
            // 
            this.txtLongtitude.Location = new System.Drawing.Point(758, 260);
            this.txtLongtitude.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLongtitude.MinimumSize = new System.Drawing.Size(281, 35);
            this.txtLongtitude.Multiline = true;
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.Size = new System.Drawing.Size(281, 35);
            this.txtLongtitude.TabIndex = 2;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(758, 30);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(281, 28);
            this.cmbCity.TabIndex = 3;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(758, 82);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(281, 28);
            this.cmbCounty.TabIndex = 3;
            this.cmbCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCounty_SelectedIndexChanged);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(758, 143);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(281, 28);
            this.cmbDistrict.TabIndex = 3;
            // 
            // dgvCoordinators
            // 
            this.dgvCoordinators.AllowUserToAddRows = false;
            this.dgvCoordinators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCoordinators.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCoordinators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoordinatorID,
            this.CoordinatorName,
            this.CoordinatorDescription,
            this.CountryID,
            this.CountryName,
            this.CityID,
            this.CityName,
            this.CountyID,
            this.CountyName,
            this.DistrictID,
            this.DistrictName,
            this.Latitude,
            this.Longtitude});
            this.dgvCoordinators.Location = new System.Drawing.Point(12, 426);
            this.dgvCoordinators.Name = "dgvCoordinators";
            this.dgvCoordinators.RowHeadersWidth = 51;
            this.dgvCoordinators.RowTemplate.Height = 24;
            this.dgvCoordinators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoordinators.Size = new System.Drawing.Size(1167, 253);
            this.dgvCoordinators.TabIndex = 8;
            this.dgvCoordinators.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoordinators_RowEnter);
            // 
            // CoordinatorID
            // 
            this.CoordinatorID.DataPropertyName = "CoordinatorID";
            this.CoordinatorID.HeaderText = "Coordinator ID";
            this.CoordinatorID.MinimumWidth = 6;
            this.CoordinatorID.Name = "CoordinatorID";
            this.CoordinatorID.Width = 112;
            // 
            // CoordinatorName
            // 
            this.CoordinatorName.DataPropertyName = "CoordinatorName";
            this.CoordinatorName.HeaderText = "Coordinator Name";
            this.CoordinatorName.MinimumWidth = 6;
            this.CoordinatorName.Name = "CoordinatorName";
            this.CoordinatorName.Width = 134;
            // 
            // CoordinatorDescription
            // 
            this.CoordinatorDescription.DataPropertyName = "CoordinatorDescription";
            this.CoordinatorDescription.HeaderText = "Coordinator Description";
            this.CoordinatorDescription.MinimumWidth = 6;
            this.CoordinatorDescription.Name = "CoordinatorDescription";
            this.CoordinatorDescription.Width = 162;
            // 
            // CountryID
            // 
            this.CountryID.DataPropertyName = "CountryID";
            this.CountryID.HeaderText = "Country ID";
            this.CountryID.MinimumWidth = 6;
            this.CountryID.Name = "CountryID";
            this.CountryID.Visible = false;
            this.CountryID.Width = 125;
            // 
            // CountryName
            // 
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Country Name";
            this.CountryName.MinimumWidth = 6;
            this.CountryName.Name = "CountryName";
            this.CountryName.Width = 111;
            // 
            // CityID
            // 
            this.CityID.DataPropertyName = "CityID";
            this.CityID.HeaderText = "City ID";
            this.CityID.MinimumWidth = 6;
            this.CityID.Name = "CityID";
            this.CityID.Visible = false;
            this.CityID.Width = 125;
            // 
            // CityName
            // 
            this.CityName.DataPropertyName = "CityName";
            this.CityName.HeaderText = "City Name";
            this.CityName.MinimumWidth = 6;
            this.CityName.Name = "CityName";
            this.CityName.Width = 91;
            // 
            // CountyID
            // 
            this.CountyID.DataPropertyName = "CountyID";
            this.CountyID.HeaderText = "County ID";
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
            this.CountyName.Width = 108;
            // 
            // DistrictID
            // 
            this.DistrictID.DataPropertyName = "DistrictID";
            this.DistrictID.HeaderText = "District ID";
            this.DistrictID.MinimumWidth = 6;
            this.DistrictID.Name = "DistrictID";
            this.DistrictID.Visible = false;
            this.DistrictID.Width = 125;
            // 
            // DistrictName
            // 
            this.DistrictName.DataPropertyName = "DistrictName";
            this.DistrictName.HeaderText = "District Name";
            this.DistrictName.MinimumWidth = 6;
            this.DistrictName.Name = "DistrictName";
            this.DistrictName.Width = 107;
            // 
            // Latitude
            // 
            this.Latitude.DataPropertyName = "Latitude";
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.MinimumWidth = 6;
            this.Latitude.Name = "Latitude";
            this.Latitude.Width = 83;
            // 
            // Longtitude
            // 
            this.Longtitude.DataPropertyName = "Longtitude";
            this.Longtitude.HeaderText = "Longtitude";
            this.Longtitude.MinimumWidth = 6;
            this.Longtitude.Name = "Longtitude";
            this.Longtitude.Width = 98;
            // 
            // CoordinatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 704);
            this.Controls.Add(this.dgvCoordinators);
            this.Controls.Add(this.groupBox1);
            this.Name = "CoordinatorsForm";
            this.Text = "CoordinatorsForm";
            this.Load += new System.EventHandler(this.CoordinatorsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtCoordinatorName;
        private System.Windows.Forms.TextBox txtCoordinatorDescription;
        private System.Windows.Forms.TextBox txtCoordinatorID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtLongtitude;
        private System.Windows.Forms.DataGridView dgvCoordinators;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordinatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordinatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoordinatorDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longtitude;
    }
}