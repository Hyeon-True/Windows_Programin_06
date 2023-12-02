using System;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Programing_06
{
    public partial class PlayList : MetroFramework.Forms.MetroForm
    {
        private String[] url;
        private String[] title;
        private String[] thumbnails;

        YouTubeService youtube;

        public PlayList()
        {
            InitializeComponent();
            youtube = new YouTubeService(new BaseClientService.Initializer
            {
                ApplicationName = "Show",
                ApiKey = "AIzaSyDA2F0nMYDNf - Xexf1w1JEdhE924WuATeA",
            });
        }

        private async void Import_Playlist_button_Click(object sender, EventArgs e)
        {
            PlaylistItemsResource.ListRequest Initlist = youtube.PlaylistItems.List("snippet");
            Initlist.PlaylistId = Playlist_ID_Input_Window.Text;
            Initlist.MaxResults = 100;

            var lists = await Initlist.ExecuteAsync();

            int i = 1;

            foreach (var playlistItem in lists.Items)
            {
                ListViewItem item = new ListViewItem(i.ToString());

                item.SubItems.Add(playlistItem.Snippet.Title.ToString());
                i++;

                metroListView1.Items.Add(item);
                metroListView2.Items.Add((playlistItem.Snippet.Title));
                Get_Play_List.playlist.Add_Play_List_Title(playlistItem.Snippet.Title);
                Get_Play_List.playlist.Add_Play_List("https://youtube.com/watch?v=" + playlistItem.Snippet.ResourceId.VideoId);

                metroListView2.Items.Add("URL : https://music.youtube.com/watch?v=" + playlistItem.Snippet.ResourceId.VideoId);
            }
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player player = new Player();
            player.ShowDialog();
        }
    }
}
