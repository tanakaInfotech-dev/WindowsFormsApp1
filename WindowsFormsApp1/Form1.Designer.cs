namespace WindowsFormsApp1
{
    partial class Form1
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
            this.userData_dgv = new System.Windows.Forms.DataGridView();
            this.inputUser_txt = new System.Windows.Forms.TextBox();
            this.userInsert_btn = new System.Windows.Forms.Button();
            this.viewClose_btn = new System.Windows.Forms.Button();
            this.selectUser_btn = new System.Windows.Forms.Button();
            this.InsertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userData_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // userData_dgv
            // 
            this.userData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userData_dgv.Location = new System.Drawing.Point(194, 12);
            this.userData_dgv.Name = "userData_dgv";
            this.userData_dgv.RowTemplate.Height = 21;
            this.userData_dgv.Size = new System.Drawing.Size(361, 168);
            this.userData_dgv.TabIndex = 8;
            // 
            // inputUser_txt
            // 
            this.inputUser_txt.Location = new System.Drawing.Point(12, 103);
            this.inputUser_txt.Name = "inputUser_txt";
            this.inputUser_txt.Size = new System.Drawing.Size(101, 19);
            this.inputUser_txt.TabIndex = 9;
            // 
            // userInsert_btn
            // 
            this.userInsert_btn.Location = new System.Drawing.Point(119, 103);
            this.userInsert_btn.Name = "userInsert_btn";
            this.userInsert_btn.Size = new System.Drawing.Size(63, 19);
            this.userInsert_btn.TabIndex = 10;
            this.userInsert_btn.Text = "登録";
            this.userInsert_btn.UseVisualStyleBackColor = true;
            this.userInsert_btn.Click += new System.EventHandler(this.userInsert_btn_Click);
            // 
            // viewClose_btn
            // 
            this.viewClose_btn.Location = new System.Drawing.Point(12, 198);
            this.viewClose_btn.Name = "viewClose_btn";
            this.viewClose_btn.Size = new System.Drawing.Size(170, 23);
            this.viewClose_btn.TabIndex = 11;
            this.viewClose_btn.Text = "閉じる";
            this.viewClose_btn.UseVisualStyleBackColor = true;
            this.viewClose_btn.Click += new System.EventHandler(this.viewClose_btn_Click);
            // 
            // selectUser_btn
            // 
            this.selectUser_btn.Location = new System.Drawing.Point(194, 198);
            this.selectUser_btn.Name = "selectUser_btn";
            this.selectUser_btn.Size = new System.Drawing.Size(97, 23);
            this.selectUser_btn.TabIndex = 12;
            this.selectUser_btn.Text = "ユーザー選択";
            this.selectUser_btn.UseVisualStyleBackColor = true;
            this.selectUser_btn.Click += new System.EventHandler(this.selectUser_btn_Click);
            // 
            // InsertLabel
            // 
            this.InsertLabel.AutoSize = true;
            this.InsertLabel.Location = new System.Drawing.Point(12, 77);
            this.InsertLabel.Name = "InsertLabel";
            this.InsertLabel.Size = new System.Drawing.Size(69, 12);
            this.InsertLabel.TabIndex = 13;
            this.InsertLabel.Text = "ユーザー登録";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 243);
            this.Controls.Add(this.InsertLabel);
            this.Controls.Add(this.selectUser_btn);
            this.Controls.Add(this.viewClose_btn);
            this.Controls.Add(this.userInsert_btn);
            this.Controls.Add(this.inputUser_txt);
            this.Controls.Add(this.userData_dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userData_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView userData_dgv;
        private System.Windows.Forms.TextBox inputUser_txt;
        private System.Windows.Forms.Button userInsert_btn;
        private System.Windows.Forms.Button viewClose_btn;
        private System.Windows.Forms.Button selectUser_btn;
        private System.Windows.Forms.Label InsertLabel;
    }
}

