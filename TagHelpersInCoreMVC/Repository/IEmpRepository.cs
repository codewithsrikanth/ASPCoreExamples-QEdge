using TagHelpersInCoreMVC.Models;

namespace TagHelpersInCoreMVC.Repository
{
	public interface IEmpRepository
	{
		List<Employee> GetEmployees();
		Employee GetEmployee(int eno);
		void InsertEmployee(Employee employee);
		void UpdateEmployee(Employee employee);
		void DeleteEmployee(int eno);
	}
}
