namespace UserMasterMaintenance
{
	partial class UserMasterMaintenance_ListDisplay
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.usersDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.usersDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.checkBoxDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAffiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersDataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataClassBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "追加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(114, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 47);
			this.button2.TabIndex = 1;
			this.button2.Text = "更新";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(216, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 47);
			this.button3.TabIndex = 2;
			this.button3.Text = "削除";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// usersDataBindingSource
			// 
			this.usersDataBindingSource.DataSource = typeof(UserMasterMaintenance.PropertiesClass.UsersData);
			// 
			// usersDataBindingSource1
			// 
			this.usersDataBindingSource1.DataSource = typeof(UserMasterMaintenance.PropertiesClass.UsersData);
			// 
			// usersDataBindingSource2
			// 
			this.usersDataBindingSource2.DataSource = typeof(UserMasterMaintenance.PropertiesClass.UsersData);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxDataGridViewCheckBoxColumn,
            this.dataIdDataGridViewTextBoxColumn,
            this.dataNameDataGridViewTextBoxColumn,
            this.dataAgeDataGridViewTextBoxColumn,
            this.dataGenderDataGridViewTextBoxColumn,
            this.dataAffiliationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.usersDataClassBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 65);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(824, 373);
			this.dataGridView1.TabIndex = 4;
			// 
			// checkBoxDataGridViewCheckBoxColumn
			// 
			this.checkBoxDataGridViewCheckBoxColumn.DataPropertyName = "CheckBox";
			this.checkBoxDataGridViewCheckBoxColumn.FalseValue = "false";
			this.checkBoxDataGridViewCheckBoxColumn.HeaderText = "";
			this.checkBoxDataGridViewCheckBoxColumn.Name = "checkBoxDataGridViewCheckBoxColumn";
			this.checkBoxDataGridViewCheckBoxColumn.TrueValue = "true";
			this.checkBoxDataGridViewCheckBoxColumn.Width = 30;
			// 
			// dataIdDataGridViewTextBoxColumn
			// 
			this.dataIdDataGridViewTextBoxColumn.DataPropertyName = "DataId";
			this.dataIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.dataIdDataGridViewTextBoxColumn.Name = "dataIdDataGridViewTextBoxColumn";
			this.dataIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataIdDataGridViewTextBoxColumn.Width = 150;
			// 
			// dataNameDataGridViewTextBoxColumn
			// 
			this.dataNameDataGridViewTextBoxColumn.DataPropertyName = "DataName";
			this.dataNameDataGridViewTextBoxColumn.HeaderText = "名前";
			this.dataNameDataGridViewTextBoxColumn.Name = "dataNameDataGridViewTextBoxColumn";
			this.dataNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// dataAgeDataGridViewTextBoxColumn
			// 
			this.dataAgeDataGridViewTextBoxColumn.DataPropertyName = "DataAge";
			this.dataAgeDataGridViewTextBoxColumn.HeaderText = "年齢";
			this.dataAgeDataGridViewTextBoxColumn.Name = "dataAgeDataGridViewTextBoxColumn";
			this.dataAgeDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataAgeDataGridViewTextBoxColumn.Width = 150;
			// 
			// dataGenderDataGridViewTextBoxColumn
			// 
			this.dataGenderDataGridViewTextBoxColumn.DataPropertyName = "DataGender";
			this.dataGenderDataGridViewTextBoxColumn.HeaderText = "性別";
			this.dataGenderDataGridViewTextBoxColumn.Name = "dataGenderDataGridViewTextBoxColumn";
			this.dataGenderDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataGenderDataGridViewTextBoxColumn.Width = 150;
			// 
			// dataAffiliationDataGridViewTextBoxColumn
			// 
			this.dataAffiliationDataGridViewTextBoxColumn.DataPropertyName = "DataAffiliation";
			this.dataAffiliationDataGridViewTextBoxColumn.HeaderText = "所属";
			this.dataAffiliationDataGridViewTextBoxColumn.Name = "dataAffiliationDataGridViewTextBoxColumn";
			this.dataAffiliationDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataAffiliationDataGridViewTextBoxColumn.Width = 150;
			// 
			// usersDataClassBindingSource
			// 
			this.usersDataClassBindingSource.DataSource = typeof(UserMasterMaintenance.UsersDataClass);
			// 
			// UserMasterMaintenance_ListDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "UserMasterMaintenance_ListDisplay";
			this.Text = "UserMasterMaintenance";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMasterMaintenance_ListDisplay_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataClassBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.BindingSource usersDataBindingSource;
		private System.Windows.Forms.BindingSource usersDataBindingSource1;
		private System.Windows.Forms.BindingSource usersDataBindingSource2;
		private System.Windows.Forms.BindingSource usersDataClassBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAgeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGenderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAffiliationDataGridViewTextBoxColumn;
	}
}

