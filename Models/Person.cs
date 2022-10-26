using System.ComponentModel.DataAnnotations;

namespace NguyenThaoNguyen_BTH2.Models
{
    // taọ class Employee
    public class Person
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public String? Sđt { get; set; }
         public string? Sothich { get; set; }
    }
}