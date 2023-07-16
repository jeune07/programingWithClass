namespace GoalTrackerProgram
{
    public abstract class Goal
    {
        protected string _title;
        protected string _description;
        protected int _value;
        

        public Goal(string title, string description, int value){
            _title = title;
            _description = description;
            _value = value;
        }

        public abstract string SetTitle(string title);
        public  abstract void GetTitle();
        public abstract string SetDescription(string description);
        public abstract void GetDescription();
        public abstract int  SetValue(int value);
        public abstract void GetValue();       

        public abstract string IsComplete();
        public abstract  string GetProgress();   

    }
}