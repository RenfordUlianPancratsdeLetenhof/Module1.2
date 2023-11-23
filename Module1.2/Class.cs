using System;
using System.Collections.Generic;

// Інтерфейс для об'єктів, які мають ім'я
public interface INamed
{
    string Name { get; set; }
}

// Абстрактний клас, що реалізує інтерфейс INamed
public abstract class NamedObject : INamed
{
    public string Name { get; set; }
}

// Інтерфейс для об'єктів, які можуть мати підлеглі елементи
public interface IHasSubordinates<T> where T : INamed
{
    List<T> Subordinates { get; set; }
}

// Клас Підприємство
public class Enterprise : NamedObject, IHasSubordinates<Concern>
{
    public List<Concern> Subordinates { get; set; } = new List<Concern>();
    public List<string> Products { get; set; } = new List<string>();
}

// Клас Концерн
public class Concern : NamedObject, IHasSubordinates<Department>
{
    public List<Department> Subordinates { get; set; } = new List<Department>();
}

// Клас Відділ
public class Department : NamedObject, IHasSubordinates<Workshop>
{
    public List<Workshop> Subordinates { get; set; } = new List<Workshop>();
}

// Клас Цех
public class Workshop : NamedObject
{
}