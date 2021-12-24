/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

public class Multiplier
{
    private int _a, _b;
    
    public int A => this._a;

    public int B => this._b;

    public Multiplier(int a, int b)
    {
        this._a = a;
        this._b = b;
    }

    public int Result => (this._a * this._b);
    
    public override string ToString() => $"{this._a} * {this._b} = {this.Result}";
}