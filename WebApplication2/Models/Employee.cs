namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int eid { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Tên")]
        [StringLength(30)]
        public string name { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Tuổi")]
        public int? age { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Địa chỉ")]
        [StringLength(30)]
        public string addr { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Lương")]
        public int? salary { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [DisplayName("Ảnh")]
        [StringLength(50)]
        public string image { get; set; }

        public int? deptid { get; set; }

        public virtual Department Department { get; set; }
    }
}
