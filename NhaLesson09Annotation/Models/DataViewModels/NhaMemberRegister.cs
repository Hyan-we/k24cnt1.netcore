using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NhaLesson09Annotation.Models.DataViewModels
{
    /// <summary>
    /// Data Annotation - Validation
    /// Sinh viên: Nguyen Huy Anh - MSV: 2410900003 - Lớp: K24CNT1
    /// </summary>
    public class NhaMemberRegister
    {
        [DisplayName("Mã thành viên")]
        public int? NhaMemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 3 - 20 ký tự")]
        public string NhaUserName { get; set; } = string.Empty;

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu có độ dài trong khoảng 6 - 30 ký tự")]
        public string NhaPassword { get; set; } = string.Empty;

        [DisplayName("Hộp thư (Email)")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string NhaEmail { get; set; } = string.Empty;

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng số 0 và có 10-11 chữ số")]
        public string NhaPhoneNumber { get; set; } = string.Empty;

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Họ và tên có độ dài trong khoảng 2 - 50 ký tự")]
        public string NhaFullName { get; set; } = string.Empty;

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NhaBirthday { get; set; } = DateTime.Today;
    }
}
