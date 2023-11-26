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
        public IEnumerable<TileData> Tiles { get; set; } = Enumerable.Empty<TileData>();
        public IEnumerable<ItemData> Items { get; set; } = Enumerable.Empty<ItemData>();
    }
}
