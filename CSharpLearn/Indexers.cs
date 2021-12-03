/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

///
/// Indexer Class
/// 
public class Indexer
{
    private readonly List<string> _colors = new List<string>
    {
        "red",
        "blue",
        "yellow",
        "gray"
    }; 
    
    public string this[int index]
    {
        get => this._colors.ElementAt(index);
        set => _colors[index] = value;
    }
}
