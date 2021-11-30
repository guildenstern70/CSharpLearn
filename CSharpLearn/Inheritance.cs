/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

using System.Transactions;

namespace CSharpLearn;

///
/// NicePerson Class
///
public class NicePerson : Person
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Person's name</param>
    /// <param name="surname">Person's surname</param>
    public NicePerson(string name, string surname): base(name, surname)
    {
    }
    
    /// <summary>
    /// String representation of person
    /// </summary>
    /// <returns>Name and Surname of person</returns>
    public override string ToString()
    {
        return "Nice Person > " + this.Name + " " + this.Surname;
    }
}