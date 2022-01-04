using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseApp
{
    public class WorkoutCaloriesCalculation
    {
        private Workout workout;

        public WorkoutCaloriesCalculation(Workout workout)
        {
            this.workout = workout;
        }

        public double CalculateTotalBurnedCalories()
        {
            double totalBurnedCalories = 0;
            foreach (var item in workout.GetExcercises())
            {
                totalBurnedCalories += item.CalculateBurnedCalories();
            }

            return totalBurnedCalories;
        }

        public double CalculateTotalBurnedCaloriesByWorkout(WorkoutType workoutType)
        {
            double totalBurnedCalories = 0;
            foreach (var item in workout.GetExcercises())
            {
                if (item.GetType().Name == workoutType.ToString())
                {
                    totalBurnedCalories += item.CalculateBurnedCalories();
                }
            }

            return totalBurnedCalories;
        }

        public double CalculateTotalBurnedCaloriesByWorkoutAndExcercise(WorkoutType workoutType, ExcerciseType excerciseType)
        {
            double totalBurnedCalories = 0;
            foreach (var item in workout.GetExcercises())
            {
                if (item.GetType().Name == workoutType.ToString())
                {
                    if (item is Cardio c)
                    {
                        if (c.Type == excerciseType)
                        {
                            totalBurnedCalories += c.CalculateBurnedCalories();
                        }
                    }
                    else if (item is WeightLifting wl)
                    {
                        if (wl.Type == excerciseType)
                        {
                            totalBurnedCalories += wl.CalculateBurnedCalories();
                        }
                    }
                }
            }

            return totalBurnedCalories;
        }
    }
}
