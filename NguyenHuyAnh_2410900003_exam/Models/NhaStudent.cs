using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenHuyAnh_2410900003_exam.Models
{
    [Table("NhaStudent")]
    public class NhaStudent
    {
        [Key]
        [Display(Name = "Ma so (ID)")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ho va ten khong duoc de trong!")]
        [StringLength(100, ErrorMessage = "Ho va ten khong duoc vuot qua 100 ky tu!")]
        [Display(Name = "Ho va ten")]
        public string NhaName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui long chon gioi tinh!")]
        [Display(Name = "Gioi tinh")]
        public bool NhaGender { get; set; }

        [Required(ErrorMessage = "Ngay sinh khong duoc de trong!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngay sinh")]
        public DateTime NhaBirthDay { get; set; }

        [Required(ErrorMessage = "Email khong duoc de trong!")]
        [EmailAddress(ErrorMessage = "Dia chi Email khong dung dinh dang!")]
        [StringLength(100, ErrorMessage = "Email khong duoc vuot qua 100 ky tu!")]
        [Display(Name = "Dia chi Email")]
        public string NhaEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "So dien thoai khong duoc de trong!")]
        [RegularExpression(@"^(0[3|5|7|8|9])+([0-9]{8})$", ErrorMessage = "So dien thoai phai la so dien thoai Viet Nam hop le (10 so, bat dau bang 03, 05, 07, 08, 09)!")]
        [StringLength(20, ErrorMessage = "So dien thoai khong duoc vuot qua 20 ky tu!")]
        [Display(Name = "So dien thoai")]
        public string NhaPhone { get; set; } = string.Empty;

        [Display(Name = "Trang thai hoat dong")]
        public bool NhaActive { get; set; } = true;

        [NotMapped]
        public string GenderText => NhaGender ? "Nam" : "Nu";

        [NotMapped]
        public string StatusText => NhaActive ? "Dang hoat dong" : "Tam khoa";
    }
}

