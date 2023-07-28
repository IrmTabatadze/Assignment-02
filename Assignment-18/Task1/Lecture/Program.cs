using Lecture;

var departments1 = new List<Department>()
{
    new Department() {Id = 1, Name = "Department1"},
    new Department() {Id = 2, Name = "Department2"}
};

var departments2 = new List<Department>()
{
    new Department() {Id = 1, Name = "Department1"},
    new Department() {Id = 2, Name = "Department2"},
    new Department() {Id = 3, Name = "Department3"},
    new Department() {Id = 8, Name = "Department8"},
};

var employees = new List<Employee>()
{
    new Employee() {Name = "Emp1", Id = 1, DepartmentId = 1, IncomeByMonths = new List<int>() {100,200,300}},
    new Employee() {Name = "Emp2", Id = 2, DepartmentId = 2, IncomeByMonths = new List<int>() {100,200,300}},
    new Employee() {Name = "AEmp3", Id = 3, DepartmentId = 2, IncomeByMonths = new List<int>() {110,200,300}},
    new Employee() {Name = "Emp4", Id = 4, DepartmentId = 3, IncomeByMonths = new List<int>() {110,200,300}},
    new Employee() {Name = "AEmp5", Id = 5, DepartmentId = 3, IncomeByMonths = new List<int>() {100,220,300}},
    new Employee() {Name = "FEmp5", Id = 6, DepartmentId = 4, IncomeByMonths = new List<int>() {100,220,300}},
    new Employee() {Name = "FEmp6", Id = 7, DepartmentId = 20, IncomeByMonths = new List<int>() {100,220,300}},
};

var pets = new List<Pet>()
{
    new Pet() {Id = 1, Name = "Pet1", OwnerId = 1},
    new Pet() {Id = 2, Name = "Pet4", OwnerId = 1},
    new Pet() {Id = 3, Name = "Emp2", OwnerId = 2},
    new Pet() {Id = 4, Name = "Pet6", OwnerId = 2},
};

var company = new Company()
{
    Name = "Test",
    Departments = departments1
};

var stringList = new List<string>() { "string1", "string2", "string3" };
var stringList2 = new List<string>() { "string1", "string3", "string4" };

var unionTest = stringList.Union(stringList2);
var unionTestQueryVersion = (from str1 in stringList select str1)
                            .Concat(from str2 in stringList2 select str2)
                            .Distinct();

var departments3 = departments1.Union(departments2, new DepartmentComparer());

var departments4 = departments1.UnionBy(departments2, x => x.Name);

//foreach (var str in unionTest)
//{
//    Console.WriteLine(str);
//}

// foreach (var department in unionTest)
// {
//     Console.WriteLine(department);
// }
//
// foreach (var department in unionTestQueryVersion)
// {
//     Console.WriteLine(department);
// }

var group1 = employees.GroupBy(x => x.DepartmentId);

var group1QueryVersion = from emp in employees
                         group emp by emp.DepartmentId
    into grp1
                         select grp1;

//foreach (var grp in group1QueryVersion)
//{
//    Console.WriteLine(grp.Key);

//    foreach (var item in grp)
//    {
//        Console.WriteLine("    " + item.Name);
//    }
//}

var groupEmployees = employees.GroupBy(x => x.Name[0]);
var groupEmployeesQuery = from emp in employees
                          group emp by emp.Name[0] into grp1
                          select grp1;

var groupEmployeesByAvgIncome = employees.GroupBy(x => x.IncomeByMonths.Average());
var groupEmployeesByAvgIncomeQuery = from emp in employees
                                     let avg = emp.IncomeByMonths.Average()
                                     group emp by avg
    into grp1
                                     select grp1;

var groupEmployeesByAvgIncome2 =
    employees.GroupBy(x => x.IncomeByMonths.Average() > 201 ? "More than 201" : "Less than 201");

// foreach (var grp in groupEmployeesByAvgIncome2)
// {
//     Console.WriteLine(grp.Key);
//
//     foreach (var item in grp)
//     {
//         Console.WriteLine("    " + item.Name);
//     }
// }

var methodSyntaxJoin = departments1
    .Join(departments2, x => x.Id, x => x.Id, (d1, d2) => new
    {
        Department1Name = d1.Name,
        d2.Name
    }).ToList();

var depsAndEmployees = employees.Join(departments2, x => x.DepartmentId, x => x.Id, (e, d) => new
{
    e.Name,
    DepartmentId = d.Id
});

var querySyntaxJoin = from employee in employees
                      join pet in pets on employee.Id equals pet.OwnerId
                      select new { employee.Name, PetName = pet.Name };

var joinWithMultipleKeys = employees.Join(pets, x => new { x.Id, x.Name }, x => new { Id = x.OwnerId, x.Name },
    (o, p) => new { OwnerId = o.Id, PetId = p.Id });

var sameMultiplePropJoinWithQuery = from emp in employees
                                    join pet in pets on new { emp.Id, emp.Name } equals new { Id = pet.OwnerId, pet.Name }
                                    select new { OwnerId = emp.Id, PetId = pet.Id };


var multiplJoin = employees
    .Join(departments2, x => x.DepartmentId, x => x.Id, (e, d) => new
    {
        e.Name,
        DepartmentId = d.Id,
        EmployeId = e.Id
    }).Join(pets, x => x.EmployeId, x => x.OwnerId, (de, p) => new
    {
        de.DepartmentId,
        de.EmployeId,
        p.Name
    });

// foreach (var result in methodSyntaxJoin)
// {
//     Console.WriteLine($"{result.Name}, {result.Department1Name}");
// }

var depsAndEmployeesOuter = from emp in employees
                            join depart in departments1 on emp.DepartmentId equals depart.Id into grp1
                            from depr in grp1.DefaultIfEmpty()
                            select new { depr?.Name, depr?.Id, EmployeeName = emp.Name };

foreach (var result in depsAndEmployeesOuter)
{
    Console.WriteLine($"{result.Name}, {result.EmployeeName}, {result.Id}");
}

var employeesConverted = employees.ToList();

var employeeElements = employees.ElementAt(1);
var employeeElements1 = employees.ElementAtOrDefault(99);
var employeeElements2 = employees.First(x => x.Name.Contains('d'));
var employeeElements3 = employees.FirstOrDefault(x => x.Name.Contains('d'));
var employeeElements4 = employees.Last();
var employeeElements5 = employees.LastOrDefault();
var employeeElements6 = employees.Single(x => x.Id == 1);
var employeeElements7 = employees.SingleOrDefault(x => x.Id == 1);


var count = employees.Count();
var salaryCount = employees[0].IncomeByMonths.Count();
var salaySum = employees.Select(x => x.IncomeByMonths.Sum());
var salaryAvarege = employees.Select(x => x.IncomeByMonths.Average());
var maxEmp = employees.MaxBy(x => x.IncomeByMonths.Max());
var minEmp = employees.MinBy(x => x.Id);

var empdasc = employees.OrderBy(x => x.Id);
var empdesc = employees.OrderByDescending(x => x.Id);

Console.ReadKey();