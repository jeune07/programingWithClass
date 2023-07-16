namespace GoalTrackerProgram
{
    public abstract class Goal
    {
        private string _title;
        private string _description;
        private int _value;
        private string title;
        private int value;

        public Goal(string title, string description, int value){
            _title = title;
            _description = description;
            _value = value;
        }

        protected Goal(string title, int value)
        {
            this.title = title;
            this.value = value;
        }

        public string Title
        {
            get { return _title; }
        }

        public int Value
        {
            get { return _value; }
        }

        public abstract bool IsComplete();

        public  string GetProgress(){

            return  _title + " " + ( IsComplete()? " Complete" : " Keep working  yyou are doing well");
        }



    }
}