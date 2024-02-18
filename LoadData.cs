using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public class LoadData
    {
        public string FocusedItem { get; set; }
        public string LeftSideTitle { get; set; }
        public string LeftSideText { get; set; }
        public List<TileData> Tiles { get; set; } = new List<TileData>();
        public List<ItemData> Items { get; set; } = new List<ItemData>();
    }
}
