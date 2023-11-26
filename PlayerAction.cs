using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public enum PlayerActionParameterType
    {
        None = 0,
        Item = 1,
        Tile = 2,
        //Door = 3,
    }

    public class PlayerAction
    {
        public string ActionName { get; set; }
        public bool IsEnabled { get; set; }
        public string ToolTip { get; set; }
        public string ButtonIcon { get; set; }
        public int ButtonPosition { get; set; }
        public int ButtonRow { get; set; }
        public PlayerActionParameterType ParameterType { get; set; }
        public bool CloseOnExecute { get; set; }
    }
}
