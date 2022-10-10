using System.ComponentModel.DataAnnotations;

namespace NguyenThaoNguyen_BTH2.Models
{
    public class Employee
    {
         public int Id { get; set; }
        public string? MaNV { get; set; }
        public int MaPhongBan { get; set; }
        public String? TenNv { get; set; }
        public string? diachi { get; set; }
    }
}