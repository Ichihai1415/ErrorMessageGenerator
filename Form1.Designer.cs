namespace Error_message_generator
{
    partial class Error_message_generator
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
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.DisplayedText = new System.Windows.Forms.Label();
            this.Settei = new System.Windows.Forms.Label();
            this.back2 = new System.Windows.Forms.Label();
            this.RB_Image1 = new System.Windows.Forms.RadioButton();
            this.InfoImage = new System.Windows.Forms.PictureBox();
            this.Group1 = new System.Windows.Forms.GroupBox();
            this.RB_Image4 = new System.Windows.Forms.RadioButton();
            this.RB_Image3 = new System.Windows.Forms.RadioButton();
            this.RB_Image2 = new System.Windows.Forms.RadioButton();
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Button();
            this.Button1X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonWid = new System.Windows.Forms.TextBox();
            this.Group2 = new System.Windows.Forms.GroupBox();
            this.Button4Text = new System.Windows.Forms.TextBox();
            this.Button2Text = new System.Windows.Forms.TextBox();
            this.Button3Text = new System.Windows.Forms.TextBox();
            this.Button1Text = new System.Windows.Forms.TextBox();
            this.Button2X = new System.Windows.Forms.TextBox();
            this.Button3X = new System.Windows.Forms.TextBox();
            this.Button4X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.LoadSetting = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Reboot = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).BeginInit();
            this.Group1.SuspendLayout();
            this.RightClick.SuspendLayout();
            this.Group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(192, 200);
            this.DisplayText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayText.Size = new System.Drawing.Size(428, 53);
            this.DisplayText.TabIndex = 3;
            // 
            // DisplayedText
            // 
            this.DisplayedText.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.DisplayedText.Location = new System.Drawing.Point(80, 16);
            this.DisplayedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayedText.Name = "DisplayedText";
            this.DisplayedText.Size = new System.Drawing.Size(533, 110);
            this.DisplayedText.TabIndex = 5;
            this.DisplayedText.Text = "ここにテキスト（6行まで）、\r\n←ここにアイコンが表示されます。\r\n「表示」を押すと現在の設定が保存され、メイン画面に反映されます。\r\n\r\n設定ファイルは内部に保" +
    "存されます。\r\n詳しくはReadme.mdを参照してください。";
            // 
            // Settei
            // 
            this.Settei.AutoSize = true;
            this.Settei.BackColor = System.Drawing.Color.White;
            this.Settei.Location = new System.Drawing.Point(8, 181);
            this.Settei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Settei.Name = "Settei";
            this.Settei.Size = new System.Drawing.Size(174, 15);
            this.Settei.TabIndex = 6;
            this.Settei.Text = "《設定》右クリックでON/OFF";
            // 
            // back2
            // 
            this.back2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.back2.Location = new System.Drawing.Point(0, 126);
            this.back2.Margin = new System.Windows.Forms.Padding(0);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(631, 50);
            this.back2.TabIndex = 8;
            // 
            // RB_Image1
            // 
            this.RB_Image1.AutoSize = true;
            this.RB_Image1.Location = new System.Drawing.Point(13, 21);
            this.RB_Image1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Image1.Name = "RB_Image1";
            this.RB_Image1.Size = new System.Drawing.Size(61, 19);
            this.RB_Image1.TabIndex = 1;
            this.RB_Image1.Text = "エラー";
            this.RB_Image1.UseVisualStyleBackColor = true;
            this.RB_Image1.CheckedChanged += new System.EventHandler(this.RB_Image1_CheckedChanged);
            // 
            // InfoImage
            // 
            this.InfoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoImage.Location = new System.Drawing.Point(20, 18);
            this.InfoImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoImage.Name = "InfoImage";
            this.InfoImage.Size = new System.Drawing.Size(52, 49);
            this.InfoImage.TabIndex = 7;
            this.InfoImage.TabStop = false;
            // 
            // Group1
            // 
            this.Group1.Controls.Add(this.RB_Image4);
            this.Group1.Controls.Add(this.RB_Image3);
            this.Group1.Controls.Add(this.RB_Image2);
            this.Group1.Controls.Add(this.RB_Image1);
            this.Group1.Location = new System.Drawing.Point(7, 200);
            this.Group1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Group1.Name = "Group1";
            this.Group1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Group1.Size = new System.Drawing.Size(179, 74);
            this.Group1.TabIndex = 10;
            this.Group1.TabStop = false;
            this.Group1.Text = "画像";
            // 
            // RB_Image4
            // 
            this.RB_Image4.AutoSize = true;
            this.RB_Image4.Location = new System.Drawing.Point(80, 45);
            this.RB_Image4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Image4.Name = "RB_Image4";
            this.RB_Image4.Size = new System.Drawing.Size(91, 19);
            this.RB_Image4.TabIndex = 11;
            this.RB_Image4.Text = "クエスチョン";
            this.RB_Image4.UseVisualStyleBackColor = true;
            this.RB_Image4.CheckedChanged += new System.EventHandler(this.RB_Image4_CheckedChanged);
            // 
            // RB_Image3
            // 
            this.RB_Image3.AutoSize = true;
            this.RB_Image3.Location = new System.Drawing.Point(80, 21);
            this.RB_Image3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Image3.Name = "RB_Image3";
            this.RB_Image3.Size = new System.Drawing.Size(83, 19);
            this.RB_Image3.TabIndex = 3;
            this.RB_Image3.Text = "メッセージ";
            this.RB_Image3.UseVisualStyleBackColor = true;
            this.RB_Image3.CheckedChanged += new System.EventHandler(this.RB_Image3_CheckedChanged);
            // 
            // RB_Image2
            // 
            this.RB_Image2.AutoSize = true;
            this.RB_Image2.Location = new System.Drawing.Point(13, 45);
            this.RB_Image2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Image2.Name = "RB_Image2";
            this.RB_Image2.Size = new System.Drawing.Size(58, 19);
            this.RB_Image2.TabIndex = 2;
            this.RB_Image2.Text = "警告";
            this.RB_Image2.UseVisualStyleBackColor = true;
            this.RB_Image2.CheckedChanged += new System.EventHandler(this.RB_Image2_CheckedChanged);
            // 
            // RightClick
            // 
            this.RightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickMenu1,
            this.toolStripMenuItem1,
            this.Reboot});
            this.RightClick.Name = "contextMenuStrip1";
            this.RightClick.Size = new System.Drawing.Size(154, 58);
            // 
            // RightClickMenu1
            // 
            this.RightClickMenu1.Name = "RightClickMenu1";
            this.RightClickMenu1.Size = new System.Drawing.Size(210, 24);
            this.RightClickMenu1.Text = "設定非表示";
            this.RightClickMenu1.Click += new System.EventHandler(this.RightClickMenu1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "ボタン1のX座標:　　　　ボタン2のX座標:　　　　ボタン3のX座標:　　　　ボタン4のX座標:　　　　";
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(519, 39);
            this.Set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(92, 51);
            this.Set.TabIndex = 0;
            this.Set.Text = "保存・表示";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Button1X
            // 
            this.Button1X.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Button1X.Location = new System.Drawing.Point(115, 14);
            this.Button1X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1X.Name = "Button1X";
            this.Button1X.ShortcutsEnabled = false;
            this.Button1X.Size = new System.Drawing.Size(33, 22);
            this.Button1X.TabIndex = 16;
            this.Button1X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button1X_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ボタンの数(1~4):";
            // 
            // ButtonNum
            // 
            this.ButtonNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ButtonNum.Location = new System.Drawing.Point(112, 39);
            this.ButtonNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNum.Name = "ButtonNum";
            this.ButtonNum.ShortcutsEnabled = false;
            this.ButtonNum.Size = new System.Drawing.Size(16, 22);
            this.ButtonNum.TabIndex = 1;
            this.ButtonNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button_num_KeyPress);
            this.ButtonNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Button_num_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ボタン横幅:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(132, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ボタン1の文字:　　　　　　　　　ボタン3の文字:　　　　　　　　　\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(132, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ボタン2の文字:　　　　　　　　　ボタン4の文字:　　　　　　　　　";
            // 
            // ButtonWid
            // 
            this.ButtonWid.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ButtonWid.Location = new System.Drawing.Point(96, 64);
            this.ButtonWid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonWid.Name = "ButtonWid";
            this.ButtonWid.ShortcutsEnabled = false;
            this.ButtonWid.Size = new System.Drawing.Size(32, 22);
            this.ButtonWid.TabIndex = 15;
            this.ButtonWid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonWid_KeyPress);
            // 
            // Group2
            // 
            this.Group2.Controls.Add(this.Button4Text);
            this.Group2.Controls.Add(this.Button2Text);
            this.Group2.Controls.Add(this.Button3Text);
            this.Group2.Controls.Add(this.Button1Text);
            this.Group2.Controls.Add(this.Button2X);
            this.Group2.Controls.Add(this.Button3X);
            this.Group2.Controls.Add(this.Button4X);
            this.Group2.Controls.Add(this.ButtonWid);
            this.Group2.Controls.Add(this.label5);
            this.Group2.Controls.Add(this.label4);
            this.Group2.Controls.Add(this.label3);
            this.Group2.Controls.Add(this.ButtonNum);
            this.Group2.Controls.Add(this.label2);
            this.Group2.Controls.Add(this.Button1X);
            this.Group2.Controls.Add(this.Set);
            this.Group2.Controls.Add(this.label6);
            this.Group2.Location = new System.Drawing.Point(7, 275);
            this.Group2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Group2.Name = "Group2";
            this.Group2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Group2.Size = new System.Drawing.Size(615, 95);
            this.Group2.TabIndex = 11;
            this.Group2.TabStop = false;
            this.Group2.Text = "ボタン";
            // 
            // Button4Text
            // 
            this.Button4Text.Location = new System.Drawing.Point(419, 64);
            this.Button4Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button4Text.Name = "Button4Text";
            this.Button4Text.Size = new System.Drawing.Size(92, 22);
            this.Button4Text.TabIndex = 23;
            // 
            // Button2Text
            // 
            this.Button2Text.Location = new System.Drawing.Point(227, 64);
            this.Button2Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2Text.Name = "Button2Text";
            this.Button2Text.Size = new System.Drawing.Size(92, 22);
            this.Button2Text.TabIndex = 22;
            // 
            // Button3Text
            // 
            this.Button3Text.Location = new System.Drawing.Point(419, 39);
            this.Button3Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3Text.Name = "Button3Text";
            this.Button3Text.Size = new System.Drawing.Size(92, 22);
            this.Button3Text.TabIndex = 21;
            // 
            // Button1Text
            // 
            this.Button1Text.Location = new System.Drawing.Point(227, 39);
            this.Button1Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1Text.Name = "Button1Text";
            this.Button1Text.Size = new System.Drawing.Size(92, 22);
            this.Button1Text.TabIndex = 20;
            // 
            // Button2X
            // 
            this.Button2X.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Button2X.Location = new System.Drawing.Point(257, 14);
            this.Button2X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2X.Name = "Button2X";
            this.Button2X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button2X.ShortcutsEnabled = false;
            this.Button2X.Size = new System.Drawing.Size(33, 22);
            this.Button2X.TabIndex = 17;
            this.Button2X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button2X_KeyPress);
            // 
            // Button3X
            // 
            this.Button3X.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Button3X.Location = new System.Drawing.Point(403, 14);
            this.Button3X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3X.Name = "Button3X";
            this.Button3X.ShortcutsEnabled = false;
            this.Button3X.Size = new System.Drawing.Size(33, 22);
            this.Button3X.TabIndex = 18;
            this.Button3X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button3X_KeyPress);
            // 
            // Button4X
            // 
            this.Button4X.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Button4X.Location = new System.Drawing.Point(545, 12);
            this.Button4X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button4X.Name = "Button4X";
            this.Button4X.ShortcutsEnabled = false;
            this.Button4X.Size = new System.Drawing.Size(33, 22);
            this.Button4X.TabIndex = 19;
            this.Button4X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button4X_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "表示テキスト";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "タイトル:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(247, 258);
            this.TitleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(373, 22);
            this.TitleText.TabIndex = 14;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(168, 139);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 25);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "ボタン1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(281, 139);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 25);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "ボタン2";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(395, 139);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 25);
            this.Button3.TabIndex = 17;
            this.Button3.Text = "ボタン3";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(508, 139);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 25);
            this.Button4.TabIndex = 18;
            this.Button4.Text = "ボタン4";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // LoadSetting
            // 
            this.LoadSetting.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.LoadSetting.Location = new System.Drawing.Point(312, 176);
            this.LoadSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadSetting.Name = "LoadSetting";
            this.LoadSetting.Size = new System.Drawing.Size(164, 22);
            this.LoadSetting.TabIndex = 19;
            this.LoadSetting.Text = "設定ファイルから読み込む";
            this.LoadSetting.UseVisualStyleBackColor = true;
            this.LoadSetting.Click += new System.EventHandler(this.LoadSetting_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.Reset.Location = new System.Drawing.Point(479, 176);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(143, 22);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "設定ファイルのリセット";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // Reboot
            // 
            this.Reboot.Name = "Reboot";
            this.Reboot.Size = new System.Drawing.Size(210, 24);
            this.Reboot.Text = "再起動";
            this.Reboot.Click += new System.EventHandler(this.Reboot_Click);
            // 
            // Error_message_generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.ContextMenuStrip = this.RightClick;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.LoadSetting);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InfoImage);
            this.Controls.Add(this.Settei);
            this.Controls.Add(this.DisplayedText);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.Group1);
            this.Controls.Add(this.Group2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error_message_generator";
            this.Text = "Error message generator";
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).EndInit();
            this.Group1.ResumeLayout(false);
            this.Group1.PerformLayout();
            this.RightClick.ResumeLayout(false);
            this.Group2.ResumeLayout(false);
            this.Group2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DisplayText;
        private System.Windows.Forms.Label DisplayedText;
        private System.Windows.Forms.Label Settei;
        private System.Windows.Forms.PictureBox InfoImage;
        private System.Windows.Forms.Label back2;
        private System.Windows.Forms.RadioButton RB_Image1;
        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.RadioButton RB_Image4;
        private System.Windows.Forms.RadioButton RB_Image3;
        private System.Windows.Forms.RadioButton RB_Image2;
        private System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.ToolStripMenuItem RightClickMenu1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.TextBox Button1X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ButtonNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ButtonWid;
        private System.Windows.Forms.GroupBox Group2;
        private System.Windows.Forms.TextBox Button2X;
        private System.Windows.Forms.TextBox Button3X;
        private System.Windows.Forms.TextBox Button4X;
        private System.Windows.Forms.TextBox Button4Text;
        private System.Windows.Forms.TextBox Button2Text;
        private System.Windows.Forms.TextBox Button3Text;
        private System.Windows.Forms.TextBox Button1Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button LoadSetting;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Reboot;
    }
}

