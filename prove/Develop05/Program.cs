using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example usage:
        var goalTracker = new GoalTracker();

        // Create goals
        var marathonGoal = new SimpleGoal("Run a marathon", 1000);
        var scripturesGoal = new EternalGoal("Read scriptures", 100);

        // Add goals to tracker
        goalTracker.AddGoal(marathonGoal);
        goalTracker.AddGoal(scripturesGoal);

        // Record events (completions)
        goalTracker.RecordEvent(marathonGoal);
        goalTracker.RecordEvent(scripturesGoal);

        // Display user's score
        Console.WriteLine($"Total Score: {goalTracker.GetTotalScore()}");

        // Show list of goals
        goalTracker.DisplayGoals();
    }
}

class Goal
{
    public string Name { get; }
    protected int Points { get; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public virtual void Complete()
    {
        // Base implementation for simple goals
        Console.WriteLine($"Goal completed: {Name}");
    }
}

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void Complete()
    {
        base.Complete();
        // Additional logic specific to simple goals
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    // Override points calculation for eternal goals
    public override void Complete()
    {
        base.Complete();
        // Additional logic specific to eternal goals
    }
}

class ChecklistGoal : Goal
{
    private int completions;

    public ChecklistGoal(string name, int points, int totalCompletions) : base(name, points)
    {
        completions = 0;
        // Set total completions needed for bonus
    }

    public override void Complete()
    {
        base.Complete();
        completions++;
        // Additional logic specific to checklist goals
    }
}

class GoalTracker
{
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.Complete();
    }

    public int GetTotalScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.Points;
        }
        return totalScore;
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Name} [{goal.Points} points]");
        }
    }
}
