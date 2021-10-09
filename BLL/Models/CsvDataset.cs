using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CsvDataset
    {
        List<KeyValuePair<int, string>> Data { get; set; } = new();

        List<KeyValuePair<int, string>> Headers { get; set; } = new();
    }
}
