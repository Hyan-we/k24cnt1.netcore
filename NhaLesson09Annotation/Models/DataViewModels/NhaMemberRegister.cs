using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NhaLesson09Annotation.Models.DataViewModels
{
    /// <summary>
    /// Data Annotation - Validation
    /// Sinh vien: Nguyen Huy Anh - MSV: 2410900003 - Lop: K24CNT1
    /// </summary>
    public class NhaMemberRegister
    {
        [DisplayName("Ma thanh vien")]
        public int? NhaMemberId { get; set; }

        [DisplayName("Ten dang nhap")]
        [Required(ErrorMessage = "Ten dang nhap khong de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Ten dang nhap co do dai trong khoang 3 - 20 ky tu")]
        public string NhaUserName { get; set; } = string.Empty;

        [DisplayName("Mat khau")]
        [Required(ErrorMessage = "Mat khau khong duoc de trong")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mat khau co do dai trong khoang 6 - 30 ky tu")]
        public string NhaPassword { get; set; } = string.Empty;

        [DisplayName("Hop thu (Email)")]
        [Required(ErrorMessage = "Email khong duoc de trong")]
        [EmailAddress(ErrorMessage = "Email khong dung dinh dang")]
        public string NhaEmail { get; set; } = string.Empty;

        [DisplayName("So dien thoai")]
        [Required(ErrorMessage = "So dien thoai khong duoc de trong")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "So dien thoai phai bat dau bang so 0 va co 10-11 chu so")]
        public string NhaPhoneNumber { get; set; } = string.Empty;

        [DisplayName("Ho va ten")]
        [Required(ErrorMessage = "Ho va ten khong duoc de trong")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ho va ten co do dai trong khoang 2 - 50 ky tu")]
        public string NhaFullName { get; set; } = string.Empty;

        [DisplayName("Ngay sinh")]
        [Required(ErrorMessage = "Ngay sinh khong duoc de trong")]
        [DataType(DataType.Date)]
        public DateTime NhaBirthday { get; set; } = DateTime.Today;
    }
}

