namespace User.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class UserModels : DbContext
    {
        public UserModels()
            : base("name=UserModels")
        {
        }
        
        public DbSet<UserMessage> UserMessages { get; set; }
    }

    public class UserMessage
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [Display(Name="账号")]
        [StringLength(32, MinimumLength = 1)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="密码")]
        [StringLength(32, MinimumLength = 8)]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-zA-Z]).{8,30}",ErrorMessage="必须包含数字和大小写字母")]
        public string PassWord { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("PassWord", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }

        //旧密码
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        [StringLength(32, MinimumLength = 8)]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-zA-Z]).{8,30}", ErrorMessage = "必须包含数字和大小写字母")]
        public string OldPassword { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Required(AllowEmptyStrings=true)]        
        [Display(Name="电话")]
        public int Tel { get; set; }

    }

}