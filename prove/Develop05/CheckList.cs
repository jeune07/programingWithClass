namespace GoalTrackerProgram
{
    public class CheckList : Goal
    {

        private  int _targetCount;
        private int _currentCount;
        private int _bonus;

        public CheckList(string title, string description, int value, int targetCount, int currentCount, int bonus) : base(title, description, value)
        {
            _targetCount = targetCount;
            _currentCount = currentCount;
            _bonus = bonus;
        }

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

        public int SetTargetCount(int targetCount){
            Console.WriteLine("How many time does this goal need to be acomplish for a Bonus ?: ");           
            //Convert the string to an integer
            return _targetCount = int.Parse(Console.ReadLine());

            
        }

        public int SetBonus(int bonus){
            Console.WriteLine("What is the Bonus for this goal?: ");           
            //Convert the string to an integer
            return _bonus = int.Parse(Console.ReadLine());

            
        }

        public void GetBonus(){
            Console.WriteLine("The Title is: " + _bonus);
        }

        public void GetTargetCount(){
            Console.WriteLine("The Title is: " + _targetCount);
        }
    }

}