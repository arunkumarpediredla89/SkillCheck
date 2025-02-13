using System;
using Model;

namespace Services;

public class AdminQuestionService
{
     private List<AdminQuestionModel> adminQuestions = new List<AdminQuestionModel>();
     public List<AdminQuestionModel> GetQuestions() => adminQuestions;

        public AdminQuestionService()
        {
            adminQuestions = AdminQuestionModel.GetSampleData();
        }

        public void AddQuestion(AdminQuestionModel question)
        {
            question.Id = adminQuestions.Count + 1;
            adminQuestions.Add(question);
        }

        public void UpdateQuestion(AdminQuestionModel question)
        {
            var existingQuestion = adminQuestions.FirstOrDefault(q => q.Id == question.Id);
            if (existingQuestion != null)
            {
                existingQuestion.UserTypes = question.UserTypes;
                existingQuestion.Username = question.Username;
                existingQuestion.SelectedTechnology = question.SelectedTechnology;
                existingQuestion.SelectedSubTechnologies = question.SelectedSubTechnologies;
                existingQuestion.QuestionDistribution = question.QuestionDistribution;
                existingQuestion.TotalQuestions = question.TotalQuestions;
                existingQuestion.TimeLimit = question.TimeLimit;
                existingQuestion.DifficultyLevel = question.DifficultyLevel;
                existingQuestion.NoOfQuestions = question.NoOfQuestions;
            }
        }

        public void DeleteQuestion(int id)
        {
            var question = adminQuestions.FirstOrDefault(q => q.Id == id);
            if (question != null)
            {
                adminQuestions.Remove(question);
            }
        }

        public void ViewQuestion(int id)
        {
            var question = adminQuestions.FirstOrDefault(q => q.Id == id);
            if (question != null)
            {
                Console.WriteLine("Question ID: " + question.Id);
                Console.WriteLine("User Types: " + question.UserTypes);
                Console.WriteLine("Username: " + question.Username);
                Console.WriteLine("Selected Technology: " + question.SelectedTechnology);
                Console.WriteLine("Selected Sub Technologies: " + question.SelectedSubTechnologies);
                Console.WriteLine("Question Distribution: " + question.QuestionDistribution);
                Console.WriteLine("Total Questions: " + question.TotalQuestions);
                Console.WriteLine("Time Limit: " + question.TimeLimit);
                Console.WriteLine("Difficulty Level: " + question.DifficultyLevel);
                Console.WriteLine("No Of Questions: " + question.NoOfQuestions);
            }
        }

}
