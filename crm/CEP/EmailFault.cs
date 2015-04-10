// Copyright (c) ComUnity 2015
// Hans Malherbe <hansm@comunity.co.za>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CEP
{
    /*
     * Email based fault handler, e.g. Name: JRA, Description: Joburg Roads, Email: hotline@jra.org.za
     */

    public class EmailFault
    {
        [Key, Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required, StringLength(350)]
        public string Email { get; set; }

        public virtual ICollection<EmailFaultLog> Logs { get; set; }
    }
}