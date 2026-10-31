using System.Collections.Generic;

namespace MauiApp2.Models;

public enum QuizDifficulty
{
    Easy,
    Medium,
    Hard
}

public class QuizQuestion
{
    public string QuestionText { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOptionIndex { get; set; }
    public QuizDifficulty Difficulty { get; set; }

    public QuizQuestion(string text, List<string> options, int correctIndex, QuizDifficulty difficulty)
    {
        QuestionText = text;
        Options = options;
        CorrectOptionIndex = correctIndex;
        Difficulty = difficulty;
    }
}