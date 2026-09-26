using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NhaLesson09Annotation.Models.DataModels
{
    public class NhaMember
    {
        [DisplayName("Ma thanh vien")]
        public string NhaMemberId { get; set; } = string.Empty;

        [DisplayName("Ten dang nhap")]
        public string NhaUserName { get; set; } = string.Empty;

        [DisplayName("Mat khau")]
        public string NhaPassword { get; set; } = string.Empty;

        [DisplayName("Hop thu / Email")]
        public string NhaEmail { get; set; } = string.Empty;

        [DisplayName("So dien thoai")]
        public string NhaPhoneNumber { get; set; } = string.Empty;

        [DisplayName("Ho va ten")]
        public string NhaFullName { get; set; } = string.Empty;

        [DisplayName("Ngay sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NhaBirthday { get; set; }
    }
}

