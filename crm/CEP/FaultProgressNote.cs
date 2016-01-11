// Copyright (c) ComUnity 2016
// Hans Malherbe <hansm@comunity.co.za>

using System;
using System.ComponentModel.DataAnnotations;

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
