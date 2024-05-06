using Microsoft.Data.SqlClient;

namespace TagHelpersInCoreMVC.Models
{
	public class CompanyDBDataContext
	{
		public List<Employee> GetEmployees()
		{
			List<Employee> employees = new List<Employee>();
			using (SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;TrustServerCertificate=True;"))
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
						employee.Eno = Convert.ToInt32(dr["Eno"]);
						employee.Ename = Convert.ToString(dr["Ename"]);
						employee.Salary = Convert.ToDouble(dr["Salary"]);
						employee.Job = Convert.ToString(dr["Job"]);
						employee.Dname = Convert.ToString(dr["Dname"]);
						employees.Add(employee);
					}
				}
				con.Close();
			}
			return employees;
		}
		public void InsertEmp(Employee emp)
		{
			using (SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;TrustServerCertificate=True;"))
			{
				string query = $"insert into Employee values({emp.Eno},'{emp.Ename}',{emp.Salary},'{emp.Job}','{emp.Dname}')";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}
		public void UpdateEmp(Employee emp)
		{
			using (SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;TrustServerCertificate=True;"))
			{
				string query = $"update Employee set Ename='{emp.Ename}',Salary={emp.Salary},Job='{emp.Job}',Dname='{emp.Dname}' where Eno={emp.Eno}";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}
		public void DeleteEmp(int eno)
		{
			using (SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;TrustServerCertificate=True;"))
			{
				string query = $"delete from Employee where Eno={eno}";
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}
		public Employee GetEmployee(int eno)
		{
			Employee employee = new Employee();
			using (SqlConnection con = new SqlConnection("server=.;database=CompanyDB;integrated security=true;TrustServerCertificate=True;"))
			{
				string query = "select * from Employee where Eno="+eno;
				SqlCommand cmd = new SqlCommand(query, con);
				con.Open();
				SqlDataReader dr =  cmd.ExecuteReader();
				if (dr.HasRows)
				{
					if (dr.Read())
					{
						employee.Eno = Convert.ToInt32(dr["Eno"]);
						employee.Ename = Convert.ToString(dr["Ename"]);
						employee.Salary = Convert.ToDouble(dr["Salary"]);
						employee.Job = Convert.ToString(dr["Job"]);
						employee.Dname = Convert.ToString(dr["Dname"]);
					}
				}
				con.Close();
			}

			return employee;
		}
	}
}
