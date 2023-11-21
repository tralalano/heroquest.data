using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.sdk.network
{
    public enum UIActionDisplayType
    {
        NoChange,
        None,
        Buttons,
        DialogList,
    }

    public class UIUpdate
    {
        public UIActionDisplayType DisplayType { get; set; }
        public string Title { get; set; }
        public string ConfirmAction { get; set; }
        public string ConfirmCaption { get; set; }
        public IEnumerable<PlayerAction> PlayerActions { get; set; }
    }
}
