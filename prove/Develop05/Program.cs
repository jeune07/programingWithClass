using System;
using GoalTrackerProgram;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \n Select Choice From The Menu");

        string _userOption = Console.ReadLine();

        if (_userOption == "1")
        {
            Console.WriteLine("The type of Goal are : \n 1. Simple Goal \n 2. Eternal Goal \n  3. CheckList Goal \n Which type of goal would you like to create ");
            string _userGoalSelected = Console.ReadLine();

            if (_userGoalSelected == "1")
            {
                SimpleGoal aSimpleGoal = new SimpleGoal("Study","everday this is not a description",10);
                aSimpleGoal.SetTitle("This is the title of the simple Goal");
                aSimpleGoal.SetDescription("jeune");
                aSimpleGoal.SetValue(10);  

                GoalTracker goalTracker = new GoalTracker(0);
                goalTracker.AddGoal(aSimpleGoal);
            }
            else if (_userGoalSelected == "2")
            {
                // Code for creating an eternal goal
            }
            else if (_userGoalSelected == "3")
            {
                // Code for creating a checklist goal
            }
        }

        
    }
}
