using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Windows_Programing_06
{
    internal class Get_Play_List
    {
        public static Get_Play_List playlist = new Get_Play_List();

        private ArrayList play_list;
        private ArrayList play_list_title;

        public Get_Play_List()
        {
            play_list = new ArrayList();
            play_list_title = new ArrayList();
        }

        public void Add_Play_List(String url)
        {
            this.play_list.Add(url);
        }

        public void Add_Play_List_Title(String title)
        {
            this.play_list_title.Add(title);
        }

        public ArrayList _Play_List => this.play_list;

        public ArrayList Get_Play_List_Title()
        {
            return this.play_list_title;
        }

        // 노래를 listBox1에 추가하는 과정에서 title을 youtube에서 가져오기 위해 작성
        private static string[] getYoutubeTitle(string url)
        {
            string responseText = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000;

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);
                Stream respStream = resp.GetResponseStream();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                }
            }
            return responseText.Split('\n');
        }

        // 노래를 listBox1에 추가하는 과정에서 title을 youtube에서 가져오기 위해 작성
        public static string getYoutubeVideoTitle(string url)
        {
            string[] data = getYoutubeTitle(url);
            string[] strings = data[20].Split(new string[] { "<meta name=\"title\" content=\"" }, StringSplitOptions.None);
            string name = strings[1].Split(new string[] { "\">" }, StringSplitOptions.None)[0];
            return HttpUtility.HtmlDecode(name);
        }

    }
}
