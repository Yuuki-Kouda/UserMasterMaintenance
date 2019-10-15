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
			this.チェックボックス = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DataID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataAffiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.チェックボックス,
            this.DataID,
            this.DataName,
            this.DataAge,
            this.DataGender,
            this.DataAffiliation});
			this.dataGridView1.Location = new System.Drawing.Point(12, 65);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(824, 373);
			this.dataGridView1.TabIndex = 3;
			// 
			// チェックボックス
			// 
			this.チェックボックス.HeaderText = "";
			this.チェックボックス.Name = "チェックボックス";
			this.チェックボックス.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.チェックボックス.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.チェックボックス.Width = 30;
			// 
			// DataID
			// 
			this.DataID.HeaderText = "ID";
			this.DataID.Name = "DataID";
			this.DataID.ReadOnly = true;
			this.DataID.Width = 150;
			// 
			// DataName
			// 
			this.DataName.HeaderText = "名前";
			this.DataName.Name = "DataName";
			this.DataName.ReadOnly = true;
			this.DataName.Width = 150;
			// 
			// DataAge
			// 
			this.DataAge.HeaderText = "年齢";
			this.DataAge.Name = "DataAge";
			this.DataAge.ReadOnly = true;
			this.DataAge.Width = 150;
			// 
			// DataGender
			// 
			this.DataGender.HeaderText = "性別";
			this.DataGender.Name = "DataGender";
			this.DataGender.ReadOnly = true;
			this.DataGender.Width = 150;
			// 
			// DataAffiliation
			// 
			this.DataAffiliation.HeaderText = "所属";
			this.DataAffiliation.Name = "DataAffiliation";
			this.DataAffiliation.ReadOnly = true;
			this.DataAffiliation.Width = 150;
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
			this.Load += new System.EventHandler(this.UserMasterMaintenance_ListDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn チェックボックス;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGender;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataAffiliation;
	}
}

