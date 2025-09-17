using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
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
        public string BackgroundColor { get; set; }
        public string BackgroundTexture { get; set; }
        public string WaitingText { get; set; }
        //public string Text { get; set; }
        //public string ConfirmAction { get; set; }
        //public string ConfirmCaption { get; set; }
        public IEnumerable<MenuItem> MenuItems { get; set; }
    }
}
