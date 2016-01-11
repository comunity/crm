// Copyright (c) ComUnity 2016
// Hans Malherbe <hansm@comunity.co.za>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CEP
{
    public class FaultLog
    {
        public int ID { get; set; }

        [Required]
        public virtual UserProfile User { get; set; }

        public DateTime? Resolved { get; set; }

        public string StateOfProgress { get; set; }

        [StringLength(2000)]
        public string ResolutionComment { get; set; }

        [StringLength(100)]
        public string CaseId { get; set; }

        public virtual ICollection<FaultProgressNote> ProgressNotes { get; set; }
    }
}