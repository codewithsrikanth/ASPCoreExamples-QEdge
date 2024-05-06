using TagHelpersInCoreMVC.Models;

namespace TagHelpersInCoreMVC.Repository
{
	public class EmpRepository : IEmpRepository
	{
		CompanyDBDataContext dbContext = new CompanyDBDataContext();
		public void DeleteEmployee(int eno)
		{
			dbContext.DeleteEmp(eno);
		}

		public Employee GetEmployee(int eno)
		{
			return dbContext.GetEmployee(eno);
		}

		public List<Employee> GetEmployees()
		{
			List<Employee> emps =  dbContext.GetEmployees();
			return emps;
		}

		public void InsertEmployee(Employee employee)
		{
			dbContext.InsertEmp(employee);
		}

		public void UpdateEmployee(Employee employee)
		{
			dbContext.UpdateEmp(employee);
		}
	}
}
