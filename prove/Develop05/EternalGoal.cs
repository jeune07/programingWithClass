namespace GoalTrackerProgram
{
    public class EternnalGoal : Goal
    {
        public EternnalGoal(string title, int value) : base(title, value)
        {
        }

        public EternnalGoal(string title, string description, int value) : base(title, description, value)
        {
        }

        public override bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public string GetProgress()
    {
        return "N/A"; // Eternal goals have no progress
    }
    }

}