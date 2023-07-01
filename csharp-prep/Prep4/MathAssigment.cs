using System;

class MathAssigment : Assigments
{
    protected string _textBookSection;
    protected string _problems ;

    public MathAssigment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Name: {_name} Topic: {_topic} TextBookSection: {_textBookSection} Problems: {_problems}";
    }
   
    
}