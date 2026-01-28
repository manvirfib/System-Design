namespace oops
{
    // =========================
    // 1️⃣ ABSTRACTION
    // =========================
    // Abstract class defines WHAT to do, not HOW
    abstract class Employee
    {
        // =========================
        // 2️⃣ ENCAPSULATION
        // =========================
        // Private field (data hidden)
        private int salary;

        // Public property to control access
        public int Salary
        {
            get { return salary; }
            protected set
            {
                if (value >= 0)
                    salary = value;
            }
        }

        // Abstract method (no implementation)
        public abstract void CalculateSalary();

        // Concrete method (shared behavior)
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    // =========================
    // 3️⃣ INHERITANCE
    // =========================
    // Developer IS-A Employee
    class Developer : Employee
    {
        public override void CalculateSalary()
        {
            Salary = 50000;
        }
    }

    // Manager IS-A Employee
    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Salary = 80000;
        }
    }

    class Program
    {
        public void VerifyAllOopsConcepts()
        {
            // =========================
            // 4️⃣ POLYMORPHISM
            // =========================
            // Base class reference → derived object
            Employee emp1 = new Developer();
            Employee emp2 = new Manager();

            emp1.CalculateSalary();   // Developer logic
            emp1.DisplaySalary();

            emp2.CalculateSalary();   // Manager logic
            emp2.DisplaySalary();
        }
    }
}