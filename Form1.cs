using Error_message_generator.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                else
                {
                    Info_Image.DrawIcon(SystemIcons.Error, 0, 0);
                }
                canvas.MakeTransparent();
                InfoIcon.Image = canvas;
                InfoIcon.BackColor = Settings.Default.TextBackColor;
                if (Settings.Default.Image == 0)
                {
                    Bitmap UserImage = new Bitmap("Icon.png");
                    UserImage.MakeTransparent();//(0,0)で透過されるため注意
                    InfoIcon.Image = UserImage;
                    InfoIcon.BackColor = Settings.Default.TextBackColor;
                }
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
                DisplayedText.ForeColor = Settings.Default.TextForeColor;
                DisplayedText.BackColor = Settings.Default.TextBackColor;
                DisplayedText.Font = Settings.Default.FontSize;
                Back1.BackColor = Settings.Default.TextBackColor;
                Back2.BackColor = Settings.Default.ButtonBackColor;
                Button1.ForeColor = Settings.Default.ButtonForeColor;
                Button2.ForeColor = Settings.Default.ButtonForeColor;
                Button3.ForeColor = Settings.Default.ButtonForeColor;
                Button4.ForeColor = Settings.Default.ButtonForeColor;
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
            catch (Exception ex)
            {
                DisplayedText.Text = $"エラーが発生しました。数値が空白である可能性があります。分からない場合制作者に報告してください。\nエラー内容:\n{ex}";
                DisplayedText.ForeColor = Color.DarkRed;
                DisplayedText.BackColor = Color.Yellow;
                Back1.BackColor = Color.Yellow;
                Back2.BackColor = Color.Yellow;

            }
        }
        private void RightClickMenu1_Click(object sender, EventArgs e)
        {
            if (RightClickMenu1.Text == "設定非表示")
            {
                RightClickMenu1.Text = "設定表示";
                Height = 179;
            }
            else
            {
                RightClickMenu1.Text = "設定非表示";
                Height = 539;
            }
        }
        private void RB_Image1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Image = 1;
            Settings.Default.Save();
        }
        private void RB_Image2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Image = 2;
            Settings.Default.Save();

        }
        private void RB_Image3_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Image = 3;
            Settings.Default.Save();
        }
        private void RB_Image4_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Image = 4;
            Settings.Default.Save();
        }
        private void LoadSetting_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
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
            TextForeTest.BackColor = Settings.Default.TextForeColor;
            ButtonForeTest.BackColor = Settings.Default.ButtonForeColor;
            TextBackTest.BackColor = Settings.Default.TextBackColor;
            FontSizeTest.Text = Convert.ToString(FontDialog.Font).Replace("[Font: Name=", "").Replace("Size=", "").Replace(", Units", "pt　　　　　　　　　　");

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
            try
            {
                Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                File.Delete(Config.FilePath);//Resetだとユーザー設定ファイルの内容がなくなるので削除する
                Settings.Default.Save();
            }
            catch
            {
            }
        }
        private void Reboot_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void SettingCopy_Click(object sender, EventArgs e)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            string NewFilePath = $"UserSetting\\{DateTime.Now:yyyy-MM-dd-hh-mm-ss}.config";
            File.Copy(Config.FilePath, NewFilePath);
            ButtonBackTest.BackColor = Settings.Default.ButtonBackColor;
        }
        private void TextForeColorSet_Click(object sender, EventArgs e)
        {
            DialogResult TextFore = ColorDialog1.ShowDialog();
            if (TextFore == DialogResult.OK)
            {
                Settings.Default.TextForeColor = ColorDialog1.Color;
                TextForeTest.BackColor = Settings.Default.TextForeColor;
            }
        }
        private void ButtonForeColorSet_Click(object sender, EventArgs e)
        {
            DialogResult ButtonFore = ColorDialog2.ShowDialog();
            if (ButtonFore == DialogResult.OK)
            {
                Settings.Default.ButtonForeColor = ColorDialog2.Color;
                ButtonForeTest.BackColor = Settings.Default.ButtonForeColor;
            }
        }
        private void TextBackColorSet_Click(object sender, EventArgs e)
        {
            DialogResult TextBack = ColorDialog3.ShowDialog();
            if (TextBack == DialogResult.OK)
            {
                Settings.Default.TextBackColor = ColorDialog3.Color;
                TextBackTest.BackColor = Settings.Default.TextBackColor;
            }
        }
        private void ButtonBackColorSet_Click(object sender, EventArgs e)
        {
            DialogResult ButtonBack = ColorDialog4.ShowDialog();
            if (ButtonBack == DialogResult.OK)
            {
                Settings.Default.ButtonBackColor = ColorDialog4.Color;
                ButtonBackTest.BackColor = Settings.Default.ButtonBackColor;
            }
        }
        private void FontSizeSet_Click(object sender, EventArgs e)
        {
            DialogResult FontSize = FontDialog.ShowDialog();
            if (FontSize == DialogResult.OK)
            {
                Settings.Default.FontSize = FontDialog.Font;
                FontSizeTest.Text = Convert.ToString(FontDialog.Font).Replace("[Font: Name=", "").Replace("Size=", "").Replace(", Units", "pt　　　　　　　　　　");
            }
        }
        private void OpenReadme_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Readme.md");
        }
        private void OpenSettingArea_Click(object sender, EventArgs e)
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            Process.Start("explorer.exe", Config.FilePath.Replace("\\user.config", ""));
        }
        private void Twitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/ProjectS31415_1");
        }
        private void Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Project-S-31415");

        }
        private void Ameba_Click(object sender, EventArgs e)
        {
            Process.Start("https://project-s-31415.amebaownd.com/");

        }

        private void AutoLoad_Tick(object sender, EventArgs e)
        {
            if (IsAutoLoad.Checked)
            {
                try
                {
                    Settings.Default.Reload();
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
                    else
                    {
                        Info_Image.DrawIcon(SystemIcons.Error, 0, 0);
                    }
                    canvas.MakeTransparent();
                    InfoIcon.Image = canvas;
                    InfoIcon.BackColor = Settings.Default.TextBackColor;
                    if (Settings.Default.Image == 0)
                    {
                        Bitmap UserImage = new Bitmap("Icon.png");
                        UserImage.MakeTransparent();//(0,0)で透過されるため注意
                        InfoIcon.Image = UserImage;
                        InfoIcon.BackColor = Settings.Default.TextBackColor;
                    }
                    Info_Image.Dispose();
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
                    DisplayedText.ForeColor = Settings.Default.TextForeColor;
                    DisplayedText.BackColor = Settings.Default.TextBackColor;
                    DisplayedText.Font = Settings.Default.FontSize;
                    Back1.BackColor = Settings.Default.TextBackColor;
                    Back2.BackColor = Settings.Default.ButtonBackColor;
                    Button1.ForeColor = Settings.Default.ButtonForeColor;
                    Button2.ForeColor = Settings.Default.ButtonForeColor;
                    Button3.ForeColor = Settings.Default.ButtonForeColor;
                    Button4.ForeColor = Settings.Default.ButtonForeColor;
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
                catch (Exception ex)
                {
                    DisplayedText.Text = $"エラーが発生しました。数値が空白である可能性があります。分からない場合制作者に報告してください。\nエラー内容:\n{ex}";
                    DisplayedText.ForeColor = Color.DarkRed;
                    DisplayedText.BackColor = Color.Yellow;
                    Back1.BackColor = Color.Yellow;
                    Back2.BackColor = Color.Yellow;

                }
            }
        }
    }
}