using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Data;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperTutorial.Core.interfaces;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        DapperDbContext dbContext;
        public EmployeeRepository()
        {
            dbContext = new DapperDbContext();
        }
        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                string sql = "Select e.Id, e.FirstName, e.LastName, e.Salary, d.Id, d.Name, d.Location" +
                    " From Employee e Inner Join Department d On e.DeptId = d.Id";
                return conn.Query<Employee, Department, Employee>(sql, (e, d) => { e.Dept = d; return e; });
            }
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee obj)
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.Execute("Insert Into Employee Values( @Name, @Age, @DeptId)", obj);
        }

        public int Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}