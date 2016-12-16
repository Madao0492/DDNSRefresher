namespace DDNSRefresher
{
    partial class DDNSRefresher
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDNSRefresher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_Domain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SSID = new System.Windows.Forms.Button();
            this.tBox_SSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.フォームを表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBox_Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBox_Domain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBox_Host);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_SSID);
            this.groupBox1.Controls.Add(this.tBox_SSID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DDNSの設定";
            // 
            // tBox_Password
            // 
            this.tBox_Password.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tBox_Password.Location = new System.Drawing.Point(11, 130);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.PasswordChar = '*';
            this.tBox_Password.Size = new System.Drawing.Size(206, 19);
            this.tBox_Password.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "パスワード";
            // 
            // tBox_Domain
            // 
            this.tBox_Domain.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tBox_Domain.Location = new System.Drawing.Point(223, 87);
            this.tBox_Domain.Name = "tBox_Domain";
            this.tBox_Domain.Size = new System.Drawing.Size(206, 19);
            this.tBox_Domain.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ドメイン名";
            // 
            // tBox_Host
            // 
            this.tBox_Host.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tBox_Host.Location = new System.Drawing.Point(11, 87);
            this.tBox_Host.Name = "tBox_Host";
            this.tBox_Host.Size = new System.Drawing.Size(206, 19);
            this.tBox_Host.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ホスト名";
            // 
            // btn_SSID
            // 
            this.btn_SSID.Location = new System.Drawing.Point(223, 42);
            this.btn_SSID.Name = "btn_SSID";
            this.btn_SSID.Size = new System.Drawing.Size(124, 23);
            this.btn_SSID.TabIndex = 2;
            this.btn_SSID.Text = "現在のSSIDを利用";
            this.btn_SSID.UseVisualStyleBackColor = true;
            this.btn_SSID.Click += new System.EventHandler(this.btn_SSID_Click);
            // 
            // tBox_SSID
            // 
            this.tBox_SSID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tBox_SSID.Location = new System.Drawing.Point(11, 44);
            this.tBox_SSID.Name = "tBox_SSID";
            this.tBox_SSID.Size = new System.Drawing.Size(206, 19);
            this.tBox_SSID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "接続先SSID";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(30, 203);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(191, 23);
            this.btn_Apply.TabIndex = 1;
            this.btn_Apply.Text = "設定を反映して閉じる";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(242, 203);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(191, 23);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "プログラムを終了する";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DDNSRefresher";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォームを表示ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // フォームを表示ToolStripMenuItem
            // 
            this.フォームを表示ToolStripMenuItem.Name = "フォームを表示ToolStripMenuItem";
            this.フォームを表示ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.フォームを表示ToolStripMenuItem.Text = "フォームを表示";
            this.フォームを表示ToolStripMenuItem.Click += new System.EventHandler(this.フォームを表示ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // DDNSRefresher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 244);
            this.ControlBox = false;
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DDNSRefresher";
            this.Text = "DDNSRefresher";
            this.Load += new System.EventHandler(this.DDNSRefresher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBox_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_Domain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_Host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SSID;
        private System.Windows.Forms.TextBox tBox_SSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem フォームを表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

