// Copyright (c) ComUnity 2016
// Hans Malherbe <hansm@comunity.co.za>

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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