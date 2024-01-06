using System.ComponentModel.DataAnnotations;

namespace TranThiMaiAnh093 {
    public class TranThiMaiAnh{
        [Key]
        public string Hovaten {get; set;}
        public int Tuoi {get;set;}
        public float Diem {get;set;}
    }

}