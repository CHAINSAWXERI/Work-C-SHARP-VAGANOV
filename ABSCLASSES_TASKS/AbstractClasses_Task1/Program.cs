namespace AbstractClasses_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
            new Manager { Name = "Иванов", PP = 4 },
            new Worker { Name = "Петров", PP = 5 },
            new Administrator { Name = "Сидоров", PP = 8 }
            };

            for(int i = 0; i < employees.Length; i++) 
            {
                Employee employee = employees[i];
                Console.WriteLine(employee.CalculateSalary(i));
            }
        }
    }
    
    public abstract class Employee
    {
        public string Name;
        public float PP; //point performance
    
        public abstract float CalculateSalary(float value);
    }
    public class Manager : Employee
    {
        public override float CalculateSalary(float value)
        {
            float x = (value * PP) / 4;
            return x;
        }
    }
    
    public class Worker : Employee
    {
        public override float CalculateSalary(float value)
        {
            float x = (value + PP) - 2;
            return x;
        }
    }
    
    public class Administrator : Employee
    {
        public override float CalculateSalary(float value)
        {
            float x = (value / PP) * 90;
            return x;
        }
    }

}