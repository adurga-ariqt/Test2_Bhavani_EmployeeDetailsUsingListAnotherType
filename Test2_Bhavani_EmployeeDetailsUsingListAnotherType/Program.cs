// See https://aka.ms/new-console-template for more information
using Test2_Bhavani_EmployeeDetailsUsingListAnotherType;

Console.WriteLine("Hello, World!");
List<Employee> employeeList = new List<Employee>();
Employee objectEmployee = new Employee();



bool choice = true;
do
{
    Console.WriteLine("Select One Option\n" +
        "1.  Add Employee\n" +
        "2.  Remove Employee\n" +
        "3.  Insert Employee By Index\n" +
        "4.  Remove Employee By Index\n" +
        "5.  Display All Records\n" +
        "6.  Search Employee\n" +
        "7.  Total Records Count\n" +
        "8.  Clear The List\n" +
        "9.  Clear Console\n" +
        "10.  Stop The Program");
    int selecteOne = int.Parse(Console.ReadLine());



    switch (selecteOne)
    {
        case 1:
            AddEmployee();
            Console.WriteLine("------------------");
            break;
        case 2:
            RemoveEmployee();
            Console.WriteLine("------------------");
            break;
        case 3:
            InsertRecordByIndex();
            Console.WriteLine("------------------");
            break;
        case 4:
            RemoveEmployeeByIndex();
            Console.WriteLine("------------------");
            break;
        case 5:
            ShowAllEmployeeRecords();
            Console.WriteLine("------------------");
            break;
        case 6:
            SearchEmployee();
            Console.WriteLine("------------------");
            break;
        case 7:
            RecordCount();
            Console.WriteLine("------------------");
            break;
        case 8:
            ClearList();
            Console.WriteLine("------------------");
            break;
        case 9:
            ClearConsole();
            Console.WriteLine("------------------");
            break;
        case 10:
            choice = false;
            Console.WriteLine("------------------");
            break;



    }
} while (choice);






void AddEmployee()
{
    Console.WriteLine("Enter How Many Employees Do You Wants To Add");
    int noOfEmployees = int.Parse(Console.ReadLine());



    bool RecordStatus = false;
    for (int loopVariable = 1; loopVariable <= noOfEmployees; loopVariable++)
    {
        Employee objectEmployee = new Employee();
        objectEmployee.AddEmployees();
        employeeList.Add(objectEmployee);
        RecordStatus = true;
    }
    if (RecordStatus)
    {
        Console.WriteLine("*****Employee Records Inserted Successfully******");
    }
}
void RemoveEmployee()
{
    Console.WriteLine("Enter Employee Id To Remove From Records");
    int removeVaiable = int.Parse(Console.ReadLine());



    bool isRecordFound = false;
    foreach (Employee employee in employeeList)
    {
        if (removeVaiable == employee.EmployeeId)
        {
            employeeList.Remove(employee);
            isRecordFound = true;
            break;
        }
    }
    if (isRecordFound)
    {
        Console.WriteLine("Employee Record Removed From Record Successfully");
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Employee ID");
    }
}
void InsertRecordByIndex()
{
    Console.WriteLine("Enter Index Number Where You Want's To Insert New Employee");
    int insertVaiable = int.Parse(Console.ReadLine());



    objectEmployee.AddEmployees();
    employeeList.Insert(insertVaiable, objectEmployee);
    Console.WriteLine("Record Inserted Successfully By Given Index Number ");
}



void RemoveEmployeeByIndex()
{
    Console.WriteLine("Enter Employee Index Number To Remove From Records");
    int indexVariable = int.Parse(Console.ReadLine());



    bool isRemoveVariableFoud = false;
    foreach (Employee employee in employeeList)
    {
        employeeList.RemoveAt(indexVariable);
        isRemoveVariableFoud = true;
        break;
    }
    if (isRemoveVariableFoud)
    {
        Console.WriteLine(" Record deleted by Index number successfully ");
    }
    else
    {
        Console.WriteLine(" Please Enter Valid Employee Index Number ");



    }
}
void ShowAllEmployeeRecords()
{
    Console.WriteLine("-----All Employee Details In The List----------");
    foreach (Employee employee in employeeList)
    {
        employee.DisplayEmployeeDetails();
        Console.WriteLine("___________________________");
    }
}
void SearchEmployee()
{
    Console.WriteLine("Enter employee Id to Search");
    int searchVariable = int.Parse(Console.ReadLine());

    bool isSearchVariableFound = false;
    foreach (Employee emp in employeeList)
    {
        if (searchVariable == emp.EmployeeId)
        {
            objectEmployee = emp;
            isSearchVariableFound = true;
        }
    }
    if (isSearchVariableFound)
    {
        objectEmployee.DisplayEmployeeDetails();
        Console.WriteLine("-----------------------");
    }
    else
    {
        Console.WriteLine(" Please enter valid employee ID ");
    }
}
void RecordCount()
{
    Console.WriteLine("No of records exists in the List  : " + employeeList.Count());
}
void ClearList()
{
    employeeList.Clear();
    Console.WriteLine("Employee List Is Cleared Totally");
}
void ClearConsole()
{
    Console.Clear();
    Console.WriteLine("Consoled Cleared....");
}
