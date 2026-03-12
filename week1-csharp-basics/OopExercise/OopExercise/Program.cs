using System;

interface IAnimal
{
    string Name { get; }
    void Speak();
}

class Dog : IAnimal
{
    public string Name { get; } = "강아지";
    public void Speak() => Console.WriteLine("멍!");
}

class Cat : IAnimal
{
    public string Name { get; } = "고양이";
    public void Speak() => Console.WriteLine("야옹!");
}