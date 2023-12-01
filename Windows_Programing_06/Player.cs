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
using System.Threading;

namespace Windows_Programing_06
{
    public partial class Player : MetroFramework.Forms.MetroForm
    {
        ArrayList Playlist_ArrayList = new ArrayList();
        ArrayList Playlist_Title_ArrayList = new ArrayList();
        public int index = 0;

        private string url = "https://www.youtube.com/watch?v=pyf8cbqyfPs";

        private ChromeOptions chromeOptions; //Default value of chromeOptions is null
        private IWebDriver driver; //Default value of driver is null

        int timer_Started = -1;

        public void LoadChrome()
        {
            try
            {
                Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:\\chromedriver\\chromedriver.exe");
                chromeOptions = new ChromeOptions();
                chromeOptions.BinaryLocation = "C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe";
                ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                chromeOptions.AddArgument("--headless");
                driver = new ChromeDriver(driverService, chromeOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

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

            Thread.Sleep(800);

            try
            {
                LoadChrome();
                driver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());
                Play_Music_Title.Text = driver.Title.ToString();
                MusicTimer.Stop();
                driver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e); 
            }

            // 크롬 드라이버 css를 통해서 버튼을 클릭하여 원하는 동작을 실행
            driver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();
            driver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-right-controls > button:nth-child(2)")).Click();

            // 전체 시간 요소 찾기 (이 부분은 웹 페이지의 HTML 구조에 따라 조절해야 함)
            IWebElement totalTimeElement = driver.FindElement(By.CssSelector(".ytp-time-duration"));

            // 전체 시간 가져오기(유튜브 재생시간 표시)
            string totalTime = totalTimeElement.Text;
            TotalTime.Text = totalTime;
            MusicTimer.Start();
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
            driver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());
            Play_Music_Title.Text = driver.Title.ToString();

            IWebElement totalTimeElement = driver.FindElement(By.CssSelector(".ytp-time-duration"));
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
            driver.Navigate().GoToUrl(Playlist_ArrayList[index].ToString());
            Play_Music_Title.Text = driver.Title.ToString();

            IWebElement totalTimeElement = driver.FindElement(By.CssSelector(".ytp-time-duration"));

            // 전체 시간 가져오기(유튜브 재생시간 표시)
            TotalTime.Text = totalTimeElement.Text;
            minute = 0;
            second = 0;
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            driver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-left-controls > button")).Click();
            timer_Started = timer_Started * -1;
            if (timer_Started == -1)
            {
                Play_Button.Text = "재생";
            }
            else if (timer_Started == 1)
            {
                Play_Button.Text = "정지";
            }
        }

        int minute = 0;
        int second = 0;

        private void MusicTimer_Tick(object sender, EventArgs e)
        {
            if (timer_Started == 1)
            {
                MusicTimer.Interval = 1000;
                second = second + 1;
            }
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

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            driver.Quit();
        }

        private void Timer_Stop_Click(object sender, EventArgs e)
        {
            timer_Started = -1;
        }
    }
}
