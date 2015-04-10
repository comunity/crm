// Copyright (c) ComUnity 2015
// Hans Malherbe <hansm@comunity.co.za>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CEP
{
    [Table("EmailFaultLog")]
    public class EmailFaultLog : FaultLog
    {
        [Required]
        public virtual EmailFault Fault { get; set; }

        [Required, StringLength(10)]
        public string PostalCode { get; set; }

        [Required, StringLength(50)]
        public string Province { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [StringLength(350)]
        public string EmailAddress { get; set; }

        [Required, StringLength(500)]
        public string Detail { get; set; }

        public bool Integrated { get; set; }
    }
}