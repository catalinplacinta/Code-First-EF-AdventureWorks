using AdventureWorks.Domain;
using EntityFramework.Seeder;

namespace AdventureWorks.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdventureWorksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AdventureWorksContext context)
        {
            Seeder.Configuration.BufferSize = 10000000;

            #region <Person>

            context.BusinessEntities.SeedFromResource("AdventureWorks.SeedData.Person.Person.csv", businessEntity => businessEntity.BusinessEntityID);
            context.People.SeedFromResource("AdventureWorks.SeedData.Person.Person.csv", person => person.BusinessEntityID);

            #endregion <Person>

            #region <HumanResources>

            context.Employees.SeedFromResource("AdventureWorks.SeedData.HumanResources.Employee.csv", employee => employee.BusinessEntityID);
            context.Departments.SeedFromResource("AdventureWorks.SeedData.HumanResources.Department.csv", department => department.DepartmentID);
            context.JobCandidates.SeedFromResource("AdventureWorks.SeedData.HumanResources.JobCandidate.csv", department => department.JobCandidateID);
            context.Shifts.SeedFromResource("AdventureWorks.SeedData.HumanResources.Shift.csv", shift => shift.ShiftID);
            context.EmployeePayHistories.SeedFromResource("AdventureWorks.SeedData.HumanResources.EmployeePayHistory.csv", employeePayHistory => new { employeePayHistory.BusinessEntityID, employeePayHistory.RateChangeDate });

            context.SaveChanges();

            context.EmployeeDepartmentHistories.SeedFromResource("AdventureWorks.SeedData.HumanResources.EmployeeDepartmentHistory.csv",
                employeDepartmentHistory =>
                    new
                    {
                        employeDepartmentHistory.BusinessEntityID,
                        employeDepartmentHistory.DepartmentID,
                        employeDepartmentHistory.ShiftID,
                        employeDepartmentHistory.StartDate
                    },
                new CsvColumnMapping<EmployeeDepartmentHistory>("BusinessEntityID", (employeeDepartmentHistory, businessEntityId) =>
                    {
                        employeeDepartmentHistory.Employee = context.Employees.Single(x => x.BusinessEntityID.ToString() == businessEntityId.ToString());
                    }),
                new CsvColumnMapping<EmployeeDepartmentHistory>("DepartmentID", (employeeDepartmentHistory, departmentId) =>
                    {
                        employeeDepartmentHistory.Department = context.Departments.Single(x => x.DepartmentID.ToString() == departmentId.ToString());
                    }),
                new CsvColumnMapping<EmployeeDepartmentHistory>("ShiftID", (employeeDepartmentHistory, shiftId) =>
                {
                    employeeDepartmentHistory.Shift = context.Shifts.Single(x => x.ShiftID.ToString() == shiftId.ToString());
                }));

            #endregion <HumanResources>
        }
    }
}
