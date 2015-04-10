using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    public class FaultProgressNote
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(100)]
        public string Note { get; set; }
    }
}
