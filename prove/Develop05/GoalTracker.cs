using System;
using System.Collections.Generic;

namespace GoalTrackerProgram{

    public class GoalTracker{

        private List<Goal> _goals;
        private int _score;

        public GoalTracker(int score){
            _score = score;
            _goals = new List<Goal>();

        }

        public void  AddGoal(Goal goal){
            _goals.Add(goal);

        }

        // public void RecordEvent(){
        //     _score  = goal.GetValue;
        // }

        public void DisplayGoal(){
            foreach (Goal goal in _goals){
                Console.WriteLine(goal.ToString());
            }
        }

        public void DisplayScore(){
            Console.WriteLine("The the actual scroe is " + _score);
        }

         public void SaveData()
        {
            // Code to save goals and score to a file or database
            Console.WriteLine("Data saved successfully.");
        }

        public void LoadData()
        {
            // Code to load goals and score from a file or database
            Console.WriteLine("Data loaded successfully.");
        }

        }

}