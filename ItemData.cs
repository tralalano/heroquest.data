using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.sdk.network
{
    public class ItemEquipment
    {
        public EquipmentSlot Slot { get; set; }
        public string EquipmentName { get; set; }
    }

    public class ItemData
    {
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public TilePos Position { get; set; }
        public ItemAngle ItemAngle { get; set; } = ItemAngle.South;
        public IEnumerable<ItemEquipment> Equipment { get; set; }
        public string ToolTip { get; set; }
    }
}
