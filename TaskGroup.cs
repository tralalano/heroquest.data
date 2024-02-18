using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.data
{
    public class TaskGroup
    {
        public IEnumerable<TaskData> Tasks { get; set; } = new List<TaskData>();
    }
}
