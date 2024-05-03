using Microsoft.Data.SqlClient;

namespace TagHelpersInCoreMVC.Models
{
	public class CompanyDBDataContext
	{
		public List<Employee> GetEmployees()
		{
			List<Employee> employees = new List<Employee>();
			using(SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;"))
			{
				string query = "select * from Employee";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows)
				{
					while (dr.Read())
					{
						Employee employee = new Employee();
						employee.Eno =Convert.ToInt32(dr["Eno"]);
						employee.Ename =Convert.ToString(dr["Ename"]);
						employee.Salary =Convert.ToDouble(dr["Salary"]);
						employee.Job =Convert.ToString(dr["Job"]);
						employee.Dname = Convert.ToString(dr["Dname"]);
						employees.Add(employee);
					}
				}
				con.Close();
			}
			return employees;
		}
	}
}
