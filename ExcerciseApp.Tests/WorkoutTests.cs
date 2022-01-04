using System;
using Xunit;

namespace ExcerciseApp.Tests
{
    public class WorkoutTests
    {
        [Fact]
        public void TestingCreateWorkout()
        {
            var workout = new Workout();
            
            workout.AddExcercise(new Cardio()
            {
                Type = ExcerciseType.Running,
                Distance = 10D,
                Time = new TimeSpan(1, 0, 0),
            });
        }
    }
}
