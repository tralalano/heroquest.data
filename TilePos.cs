using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public record class TilePos
    {
        public int X { get; set; }
        public int Y { get; set; }

        public TilePos Next(ItemAngle angle) =>
            angle.Value switch
            {
                0 => new TilePos { X = X, Y = Y + 1 },
                1 => new TilePos { X = X + 1, Y = Y },
                2 => new TilePos { X = X, Y = Y - 1 },
                3 => new TilePos { X = X - 1, Y = Y },
            };

        public IEnumerable<TilePos> Neighbours() =>
            ItemAngle.All.Select(dir => Next(dir));

        public override string ToString()
        {
            return "{" + X + "," + Y + "}";
        }
    }
}
