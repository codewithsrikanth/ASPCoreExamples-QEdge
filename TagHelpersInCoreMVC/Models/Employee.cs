using System.ComponentModel.DataAnnotations;

namespace TagHelpersInCoreMVC.Models
{
	public class Employee
	{
        [Required]
        public int Eno { get; set; }
        public string? Ename { get; set; }
        public double Salary { get; set; }
        public string? Job { get; set; }
        public string? Dname { get; set; }
    }
}
