using System;

public class Shape{
    protected string _color;

// contructor that accept color ans set it

public  Shape(string color)
{
    _color = color;
}
    public string GetColor()
    {
        return _color;
    }

    public void SetColor( string color)
    {
        _color = color;

    }

    public virtual Double GetArea()
    {
        return 0;
    }

     
}