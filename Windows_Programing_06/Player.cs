using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;
using MetroFramework.Drawing.Html;

namespace Windows_Programing_06
{
    public partial class Player : MetroFramework.Forms.MetroForm
    {
        ArrayList Playlist_ArrayList = new ArrayList();
        ArrayList Playlist_Title_ArrayList = new ArrayList();
        public int index = 0;

        private string url = "https://www.youtube.com/watch?v=pyf8cbqyfPs";
        static ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
        static ChromeOptions options = initbrowser();

        private static ChromeOptions initbrowser()
        {
            var option = new ChromeOptions();
            // 테스트를 위해서 주석 처리함 실제 동작에서는 주석 해제 하고 사용해야할 필요성 있음
            //chromeDriverService.HideCommandPromptWindow = true;
            //option.AddArgument("headless");
            return option;
        }

        ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService, options);

        public Player()
        {
            InitializeComponent();
            Playlist_ArrayList = Get_Play_List.playlist._Play_List;
            Playlist_Title_ArrayList = Get_Play_List.playlist.Get_Play_List_Title();
            Play_Music_Address.AppendText(Playlist_ArrayList[index].ToString());

            for (int x = 0; x < Playlist_ArrayList.Count; x++)
            {
                PlayListViewer.Items.Add(Get_Play_List.getYoutubeVideoTitle(Playlist_ArrayList[x].ToString()));
            }

            chromeDriver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());

            Play_Music_Title.Text = chromeDriver.Title.ToString();

            // 크롬 드라이버 css를 통해서 버튼을 클릭하여 원하는 동작을 실행
            chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();
            chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-right-controls > button:nth-child(2)")).Click();

            // 전체 시간 요소 찾기 (이 부분은 웹 페이지의 HTML 구조에 따라 조절해야 함)
            IWebElement totalTimeElement = chromeDriver.FindElement(By.CssSelector(".ytp-time-duration"));

            // 전체 시간 가져오기(유튜브 재생시간 표시)
            string totalTime = totalTimeElement.Text;
            TotalTime.Text = totalTime;
        }

        private void Add_Music_Button_Click(object sender, EventArgs e)
        {
            Playlist_ArrayList.Add(Playlist_Add_Text_Box.Text);
            PlayListViewer.Items.Add(Get_Play_List.getYoutubeVideoTitle(Playlist_Add_Text_Box.Text));
        }

        private void Previous_Song_Button_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = 0;
                MessageBox.Show("첫번째 곡입니다.");
            }
            else
            {
                index -= 1;
            }

            Play_Music_Address.Text = "";
            Play_Music_Address.AppendText(Playlist_ArrayList[index].ToString());
            chromeDriver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());
            Play_Music_Title.Text = chromeDriver.Title.ToString();
            chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();

            IWebElement totalTimeElement = chromeDriver.FindElement(By.CssSelector(".ytp-time-duration"));
            TotalTime.Text = totalTimeElement.Text;

            TotalTime.Text = totalTimeElement.Text;
            minute = 0;
            second = 0;
        }

        private void Next_Song_Burton_Click(object sender, EventArgs e)
        {
            if (index >= Playlist_ArrayList.Count)
            {
                index--;
                MessageBox.Show("마지막 곡입니다.\n 노래를 추가해주세요");
            }
            index += 1;
            Play_Music_Address.Text = "";
            Play_Music_Address.AppendText(Playlist_ArrayList[index].ToString());
            chromeDriver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());
            Play_Music_Title.Text = chromeDriver.Title.ToString();
            chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();

            IWebElement totalTimeElement = chromeDriver.FindElement(By.CssSelector(".ytp-time-duration"));

            // 전체 시간 가져오기(유튜브 재생시간 표시)
            TotalTime.Text = totalTimeElement.Text;
            minute = 0;
            second = 0;
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();
            MusicTimer.Start();
        }

        int minute = 0;
        int second = 0;

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            MusicTimer.Interval = 1000;
            second = second + 1;
            if (second == 60)
            {
                minute = minute + 1;
                second = 0;
            }

            Current_Time_Label.Text = string.Format("{0:D1}:{1:D2}", minute, second);

            if (Current_Time_Label.Text == TotalTime.Text)
            {
                Next_Song_Burton_Click(sender, new EventArgs());
            }
        }
    }
}
