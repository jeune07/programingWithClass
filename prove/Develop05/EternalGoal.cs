namespace GoalTrackerProgram
{
    public class EternnalGoal : Goal
    {
        public EternnalGoal(string title, string description, int value) : base(title, description, value)
        {
        }

        public override void GetDescription()
        {
            throw new NotImplementedException();
        }

        public override string GetProgress()
        {
            throw new NotImplementedException();
        }

        public override void GetTitle()
        {
            throw new NotImplementedException();
        }

        public override void GetValue()
        {
            throw new NotImplementedException();
        }

        public override string IsComplete()
        {
            throw new NotImplementedException();
        }

        public override string SetDescription(string description)
        {
            throw new NotImplementedException();
        }

        public override string SetTitle(string title)
        {
            throw new NotImplementedException();
        }

        public override int SetValue(int value)
        {
            throw new NotImplementedException();
        }
    }
}