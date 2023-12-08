using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Windows_Programing_06
{
    internal class Read_json_data
    {
        Dictionary<int, ItemData> dicItemData = new Dictionary<int, ItemData>();

        public void Get_json_Data()
        {
            var path = @"C:/Users/lee85/Desktop/Local_Api/Local_Api/server/src/db/messages.json";
            string json = File.ReadAllText(path);

            ItemData[] arrItemData = JsonConvert.DeserializeObject<ItemData[]>(json);

            foreach (ItemData item in arrItemData)
            {
                dicItemData.Add(item.id, item);
            }
        }


        class ItemData
        {
            public int id;
            public string text;
            public string userId;
            public string timestamp;
        }
    }
}
