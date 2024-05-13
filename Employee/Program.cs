namespace Employee;

public abstract class Employee {
    private static int _EmployeeCount;
    protected static int IDStart;

    static Employee() {
        IDStart = 1000;
    }

    public Employee() {
        Employee._EmployeeCount++;
        ID = Employee.IDStart++;
    }

    public static int EmployeeCount { get => _EmployeeCount; }

    public int ID {
        get; init;
    }

    public required string FullName {
        get; set;
    }

    public required string Department {
        get; set;
    }

    public abstract void AdjustPay(decimal percent);

    public override string ToString() {
        return $"{ID}: {FullName}, {Department}";
    }
}

public sealed class HourlyEmployee : Employee {
    public HourlyEmployee() : base() {
    }

    public decimal PayRate {
        get; set;
    }

    public override void AdjustPay(decimal percent) {
        PayRate +=  PayRate * percent;
    }
}

public sealed class SalaryEmployee : Employee {
    public SalaryEmployee() : base() {
    }

    public decimal Salary {
        get; set;
    }

    public override void AdjustPay(decimal percent) {
        Salary += Salary * percent;
    }
}

public class Test {
    public static void Main(string[] args) {
        var emp1 = new HourlyEmployee() {FullName="John Smith", Department="IT"};
        var emp2 = new SalaryEmployee() {FullName="Jane Marie", Department="HR"};
        var emp3 = new HourlyEmployee() {FullName="Joe Lance", Department="AB"};
        var emp4 = new SalaryEmployee() {FullName="Lucy Lawrence", Department="BC"};

        emp1.PayRate = 50.00m;
        emp2.Salary = 70000.00m;

        Console.WriteLine(emp1.ToString());
        Console.WriteLine(emp2.ToString());
        Console.WriteLine(emp3.ToString());
        Console.WriteLine(emp4.ToString());

        emp1.AdjustPay(0.10m);
        emp2.AdjustPay(0.05m);

        Console.WriteLine(emp1.PayRate);
        Console.WriteLine(emp2.Salary);

        Console.WriteLine($"Employee Count = {Employee.EmployeeCount}");
    }
}
