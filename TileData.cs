using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.sdk.network
{
    public class TileData
    {
        public TilePos Position { get; set; }
        public WallConfig NorthWallConfig { get; set; }
        public WallConfig WestWallConfig { get; set; }
        public bool FloorHidden { get; set; }
    }
}
