// Copyright (c) ComUnity 2015
// Hans Malherbe <hansm@comunity.co.za>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CEP
{
    public class Feedback
    {
        public int ID { get; set; }

        [Required]
        public virtual UserProfile User { get; set; }

        [Required, StringLength(500)]
        public string Message { get; set; }

        public virtual UserProfile Agent { get; set; }

        public bool Serviced { get; set; }

        [StringLength(100)]
        public string CaseId { get; set; }

        [StringLength(2000)]
        public string Response { get; set; }
    }
}