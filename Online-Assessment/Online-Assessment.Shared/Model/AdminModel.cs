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
            }
        };
    }
}
}