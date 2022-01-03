﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyWeb.Models
{
    public partial class Member
    {
        public Member()
        {
            MyProductLists = new HashSet<MyProductList>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Email欄位不可空白")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "密碼欄位不可空白")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "姓名欄位不可空白")]
        [StringLength(50)]
        public string UserName { get; set; }

        [InverseProperty(nameof(MyProductList.Member))]
        public virtual ICollection<MyProductList> MyProductLists { get; set; }
    }
}