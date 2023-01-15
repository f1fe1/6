using System;

class Child : Person
{
    public new int? Age { get => base.Age; set => base.Age = value; }
    public new string? Name { get => base.Name; set => base.Name = value; }

    public override string ToString() { return base.ToString(); }


    public Child(string? name, int? age) : base(name, age) { }
}
