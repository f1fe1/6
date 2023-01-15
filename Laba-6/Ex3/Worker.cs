using System;
using System.Text;

class Worker : Human
{
    float? weekSalary;
    float? workingHoursPerDay;
    float? salaryPerHour;

    public float? WeekSalary
    {
        get => weekSalary;
        set
        {
            while (value == null || value <= 10)
            {
                Console.Write("Expected value mismatch! Argument: {0:0.00}\nWeek salary: ", value);
                value = Convert.ToSingle(Console.ReadLine());
            }

            weekSalary = value;
        }
    }
    public float? WorkingHoursPerDay
    {
        get => workingHoursPerDay;
        set
        {
            while (value == null || !(value > 0 && value <= 12))
            {
                Console.Write("Expected value mismatch! Argument: {0:0.00}\nHours per day: ", value);
                value = Convert.ToSingle(Console.ReadLine());
            }

            workingHoursPerDay = value;
        }
    }
    public float? SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value;  }



    static float? CaltulateSalaryPerHour(float? weekSalary, float? hourPerDay) => weekSalary / (hourPerDay * 5);



    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format("\nWeek Salary: {0:0.00}\nHours per day: {1:0.00}\nSalary per hour: {2:0.00}",
            WeekSalary, WorkingHoursPerDay, SalaryPerHour));


        return base.ToString() + stringBuilder.ToString();
    }


    public Worker(string? firstName, string? lastName, float? weekSalary, float? workingHoursPerDay)
        : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkingHoursPerDay = workingHoursPerDay;
        salaryPerHour = CaltulateSalaryPerHour(WeekSalary, WorkingHoursPerDay);
    }
}
