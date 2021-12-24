/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */
 
namespace CSharpLearn;

public record struct Recording(string Artist, string Title)
{
    public Guid Id { get; init; } = default(Guid);
    
}
