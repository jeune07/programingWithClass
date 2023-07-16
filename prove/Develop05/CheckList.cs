namespace GoalTrackerProgram
{
    public class CheckList : Goal
    {

        private  int _targetCount;
        private int _currentCount;
        private int _bonus;

        public CheckList (string title, int targetCount, int value , int bonus) : base (title, value)
        {
            _targetCount = targetCount;
            //_currentCount = value;
            _bonus = bonus;

        }





        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }

        public  string GetProgress()
    {
        return "Completed " + _currentCount + "/" + _targetCount + " times";
    }
    

    public void RecordCompletion()
    {
        _currentCount++;
    }

    public int Bonus
    {
        get { return _bonus; }
    }

    }

}