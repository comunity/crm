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
    public class UserProfile
    {
        [Key, Required, StringLength(10, MinimumLength = 10, ErrorMessage = "Mobile number must be exactly 10 digits")]
        public string Cell { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string HouseNumberAndStreetName { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(2000)]
        public string PictureUrl { get; set; }

        [StringLength(10)]
        public string HomePhone { get; set; }

        [StringLength(10)]
        public string WorkPhone { get; set; }

        [StringLength(350)]
        public string Email { get; set; }

        [StringLength(13)]
        public string IdNumber { get; set; }

        [StringLength(100)]
        public string CrmContactId { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<FaultLog> Faults { get; set; }
    }
}