/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */
 
namespace CSharpLearn;

public record Television
{
    public string Inches { get; init; } = default!;
    public bool IsSmart { get; init; } = default!;
};