namespace Windows_Programing_06
{
    partial class Player
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
            this.Playlist_Add_Text_Box = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PlayListViewer = new MetroFramework.Controls.MetroListView();
            this.Play_Music_Address = new MetroFramework.Controls.MetroTextBox();
            this.Play_Music_Title = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Playlist_Add_Text_Box
            // 
            // 
            // 
            // 
            this.Playlist_Add_Text_Box.CustomButton.Image = null;
            this.Playlist_Add_Text_Box.CustomButton.Location = new System.Drawing.Point(361, 2);
            this.Playlist_Add_Text_Box.CustomButton.Name = "";
            this.Playlist_Add_Text_Box.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.Playlist_Add_Text_Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Playlist_Add_Text_Box.CustomButton.TabIndex = 1;
            this.Playlist_Add_Text_Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Playlist_Add_Text_Box.CustomButton.UseSelectable = true;
            this.Playlist_Add_Text_Box.CustomButton.Visible = false;
            this.Playlist_Add_Text_Box.Lines = new string[] {
        "이곳에 유튜브 주소를 입력하여 주세요"};
            this.Playlist_Add_Text_Box.Location = new System.Drawing.Point(24, 97);
            this.Playlist_Add_Text_Box.MaxLength = 32767;
            this.Playlist_Add_Text_Box.Multiline = true;
            this.Playlist_Add_Text_Box.Name = "Playlist_Add_Text_Box";
            this.Playlist_Add_Text_Box.PasswordChar = '\0';
            this.Playlist_Add_Text_Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Playlist_Add_Text_Box.SelectedText = "";
            this.Playlist_Add_Text_Box.SelectionLength = 0;
            this.Playlist_Add_Text_Box.SelectionStart = 0;
            this.Playlist_Add_Text_Box.ShortcutsEnabled = true;
            this.Playlist_Add_Text_Box.Size = new System.Drawing.Size(411, 52);
            this.Playlist_Add_Text_Box.TabIndex = 0;
            this.Playlist_Add_Text_Box.Text = "이곳에 유튜브 주소를 입력하여 주세요";
            this.Playlist_Add_Text_Box.UseSelectable = true;
            this.Playlist_Add_Text_Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Playlist_Add_Text_Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(442, 97);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 52);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "재생목록 \r\n추가";
            this.metroButton1.UseSelectable = true;
            // 
            // PlayListViewer
            // 
            this.PlayListViewer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlayListViewer.FullRowSelect = true;
            this.PlayListViewer.Location = new System.Drawing.Point(24, 156);
            this.PlayListViewer.Name = "PlayListViewer";
            this.PlayListViewer.OwnerDraw = true;
            this.PlayListViewer.Size = new System.Drawing.Size(493, 126);
            this.PlayListViewer.TabIndex = 2;
            this.PlayListViewer.UseCompatibleStateImageBehavior = false;
            this.PlayListViewer.UseSelectable = true;
            this.PlayListViewer.View = System.Windows.Forms.View.List;
            // 
            // Play_Music_Address
            // 
            // 
            // 
            // 
            this.Play_Music_Address.CustomButton.Image = null;
            this.Play_Music_Address.CustomButton.Location = new System.Drawing.Point(471, 1);
            this.Play_Music_Address.CustomButton.Name = "";
            this.Play_Music_Address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Play_Music_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Play_Music_Address.CustomButton.TabIndex = 1;
            this.Play_Music_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Play_Music_Address.CustomButton.UseSelectable = true;
            this.Play_Music_Address.CustomButton.Visible = false;
            this.Play_Music_Address.Lines = new string[] {
        "metroTextBox2"};
            this.Play_Music_Address.Location = new System.Drawing.Point(24, 289);
            this.Play_Music_Address.MaxLength = 32767;
            this.Play_Music_Address.Name = "Play_Music_Address";
            this.Play_Music_Address.PasswordChar = '\0';
            this.Play_Music_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Play_Music_Address.SelectedText = "";
            this.Play_Music_Address.SelectionLength = 0;
            this.Play_Music_Address.SelectionStart = 0;
            this.Play_Music_Address.ShortcutsEnabled = true;
            this.Play_Music_Address.Size = new System.Drawing.Size(493, 23);
            this.Play_Music_Address.TabIndex = 3;
            this.Play_Music_Address.Text = "metroTextBox2";
            this.Play_Music_Address.UseSelectable = true;
            this.Play_Music_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Play_Music_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Play_Music_Title
            // 
            // 
            // 
            // 
            this.Play_Music_Title.CustomButton.Image = null;
            this.Play_Music_Title.CustomButton.Location = new System.Drawing.Point(471, 1);
            this.Play_Music_Title.CustomButton.Name = "";
            this.Play_Music_Title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Play_Music_Title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Play_Music_Title.CustomButton.TabIndex = 1;
            this.Play_Music_Title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Play_Music_Title.CustomButton.UseSelectable = true;
            this.Play_Music_Title.CustomButton.Visible = false;
            this.Play_Music_Title.Lines = new string[] {
        "metroTextBox3"};
            this.Play_Music_Title.Location = new System.Drawing.Point(24, 319);
            this.Play_Music_Title.MaxLength = 32767;
            this.Play_Music_Title.Name = "Play_Music_Title";
            this.Play_Music_Title.PasswordChar = '\0';
            this.Play_Music_Title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Play_Music_Title.SelectedText = "";
            this.Play_Music_Title.SelectionLength = 0;
            this.Play_Music_Title.SelectionStart = 0;
            this.Play_Music_Title.ShortcutsEnabled = true;
            this.Play_Music_Title.Size = new System.Drawing.Size(493, 23);
            this.Play_Music_Title.TabIndex = 4;
            this.Play_Music_Title.Text = "metroTextBox3";
            this.Play_Music_Title.UseSelectable = true;
            this.Play_Music_Title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Play_Music_Title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(24, 374);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 53);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "이전 곡";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(192, 374);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 53);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(360, 374);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 53);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "다음 곡";
            this.metroButton4.UseSelectable = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Play_Music_Title);
            this.Controls.Add(this.Play_Music_Address);
            this.Controls.Add(this.PlayListViewer);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Playlist_Add_Text_Box);
            this.Name = "Player";
            this.Text = "뮤직플레이어";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Playlist_Add_Text_Box;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroListView PlayListViewer;
        private MetroFramework.Controls.MetroTextBox Play_Music_Address;
        private MetroFramework.Controls.MetroTextBox Play_Music_Title;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}