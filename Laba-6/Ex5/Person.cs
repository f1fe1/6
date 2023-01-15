using System;

abstract class Person
{
    public abstract string? Importance { get; set; }

    public abstract void Filling();
    public abstract void Filling(string? []obj);
}
