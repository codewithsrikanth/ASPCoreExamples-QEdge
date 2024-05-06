using System.ComponentModel.DataAnnotations;

namespace TagHelpersInCoreMVC.Models
{
	public class Employee
	{
        
        public int Eno { get; set; }
        [Required]
        [StringLength(10)]
        public string? Ename { get; set; }
        public double Salary { get; set; }
        public string? Job { get; set; }
        public string? Dname { get; set; }
    }
}
