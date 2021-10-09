using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Headers
    {
        public List<KeyValuePair<int, string>> List { get; set; } = new List<KeyValuePair<int, string>>();
    }
}
