using System;

class WrittindAssigment : Assigments
{
   protected string _title;

   public WrittindAssigment(string name, string topic, string title) : base(name, topic)
   {
       _title = title;
   }

   public string information()
   {
       return $"Name: {_name} Topic: {_topic} Title: {_title}";
   }
   
    
}