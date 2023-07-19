using System;
using System.Collections.Generic;
using System.IO;

namespace GoalTrackerProgram
{
    public class GoalTracker
    {
        private List<Goal> _goals;
        private int _score;

        public GoalTracker(int score)
        {
            _score = score;
            _goals = new List<Goal>();
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void DisplayGoals()
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.ToString());
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine("The current score is: " + _score);
        }

        public void SaveData(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.Title);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.Value);
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Data saved successfully.");
        }

        public void LoadData(string fileName)
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string title = reader.ReadLine();
                    string description = reader.ReadLine();
                    int value = int.Parse(reader.ReadLine());
                    reader.ReadLine(); // Skip the empty line
                    Goal goal = new SimpleGoal(title, description, value);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Data loaded successfully.");
        }
    }
}
