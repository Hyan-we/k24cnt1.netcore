using System.ComponentModel;

namespace NhaLesson08Models.Models
{
    public class NhaMember
    {
        public string NhaMemberId { get; set; }
        public string NhaUserName { get; set; }
        public string NhaPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string NhaFullName { get; set; }
        public string NhaEmail { get; set; }
    }

}