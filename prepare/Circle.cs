using System;

public class Circle: Shape
{
    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius( double radius)
    {
        return _radius = radius;
    }

    public Circle(double radius, string color): base(color)
    {
        _radius =radius;
    }

     public override double GetArea()
     {
        return Math.PI * Math.Pow(_radius,2);
     }
}