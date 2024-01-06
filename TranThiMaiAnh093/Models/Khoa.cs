using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranThiMaiAnh093 {
    public class Khoa{
        [Key]
        public string MaKhoa {get; set;}
        public string TenKhoa {get; set;}
        public string SoDienThoai {get; set;}
    public string Hovaten { get; set; }
    [ForeignKey("Hovaten")]
    public TranThiMaiAnh? Hoten { get; set; }

    }
}
