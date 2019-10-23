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
			this.usersDataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userAffiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataClassBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
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
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userAgeDataGridViewTextBoxColumn,
            this.userGenderDataGridViewTextBoxColumn,
            this.userAffiliationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.usersBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 65);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(824, 373);
			this.dataGridView1.TabIndex = 3;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataSource = typeof(UserMasterMaintenance.UserMasterMaintenance_ListDisplay.Users);
			// 
			// CheckBox
			// 
			this.CheckBox.DataPropertyName = "CheckBox";
			this.CheckBox.HeaderText = "";
			this.CheckBox.Name = "CheckBox";
			this.CheckBox.Width = 30;
			// 
			// userIdDataGridViewTextBoxColumn
			// 
			this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
			this.userIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
			this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.userIdDataGridViewTextBoxColumn.Width = 150;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			this.userNameDataGridViewTextBoxColumn.HeaderText = "名前";
			this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.userNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// userAgeDataGridViewTextBoxColumn
			// 
			this.userAgeDataGridViewTextBoxColumn.DataPropertyName = "UserAge";
			this.userAgeDataGridViewTextBoxColumn.HeaderText = "年齢";
			this.userAgeDataGridViewTextBoxColumn.Name = "userAgeDataGridViewTextBoxColumn";
			this.userAgeDataGridViewTextBoxColumn.ReadOnly = true;
			this.userAgeDataGridViewTextBoxColumn.Width = 150;
			// 
			// userGenderDataGridViewTextBoxColumn
			// 
			this.userGenderDataGridViewTextBoxColumn.DataPropertyName = "UserGender";
			this.userGenderDataGridViewTextBoxColumn.HeaderText = "性別";
			this.userGenderDataGridViewTextBoxColumn.Name = "userGenderDataGridViewTextBoxColumn";
			this.userGenderDataGridViewTextBoxColumn.ReadOnly = true;
			this.userGenderDataGridViewTextBoxColumn.Width = 150;
			// 
			// userAffiliationDataGridViewTextBoxColumn
			// 
			this.userAffiliationDataGridViewTextBoxColumn.DataPropertyName = "UserAffiliation";
			this.userAffiliationDataGridViewTextBoxColumn.HeaderText = "所属";
			this.userAffiliationDataGridViewTextBoxColumn.Name = "userAffiliationDataGridViewTextBoxColumn";
			this.userAffiliationDataGridViewTextBoxColumn.ReadOnly = true;
			this.userAffiliationDataGridViewTextBoxColumn.Width = 150;
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFromClosed);
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataClassBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
		private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAgeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGenderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAffiliationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userAgeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userGenderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userAffiliationDataGridViewTextBoxColumn;
	}
}

