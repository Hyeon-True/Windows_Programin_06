namespace Windows_Programing_06
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Playlist_ID_Input_Window = new MetroFramework.Controls.MetroTextBox();
            this.Import_Playlist_button = new MetroFramework.Controls.MetroButton();
            this.Play_Button = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.numberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Playlist_ID_Input_Window
            // 
            // 
            // 
            // 
            this.Playlist_ID_Input_Window.CustomButton.Image = null;
            this.Playlist_ID_Input_Window.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.Playlist_ID_Input_Window.CustomButton.Name = "";
            this.Playlist_ID_Input_Window.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Playlist_ID_Input_Window.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Playlist_ID_Input_Window.CustomButton.TabIndex = 1;
            this.Playlist_ID_Input_Window.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Playlist_ID_Input_Window.CustomButton.UseSelectable = true;
            this.Playlist_ID_Input_Window.CustomButton.Visible = false;
            this.Playlist_ID_Input_Window.Lines = new string[] {
        "이곳에 재생목록 주소를 입력하여 주세요"};
            this.Playlist_ID_Input_Window.Location = new System.Drawing.Point(24, 97);
            this.Playlist_ID_Input_Window.MaxLength = 32767;
            this.Playlist_ID_Input_Window.Name = "Playlist_ID_Input_Window";
            this.Playlist_ID_Input_Window.PasswordChar = '\0';
            this.Playlist_ID_Input_Window.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Playlist_ID_Input_Window.SelectedText = "";
            this.Playlist_ID_Input_Window.SelectionLength = 0;
            this.Playlist_ID_Input_Window.SelectionStart = 0;
            this.Playlist_ID_Input_Window.ShortcutsEnabled = true;
            this.Playlist_ID_Input_Window.Size = new System.Drawing.Size(458, 23);
            this.Playlist_ID_Input_Window.TabIndex = 0;
            this.Playlist_ID_Input_Window.Text = "이곳에 재생목록 주소를 입력하여 주세요";
            this.Playlist_ID_Input_Window.UseSelectable = true;
            this.Playlist_ID_Input_Window.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Playlist_ID_Input_Window.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Import_Playlist_button
            // 
            this.Import_Playlist_button.Location = new System.Drawing.Point(488, 97);
            this.Import_Playlist_button.Name = "Import_Playlist_button";
            this.Import_Playlist_button.Size = new System.Drawing.Size(75, 23);
            this.Import_Playlist_button.TabIndex = 1;
            this.Import_Playlist_button.Text = "가져오기";
            this.Import_Playlist_button.UseSelectable = true;
            // 
            // Play_Button
            // 
            this.Play_Button.Location = new System.Drawing.Point(570, 97);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(75, 23);
            this.Play_Button.TabIndex = 2;
            this.Play_Button.Text = "재생";
            this.Play_Button.UseSelectable = true;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberHeader,
            this.titleHeader});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(24, 126);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(621, 147);
            this.metroListView1.TabIndex = 3;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // metroListView2
            // 
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(24, 280);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(621, 124);
            this.metroListView2.TabIndex = 4;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            // 
            // numberHeader
            // 
            this.numberHeader.Text = "번호";
            this.numberHeader.Width = 100;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "제목";
            this.titleHeader.Width = 690;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 418);
            this.Controls.Add(this.metroListView2);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Import_Playlist_button);
            this.Controls.Add(this.Playlist_ID_Input_Window);
            this.Name = "Form1";
            this.Text = "재생목록";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Playlist_ID_Input_Window;
        private MetroFramework.Controls.MetroButton Import_Playlist_button;
        private MetroFramework.Controls.MetroButton Play_Button;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader numberHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private MetroFramework.Controls.MetroListView metroListView2;
    }
}

