namespace GoalTrackerProgram
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string title, int value) : base(title, value)
        {
        }

        public SimpleGoal(string title, string description, int value) : base(title, description, value)
        {
        }

        public override bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public  string GetProgress()
    {
        return "N/A"; // Simple goals have no progress
    }
    }
}