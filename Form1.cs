using Error_message_generator.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Error_message_generator
{
    public partial class Error_message_generator : Form
    {
        public Error_message_generator()
        {
            InitializeComponent();
        }
        private void Set_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayedText.ForeColor = Color.Black;
                DisplayedText.BackColor = Color.White;
                Bitmap canvas = new Bitmap(50, 50);
                Graphics Info_Image = Graphics.FromImage(canvas);
                if (Settings.Default.Image == 1)
                {
                    Info_Image.DrawIcon(SystemIcons.Error, 0, 0);
                }
                else if (Settings.Default.Image == 2)
                {
                    Info_Image.DrawIcon(SystemIcons.Warning, 0, 0);
                }
                else if (Settings.Default.Image == 3)
                {
                    Info_Image.DrawIcon(SystemIcons.Information, 0, 0);
                }
                else if (Settings.Default.Image == 4)
                {
                    Info_Image.DrawIcon(SystemIcons.Question, 0, 0);
                }
                InfoImage.Image = canvas;
                Info_Image.Dispose();
                Settings.Default.Title = TitleText.Text;
                Settings.Default.Text = DisplayText.Text;
                Settings.Default.Button1_Text = Button1Text.Text;
                Settings.Default.Button2_Text = Button2Text.Text;
                Settings.Default.Button3_Text = Button3Text.Text;
                Settings.Default.Button4_Text = Button4Text.Text;
                Settings.Default.Button1_X = Convert.ToInt32(Button1X.Text);
                Settings.Default.Button2_X = Convert.ToInt32(Button2X.Text);
                Settings.Default.Button3_X = Convert.ToInt32(Button3X.Text);
                Settings.Default.Button4_X = Convert.ToInt32(Button4X.Text);
                Settings.Default.Button_num = Convert.ToInt16(ButtonNum.Text);
                Settings.Default.Button_Wid = Convert.ToInt16(ButtonWid.Text);
                Settings.Default.Save();
                DisplayedText.Text = Settings.Default.Text;
                Text = Settings.Default.Title;
                Button1.Text = Settings.Default.Button1_Text;
                Button2.Text = Settings.Default.Button2_Text;
                Button3.Text = Settings.Default.Button3_Text;
                Button4.Text = Settings.Default.Button4_Text;
                Button1.Location = new Point(Settings.Default.Button1_X, 111);
                Button2.Location = new Point(Settings.Default.Button2_X, 111);
                Button3.Location = new Point(Settings.Default.Button3_X, 111);
                Button4.Location = new Point(Settings.Default.Button4_X, 111);
                if (Settings.Default.Button_num == 1)
                {
                    Button1.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button2.Size = new Size(0, 0);
                    Button3.Size = new Size(0, 0);
                    Button4.Size = new Size(0, 0);
                }
                else if (Settings.Default.Button_num == 2)
                {
                    Button1.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button2.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button3.Size = new Size(0, 0);
                    Button4.Size = new Size(0, 0);
                }
                else if (Settings.Default.Button_num == 3)
                {
                    Button1.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button2.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button3.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button4.Size = new Size(0, 0);
                }
                else if (Settings.Default.Button_num == 4)
                {
                    Button1.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button2.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button3.Size = new Size(Settings.Default.Button_Wid, 20);
                    Button4.Size = new Size(Settings.Default.Button_Wid, 20);
                }
            }
            catch(Exception ex)
            {
                DisplayedText.Text = $"エラーが発生しました。空白の項目がある可能性があります。\nエラー内容:\n{ex}";
                DisplayedText.ForeColor = Color.DarkRed;
                DisplayedText.BackColor = Color.Yellow;
            }
        }
        private void RightClickMenu1_Click(object sender, EventArgs e)
        {
            if (RightClickMenu1.Text == "設定非表示")
            {
                RightClickMenu1.Text = "設定表示";
                Height = 180;
            }
            else
            {
                RightClickMenu1.Text = "設定非表示";
                Height = 337;
            }
        }
        private void RB_Image1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Image = 1;
            Settings.Default.Save();
        }
        private void RB_Image2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Settings.Default.Image = 2;

        }
        private void RB_Image3_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Settings.Default.Image = 3;

        }
        private void RB_Image4_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Settings.Default.Image = 4;

        }
        private void Button1X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void Button2X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void Button3X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void Button4X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void Button_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void Button_num_KeyUp(object sender, KeyEventArgs e)
        {

            if (ButtonNum.Text == "")
            {
                ButtonNum.Text = "1";
            }
            if (Convert.ToInt32(ButtonNum.Text) > 5)
            {
                ButtonNum.Text = "4";
            }
        }
        private void ButtonWid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
        private void LoadSetting_Click(object sender, EventArgs e)
        {
            TitleText.Text = Settings.Default.Title;
            DisplayText.Text = Settings.Default.Text;
            Button1Text.Text = Settings.Default.Button1_Text;
            Button2Text.Text = Settings.Default.Button2_Text;
            Button3Text.Text = Settings.Default.Button3_Text;
            Button4Text.Text = Settings.Default.Button4_Text;
            Button1X.Text = Convert.ToString(Settings.Default.Button1_X);
            Button2X.Text = Convert.ToString(Settings.Default.Button2_X);
            Button3X.Text = Convert.ToString(Settings.Default.Button3_X);
            Button4X.Text = Convert.ToString(Settings.Default.Button4_X);
            ButtonNum.Text = Convert.ToString(Settings.Default.Button_num);
            ButtonWid.Text = Convert.ToString(Settings.Default.Button_Wid);
            if (Settings.Default.Image == 1)
            {
                RB_Image1.Checked = true;
            }
            else if (Settings.Default.Image == 2)
            {
                RB_Image2.Checked = true;
            }
            else if (Settings.Default.Image == 3)
            {
                RB_Image3.Checked = true;
            }
            else if (Settings.Default.Image == 4)
            {
                RB_Image4.Checked = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        private void Reboot_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}