using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LearningEFC
    {
        public static void Main(string[] args)
        {
            //GetAllEmpData();
            //GetAllEmpDataByID();
            //AddNewEmployee();
            //DeleteEmployee();
            //UpdateEmployee();
            //GetEmployeesSP();
            //GetEmployeesFromDept();
            RemoveEmpUsingID();

        }

        public static void GetAllEmpData()
        {
            var ctx = new TrainingContext();
            var emps = ctx.Emps;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Ename + ":" + emp.Sal);
            }
        }

        public static void GetAllEmpDataByID()
        {
            var ctx = new TrainingContext();
            var emps = ctx.Emps.Where(e => e.Empno == 7844).SingleOrDefault();
            Console.WriteLine(emps.Ename + ":" + emps.Sal);

        }

        public static void AddNewEmployee()
        {
            var ctx = new TrainingContext();
            Emp employee = new Emp();
            try
            {
                employee.Empno = 2999;
                employee.Ename = "PETER";
                employee.Deptno = 30;
                employee.Comm = 76;
                employee.Sal = 15000;
                employee.Job = "INTERN";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New Employee Added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void DeleteEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 2999;
                employee.Ename = "PETER";
                employee.Deptno = 30;
                employee.Comm = 76;
                employee.Sal = 15000;
                employee.Job = "INTERN";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private static void UpdateEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 2999;
                employee.Ename = "PARKER";
                employee.Deptno = 30;
                employee.Comm = 76;
                employee.Sal = 15000;
                employee.Job = "INTERN";
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Employee Info Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private static void GetEmployeesSP()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw($"GetAllEmps").ToList();

            foreach(var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }
        private static void GetEmployeesFromDept()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw($"GetEmpDetailsFromDept @P0",10).ToList();

            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }
        private static void RemoveEmpUsingID()
        {
            var ctx = new TrainingContext();
            var eno = 7934;
            int rowsAffected = ctx.Database.ExecuteSqlRaw($"RemoveEmployee {eno}");
            Console.WriteLine($"No Of Rows Affected {rowsAffected}");
        }

    }
}
