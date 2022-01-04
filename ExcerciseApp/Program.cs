using System;
using System.Collections.Generic;

namespace ExcerciseApp
{
    internal class Program
    {
        public static void Main()
        {
            var workout = new Workout();

            workout.AddExcercise(new Cardio()
            {
                Type = ExcerciseType.Running,
                Distance = 10D,
                Time = new TimeSpan(1, 0, 0),
            });

            var caloriesCalculator = new WorkoutCaloriesCalculation(workout);

            workout.UpdateExcercise(0, distance: 5, time: new TimeSpan(2, 0, 0));
            
            var calories = caloriesCalculator.CalculateTotalBurnedCaloriesByWorkout(WorkoutType.Cardio);
            Console.WriteLine($"Calories: {calories}");
        }
    }
}
