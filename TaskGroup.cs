using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroquest.sdk.network
{
    public class TaskGroup
    {
        public IEnumerable<TaskData> Tasks { get; set; } = Enumerable.Empty<TaskData>();
    }
}
