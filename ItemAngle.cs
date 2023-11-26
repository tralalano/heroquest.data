using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public record class ItemAngle
    {
        public int Value { get; private set; }

        public ItemAngle(int value)
        {
            Value = value % 4;
        }

        public static readonly ItemAngle North = new ItemAngle(0);
        public static readonly ItemAngle East = new ItemAngle(1);
        public static readonly ItemAngle South = new ItemAngle(2);
        public static readonly ItemAngle West = new ItemAngle(3);
        public static readonly ItemAngle[] All = new[] { North, East, South, West };

        public ItemAngle Left() => new ItemAngle(Value + 3);
        public ItemAngle Right() => new ItemAngle(Value + 1);
        public ItemAngle Opposite() => new ItemAngle(Value + 2);
    }
}
