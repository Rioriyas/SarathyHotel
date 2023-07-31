namespace SarathyHotel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int userid { get; set; }
        [Display(Name ="USERNAME")]
        [StringLength(50)]
        public string username { get; set; }
        [Display(Name = "PASSWORD")]
        [StringLength(50)]
        public string password { get; set; }
        [Display(Name = "EMAIL")]
        [StringLength(50)]
        public string email { get; set; }
        [Display(Name = "MOBILE")]
        public long? mobile { get; set; }
        [Display(Name = "ADDRESS")]
        [StringLength(50)]
        public string address { get; set; }
    }
}
