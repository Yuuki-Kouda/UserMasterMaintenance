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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Affiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ID,
            this.Name,
            this.Age,
            this.Gender,
            this.Affiliation});
			this.dataGridView1.Location = new System.Drawing.Point(12, 65);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(824, 373);
			this.dataGridView1.TabIndex = 4;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.Width = 30;
			// 
			// ID
			// 
			this.ID.DataPropertyName = "UserId";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID.Width = 150;
			// 
			// Name
			// 
			this.Name.DataPropertyName = "UserName";
			this.Name.HeaderText = "名前";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Name.Width = 150;
			// 
			// Age
			// 
			this.Age.DataPropertyName = "UserAge";
			this.Age.HeaderText = "年齢";
			this.Age.Name = "Age";
			this.Age.ReadOnly = true;
			this.Age.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Age.Width = 150;
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "UserGender";
			this.Gender.HeaderText = "性別";
			this.Gender.Name = "Gender";
			this.Gender.ReadOnly = true;
			this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Gender.Width = 150;
			// 
			// Affiliation
			// 
			this.Affiliation.DataPropertyName = "UserAffiliation";
			this.Affiliation.HeaderText = "所属";
			this.Affiliation.Name = "Affiliation";
			this.Affiliation.ReadOnly = true;
			this.Affiliation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Affiliation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Affiliation.Width = 150;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Text = "UserMasterMaintenance";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFromClosed);
			this.Load += new System.EventHandler(this.UserMasterMaintenance_ListDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Affiliation;
	}
}

