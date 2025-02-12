using System;

namespace Model
{
public class AdminModel
{
    public int Id { get; set; }
    public string? UserType { get; set; }
    public string? SubUserType { get; set; }
    public string? Email { get; set; }
    public string? DifficultyLevel { get; set; }
    public string? Technology { get; set; }
    public int Experience { get; set; }
    public string? TimeLimit { get; set; }

    public static List<AdminModel> GetSampleData()
    {
        return new List<AdminModel>
        {
            new AdminModel
            {
                Id = 1,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin1@example.com",
                DifficultyLevel = "Advanced",
                Technology = "C#",
                Experience = 10,
                TimeLimit="30"
            },
            new AdminModel
            {
                Id = 2,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user1@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Java",
                Experience = 5,
                TimeLimit= "60"
            },
            new AdminModel
            {
                Id = 3,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin2@example.com",
                DifficultyLevel = "Beginner",
                Technology = "Python",
                Experience = 3,
                TimeLimit="45"
            },
            new AdminModel
            {
                Id = 4,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user2@example.com",
                DifficultyLevel = "Advanced",
                Technology = "JavaScript",
                Experience = 8,
                TimeLimit= "50"
            },
            new AdminModel
            {
                Id = 5,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin3@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "C++",
                Experience = 6,
                TimeLimit="40"
            },
            new AdminModel
            {
                Id = 6,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user3@example.com",
                DifficultyLevel = "Beginner",
                Technology = "Ruby",
                Experience = 2,
                TimeLimit= "55"
            },
            new AdminModel
            {
                Id = 7,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin4@example.com",
                DifficultyLevel = "Advanced",
                Technology = "PHP",
                Experience = 9,
                TimeLimit="35"
            },
            new AdminModel
            {
                Id = 8,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user4@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Swift",
                Experience = 4,
                TimeLimit= "60"
            },
            new AdminModel
            {
                Id = 9,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin5@example.com",
                DifficultyLevel = "Beginner",
                Technology = "Kotlin",
                Experience = 1,
                TimeLimit="30"
            },
            new AdminModel
            {
                Id = 10,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user5@example.com",
                DifficultyLevel = "Advanced",
                Technology = "Go",
                Experience = 7,
                TimeLimit= "45"
            },
            new AdminModel
            {
                Id = 11,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin6@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Rust",
                Experience = 5,
                TimeLimit="50"
            },
            new AdminModel
            {
                Id = 12,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user6@example.com",
                DifficultyLevel = "Beginner",
                Technology = "TypeScript",
                Experience = 3,
                TimeLimit= "40"
            },
            new AdminModel
            {
                Id = 13,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin7@example.com",
                DifficultyLevel = "Advanced",
                Technology = "Scala",
                Experience = 10,
                TimeLimit="55"
            },
            new AdminModel
            {
                Id = 14,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user7@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Perl",
                Experience = 6,
                TimeLimit= "35"
            },
            new AdminModel
            {
                Id = 15,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin8@example.com",
                DifficultyLevel = "Beginner",
                Technology = "Haskell",
                Experience = 2,
                TimeLimit="60"
            },
            new AdminModel
            {
                Id = 16,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user8@example.com",
                DifficultyLevel = "Advanced",
                Technology = "Elixir",
                Experience = 8,
                TimeLimit= "30"
            },
            new AdminModel
            {
                Id = 17,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin9@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Dart",
                Experience = 4,
                TimeLimit="45"
            },
            new AdminModel
            {
                Id = 18,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user9@example.com",
                DifficultyLevel = "Beginner",
                Technology = "Lua",
                Experience = 1,
                TimeLimit= "50"
            },
            new AdminModel
            {
                Id = 19,
                UserType = "Admin",
                SubUserType = "SuperAdmin",
                Email = "admin10@example.com",
                DifficultyLevel = "Advanced",
                Technology = "F#",
                Experience = 9,
                TimeLimit="40"
            },
            new AdminModel
            {
                Id = 20,
                UserType = "User",
                SubUserType = "RegularUser",
                Email = "user10@example.com",
                DifficultyLevel = "Intermediate",
                Technology = "Objective-C",
                Experience = 5,
                TimeLimit= "55"
            }
        };
    }
    }
}
