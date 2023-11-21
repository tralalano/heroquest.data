using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.sdk.network
{
    public enum TaskType
    {
        SpawnTile,
        SpawnItem,
        Walk,
        Animation,
        SetFocus,
        LoadScene,
        RemoveItem,
        SetItemDirection,
        Pause,
        Equip,
        SetText,
        PlaySound,
        Message,
    }

    public class TaskData
    {
        public TaskType TaskType { get; set; }
        public string TaskName { get; set; }
        public string WaitForTaskName { get; set; }
        public int DelayMs { get; set; }

        public string ObjectName { get; set; }
        public TileData? TileData { get; set; }
        public ItemData? ItemData { get; set; }
        public TilePos? Position { get; set; }
        public ItemAngle Direction { get; set; }
        public AnimationType? Animation { get; set; }
        public LoadData LoadData { get; set; }
        public int Amount { get; set; }
        public EquipmentSlot EquipmentSlot { get; set; }
        public string EquipmentName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Style { get; set; }
    }
}
