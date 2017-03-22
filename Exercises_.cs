using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_
{
    public class Exercises_
    {
        public static void Main()
        {
            List<Exercise_> exercises = new List<Exercise_>();

            var input = Console.ReadLine();
            
            while (input != "go go go")
            {
                var parts = input
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var topic = parts[0];
                var courseName = parts[1];
                var judgeContestLink = parts[2];

                List<string> problems = parts
                    .Skip(3)
                    .ToList();
                
                Exercise_ newExercises = new Exercise_();
                {
                    newExercises.Topic= topic;
                    newExercises.CourseName = courseName;
                    newExercises.JudgeContestLink = judgeContestLink;
                    newExercises.Problems = problems;
                }                   
                
                exercises.Add(newExercises);                  

                input = Console.ReadLine();
            }

            foreach (Exercise_ exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                int count = 1;
                foreach (string problem in exercise.Problems)
                {
                    Console.WriteLine(count +". {0}", problem);

                    count++;
                }
            }           
        }
    }


}
