using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public class GameOption
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }
    public class GameCreatedNotificationRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public List<string> Friends { get; set; }
        public List<GameOption> GameOptions { get; set; } = new List<GameOption>();
    }
}
