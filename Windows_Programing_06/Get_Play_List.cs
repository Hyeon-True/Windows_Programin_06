using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ArrayList Get_Play_List()
        {
            return this.play_list;
        }

        public ArrayList Get_Play_List_Title()
        {
            return this.play_list_title;
        }

    }
}
