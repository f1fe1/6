using System;
using System.Text;

class Student : Human
{
    string? facultyNumber;

    public string? FacultyNumber 
    {
        get => facultyNumber;
        set
        {
            while (value == null || !(value.Length >= 5 && value.Length <= 10))
            {
                Console.Write("Invalid faculty number!\nFaculty number: ");
                value = Console.ReadLine();
            }

            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format("\nFaculty number: {0}",FacultyNumber));


        return base.ToString() + stringBuilder.ToString();
    }


    public Student(string? firstName, string? lastName, string? facultyNumber) 
        : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }
}