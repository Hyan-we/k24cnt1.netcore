using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NhaLesson09Annotation.Models.DataModels
{
    public class NhaMember
    {
        [DisplayName("Mã thành viên")]
        public string NhaMemberId { get; set; } = string.Empty;

        [DisplayName("Tên đăng nhập")]
        public string NhaUserName { get; set; } = string.Empty;

        [DisplayName("Mật khẩu")]
        public string NhaPassword { get; set; } = string.Empty;

        [DisplayName("Hộp thư / Email")]
        public string NhaEmail { get; set; } = string.Empty;

        [DisplayName("Số điện thoại")]
        public string NhaPhoneNumber { get; set; } = string.Empty;

        [DisplayName("Họ và tên")]
        public string NhaFullName { get; set; } = string.Empty;

        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NhaBirthday { get; set; }
    }
}
