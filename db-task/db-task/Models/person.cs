﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_task.Models
{
    public partial class person
    {
        public person()
        {
            phone = new HashSet<phone>();
        }

        public int id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        public short? age { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? timeStamp { get; set; }

        [InverseProperty("person")]
        public virtual ICollection<phone> phone { get; set; }
    }
}