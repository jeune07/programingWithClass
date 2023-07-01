using System;
class Assigments
{
    protected string _name;
    protected string _topic;

    public Assigments(string name, string topic)
    {
         _name = name;
         _topic = topic;
    }

    public string GetSommary(){
        return $"Name: {_name} Topic: {_topic}";
    }
}