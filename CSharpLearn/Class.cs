/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

///
/// Person Class
/// 
public class Person
{
    /// <summary>
    /// Properties
    /// </summary>
    public string Name { get; set; }
    public string Surname { get; set; }
    
    /// <summary>
    /// Constructor
    /// </summary>
    public Person()
    {
        this.Name = "?";
        this.Surname = "?";
    }
    
    ~Person()  // finalizer
    {
        // cleanup statements...
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="surname">Surname</param>
    public Person(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }
    
    /// <summary>
    /// String representation of person
    /// </summary>
    /// <returns>Name and Surname of person</returns>
    public override string ToString()
    {
        return "Person > " + this.Name + " " + this.Surname;
    }
}
