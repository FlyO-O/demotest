namespace demo.Models
{
    using System.Collections.Generic;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class UserMessageModel : DbContext
    {        
        public UserMessageModel()
            : base("name=UserMessageModel")
        {
        }

        public DbSet<UserMes> UserMess { get; set; }        
    }
    
    public class UserMes
    {
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string PassWord { get; set; }

        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }
                
        [Display(Name = "电话")]
        public string Tel { get; set; }
                
        [Display(Name = "地址")]
        public string Address { get; set; }
                
        [Display(Name = "年龄")]
        public int Age { get; set; }
                
        [Display(Name = "性别")]
        public int Sex { get; set; }
    }
}