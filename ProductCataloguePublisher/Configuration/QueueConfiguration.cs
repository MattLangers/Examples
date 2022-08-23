using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Configuration
{
    internal class QueueConfiguration
    {
        public string StorageConnectionString { get; set; }

        public string QueueName { get; set; }
    }
}
