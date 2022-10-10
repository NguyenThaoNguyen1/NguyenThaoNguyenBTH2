using System.ComponentModel.DataAnnotations;

namespace NguyenThaoNguyen_BTH2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? MaKH { get; set; }
        public string? CoQuan { get; set; }
        public String? Diachi { get; set; }
        public string? Sđt { get; set; }
    }
}