namespace GoalTrackerProgram
{
    public class EternnalGoal : Goal
    {
        public EternnalGoal(string title, string description, int value) : base(title, description, value)
        {
        }

        // public override void GetTitle()
        //         {
        //             throw new NotImplementedException();
        //         }

        // public override void GetDescription()
        // {
        //     throw new NotImplementedException();
        // }

        // public override void GetValue()
        //         {
        //             throw new NotImplementedException();
        //         }

        // public override string GetProgress()
        // {
        //     throw new NotImplementedException();
        // }

        // public override string SetTitle(string title)
        // {
        //     throw new NotImplementedException();
        // }

        // public override string SetDescription(string description)
        // {
        //     throw new NotImplementedException();
        // }

        

        // public override int SetValue(int value)
        // {
        //     throw new NotImplementedException();
        // }
        // public override string IsComplete()
        // {
        //     throw new NotImplementedException();
        // }
        public override string IsComplete()
        {
            throw new NotImplementedException();
        }

        public override string SetTitle(string title)
        {
            Console.WriteLine("Please enter the title:");
            return _title = Console.ReadLine();
        }

        public override void GetTitle()
        {
            Console.WriteLine("The Title is: " + _title);
        }

        public override string SetDescription(string description)
        {
            Console.WriteLine("Please enter the Description of your Goal:");            
            return _description = Console.ReadLine();
        }

        public override void GetDescription()
        {
            Console.WriteLine("The Title is: " + _description);
            
        }

        public override int SetValue(int value)
        {   
            Console.WriteLine("What is the amount of point for this Goal ?: ");           
            //Convert the string to an integer
            return _value = int.Parse(Console.ReadLine());
        }

        public override void GetValue()
        {
            Console.WriteLine("The Title is: " + _value);
        }

        public override string GetProgress()
        {
            return "yes";
        }
        
    }
}