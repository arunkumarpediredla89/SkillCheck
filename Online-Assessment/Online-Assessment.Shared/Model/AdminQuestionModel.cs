using System;

namespace Model;

public class AdminQuestionModel
{
    public int Id { get; set; }
    public string? UserTypes { get; set; }
    public string? Username { get; set; }
    public string? SelectedTechnology { get; set; }
    public string? SelectedSubTechnologies { get; set; } 
    public Dictionary<string, int> QuestionDistribution { get; set; } = new Dictionary<string, int>();
    public int TotalQuestions { get; set; } = 0;
    public string? DifficultyLevel { get; set;} 
    public int TimeLimit { get; set; } = 0;
    public string? NoOfQuestions { get; set; }
    

    public static List<AdminQuestionModel> GetSampleData()
    {
        var sampleDataList = new List<AdminQuestionModel>
        {
            new AdminQuestionModel
            {
            Id = 1,
            UserTypes = "Admin",
            Username = "user_1",
            SelectedTechnology = "C#",
            SelectedSubTechnologies = "ASP.NET",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 20 },
                { "Hard", 5 }
            },
            TotalQuestions = 35,
            DifficultyLevel = "Medium",
            TimeLimit = 60,
            NoOfQuestions = "35"
            },
            new AdminQuestionModel
            {
            Id = 2,
            UserTypes = "User",
            Username = "user_2",
            SelectedTechnology = "Java",
            SelectedSubTechnologies = "Spring",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 25 },
                { "Hard", 10 }
            },
            TotalQuestions = 50,
            DifficultyLevel = "Hard",
            TimeLimit = 90,
            NoOfQuestions = "50"
            },
            new AdminQuestionModel
            {
            Id = 3,
            UserTypes = "Admin",
            Username = "user_3",
            SelectedTechnology = "Python",
            SelectedSubTechnologies = "HTML",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 5 },
                { "Medium", 15 },
                { "Hard", 10 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Easy",
            TimeLimit = 45,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 4,
            UserTypes = "User",
            Username = "user_4",
            SelectedTechnology = "JavaScript",
            SelectedSubTechnologies = "Node.js",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 20 },
                { "Medium", 15 },
                { "Hard", 5 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Medium",
            TimeLimit = 70,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 5,
            UserTypes = "Admin",
            Username = "user_5",
            SelectedTechnology = "Ruby",
            SelectedSubTechnologies = "Ruby on Rails",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 10 },
                { "Hard", 10 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Hard",
            TimeLimit = 50,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 6,
            UserTypes = "User",
            Username = "user_6",
            SelectedTechnology = "PHP",
            SelectedSubTechnologies = "Laravel",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 20 },
                { "Hard", 5 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Medium",
            TimeLimit = 60,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 7,
            UserTypes = "Admin",
            Username = "user_7",
            SelectedTechnology = "C++",
            SelectedSubTechnologies = "Qt",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 5 },
                { "Medium", 25 },
                { "Hard", 10 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Hard",
            TimeLimit = 80,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 8,
            UserTypes = "User",
            Username = "user_8",
            SelectedTechnology = "Swift",
            SelectedSubTechnologies = "UIKit",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 15 },
                { "Hard", 5 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Easy",
            TimeLimit = 45,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 9,
            UserTypes = "User",
            Username = "user_9",
            SelectedTechnology = "Kotlin",
            SelectedSubTechnologies = "Android",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 20 },
                { "Hard", 10 }
            },
            TotalQuestions = 45,
            DifficultyLevel = "Medium",
            TimeLimit = 70,
            NoOfQuestions = "45"
            },
            new AdminQuestionModel
            {
            Id = 10,
            UserTypes = "Admin",
            Username = "user_10",
            SelectedTechnology = "Go",
            SelectedSubTechnologies = "Gin",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 10 },
                { "Hard", 10 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Hard",
            TimeLimit = 50,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 11,
            UserTypes = "Admin",
            Username = "user_11",
            SelectedTechnology = "Rust",
            SelectedSubTechnologies = "Rocket",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 5 },
                { "Medium", 20 },
                { "Hard", 10 }
            },
            TotalQuestions = 35,
            DifficultyLevel = "Medium",
            TimeLimit = 60,
            NoOfQuestions = "35"
            },
            new AdminQuestionModel
            {
            Id = 12,
            UserTypes = "User",
            Username = "user_12",
            SelectedTechnology = "TypeScript",
            SelectedSubTechnologies = "Angular",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 15 },
                { "Hard", 5 }
            },
            TotalQuestions = 35,
            DifficultyLevel = "Easy",
            TimeLimit = 55,
            NoOfQuestions = "35"
            },
            new AdminQuestionModel
            {
            Id = 13,
            UserTypes = "Admin",
            Username = "user_13",
            SelectedTechnology = "Scala",
            SelectedSubTechnologies = "Akka",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 20 },
                { "Hard", 10 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Hard",
            TimeLimit = 70,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 14,
            UserTypes = "User",
            Username = "user_14",
            SelectedTechnology = "Perl",
            SelectedSubTechnologies = "Dancer",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 5 },
                { "Medium", 15 },
                { "Hard", 10 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Medium",
            TimeLimit = 50,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 15,
            UserTypes = "User",
            Username = "user_15",
            SelectedTechnology = "Elixir",
            SelectedSubTechnologies = "Phoenix",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 20 },
                { "Hard", 5 }
            },
            TotalQuestions = 35,
            DifficultyLevel = "Easy",
            TimeLimit = 60,
            NoOfQuestions = "35"
            },
            new AdminQuestionModel
            {
            Id = 16,
            UserTypes = "Admin",
            Username = "user_16",
            SelectedTechnology = "Haskell",
            SelectedSubTechnologies = "Yesod",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 15 },
                { "Hard", 10 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Hard",
            TimeLimit = 70,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 17,
            UserTypes = "User",
            Username = "user_17",
            SelectedTechnology = "Clojure",
            SelectedSubTechnologies = "Luminus",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 20 },
                { "Hard", 10 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Medium",
            TimeLimit = 65,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 18,
            UserTypes = "Admin",
            Username = "user_18",
            SelectedTechnology = "F#",
            SelectedSubTechnologies = "C#",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 5 },
                { "Medium", 25 },
                { "Hard", 10 }
            },
            TotalQuestions = 40,
            DifficultyLevel = "Hard",
            TimeLimit = 80,
            NoOfQuestions = "40"
            },
            new AdminQuestionModel
            {
            Id = 19,
            UserTypes = "Admin",
            Username = "user_19",
            SelectedTechnology = "Objective-C",
            SelectedSubTechnologies = "Cocoa",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 10 },
                { "Medium", 15 },
                { "Hard", 5 }
            },
            TotalQuestions = 30,
            DifficultyLevel = "Easy",
            TimeLimit = 45,
            NoOfQuestions = "30"
            },
            new AdminQuestionModel
            {
            Id = 20,
            UserTypes = "User",
            Username = "user_20",
            SelectedTechnology = "R",
            SelectedSubTechnologies = "Shiny, ggplot2",
            QuestionDistribution = new Dictionary<string, int>
            {
                { "Easy", 15 },
                { "Medium", 20 },
                { "Hard", 10 }
            },
            TotalQuestions = 45,
            DifficultyLevel = "Medium",
            TimeLimit = 70,
            NoOfQuestions = "45"
            }
        };

        return sampleDataList.ToList();
    }
}

