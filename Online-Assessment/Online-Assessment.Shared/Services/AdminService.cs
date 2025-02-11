using System;
using Model;


namespace Online_Assessment.Shared.Services
{
    public class AdminService
{
    private List<AdminModel> users = new List<AdminModel>();

    public List<AdminModel> GetUsers() => users;

    public AdminService()
    {
        users = AdminModel.GetSampleData();
    }

    public void AddUser(AdminModel user)
    {
        user.Id = users.Count + 1;
        users.Add(user);
    }

    public void UpdateUser(AdminModel user)
    {
        var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.UserType = user.UserType;
            existingUser.SubUserType = user.SubUserType;
            existingUser.Email = user.Email;
            existingUser.DifficultyLevel = user.DifficultyLevel;
            existingUser.Technology = user.Technology;
            existingUser.Experience = user.Experience;
        }
    }

    public void DeleteUser(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            users.Remove(user);
        }
    }

}
}

