﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Npgsql.Bulk.DAL
{
    [Table("addresses2", Schema = "public")]
    public class Address2 : Address
    {
        [Column("address2_id"), Key(), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Address2Id { get; set; }

        [Column("localized_name"), Required()]
        public string LocalizedName { get; set; }

        [Column("index2")]
        public int Index2 { get; set; }
    }
}
