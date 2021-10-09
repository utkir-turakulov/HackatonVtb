using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("DataFields")]
    public class DataFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int DataSetId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public bool IsHeader { get; set; }

        public Dataset Dataset { get; set;}
    }
}
