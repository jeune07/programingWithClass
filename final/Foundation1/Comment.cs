using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; }
    public string Text { get; }

    public Comment(string _name, string _text)
    {
        Name = _name;
        Text = _text;
    }
}