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
            this.components = new System.ComponentModel.Container();
            this.Playlist_Add_Text_Box = new MetroFramework.Controls.MetroTextBox();
            this.Add_Music_Button = new MetroFramework.Controls.MetroButton();
            this.PlayListViewer = new MetroFramework.Controls.MetroListView();
            this.Play_Music_Address = new MetroFramework.Controls.MetroTextBox();
            this.Play_Music_Title = new MetroFramework.Controls.MetroTextBox();
            this.Previous_Song_Button = new MetroFramework.Controls.MetroButton();
            this.Play_Button = new MetroFramework.Controls.MetroButton();
            this.Next_Song_Burton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.Current_Time_Label = new System.Windows.Forms.Label();
            this.MusicTimer = new System.Windows.Forms.Timer(this.components);
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
            // Add_Music_Button
            // 
            this.Add_Music_Button.Location = new System.Drawing.Point(442, 97);
            this.Add_Music_Button.Name = "Add_Music_Button";
            this.Add_Music_Button.Size = new System.Drawing.Size(75, 52);
            this.Add_Music_Button.TabIndex = 1;
            this.Add_Music_Button.Text = "재생목록 \r\n추가";
            this.Add_Music_Button.UseSelectable = true;
            this.Add_Music_Button.Click += new System.EventHandler(this.Add_Music_Button_Click);
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
            this.Play_Music_Address.Lines = new string[0];
            this.Play_Music_Address.Location = new System.Drawing.Point(24, 316);
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
            this.Play_Music_Title.Lines = new string[0];
            this.Play_Music_Title.Location = new System.Drawing.Point(23, 345);
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
            this.Play_Music_Title.UseSelectable = true;
            this.Play_Music_Title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Play_Music_Title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Previous_Song_Button
            // 
            this.Previous_Song_Button.Location = new System.Drawing.Point(24, 374);
            this.Previous_Song_Button.Name = "Previous_Song_Button";
            this.Previous_Song_Button.Size = new System.Drawing.Size(75, 53);
            this.Previous_Song_Button.TabIndex = 5;
            this.Previous_Song_Button.Text = "이전 곡";
            this.Previous_Song_Button.UseSelectable = true;
            this.Previous_Song_Button.Click += new System.EventHandler(this.Previous_Song_Button_Click);
            // 
            // Play_Button
            // 
            this.Play_Button.Location = new System.Drawing.Point(192, 374);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(75, 53);
            this.Play_Button.TabIndex = 6;
            this.Play_Button.Text = "정지";
            this.Play_Button.UseSelectable = true;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Next_Song_Burton
            // 
            this.Next_Song_Burton.Location = new System.Drawing.Point(360, 374);
            this.Next_Song_Burton.Name = "Next_Song_Burton";
            this.Next_Song_Burton.Size = new System.Drawing.Size(75, 53);
            this.Next_Song_Burton.TabIndex = 7;
            this.Next_Song_Burton.Text = "다음 곡";
            this.Next_Song_Burton.UseSelectable = true;
            this.Next_Song_Burton.Click += new System.EventHandler(this.Next_Song_Burton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "/";
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Location = new System.Drawing.Point(371, 288);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(27, 12);
            this.TotalTime.TabIndex = 10;
            this.TotalTime.Text = "0:00";
            // 
            // Current_Time_Label
            // 
            this.Current_Time_Label.AutoSize = true;
            this.Current_Time_Label.Location = new System.Drawing.Point(338, 288);
            this.Current_Time_Label.Name = "Current_Time_Label";
            this.Current_Time_Label.Size = new System.Drawing.Size(27, 12);
            this.Current_Time_Label.TabIndex = 11;
            this.Current_Time_Label.Text = "0:00";
            // 
            // MusicTimer
            // 
            this.MusicTimer.Tick += new System.EventHandler(this.MusicTimer_Tick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.Current_Time_Label);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next_Song_Burton);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Previous_Song_Button);
            this.Controls.Add(this.Play_Music_Title);
            this.Controls.Add(this.Play_Music_Address);
            this.Controls.Add(this.PlayListViewer);
            this.Controls.Add(this.Add_Music_Button);
            this.Controls.Add(this.Playlist_Add_Text_Box);
            this.Name = "Player";
            this.Text = "뮤직플레이어";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Playlist_Add_Text_Box;
        private MetroFramework.Controls.MetroButton Add_Music_Button;
        private MetroFramework.Controls.MetroListView PlayListViewer;
        private MetroFramework.Controls.MetroTextBox Play_Music_Address;
        private MetroFramework.Controls.MetroTextBox Play_Music_Title;
        private MetroFramework.Controls.MetroButton Previous_Song_Button;
        private MetroFramework.Controls.MetroButton Play_Button;
        private MetroFramework.Controls.MetroButton Next_Song_Burton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label Current_Time_Label;
        private System.Windows.Forms.Timer MusicTimer;
    }
}