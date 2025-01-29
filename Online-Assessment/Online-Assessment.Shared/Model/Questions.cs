using System;

namespace Online_Assessment.Shared.Model
{
public class QuestionModel
{
    public string QuestionText { get; set; }
    public List<string> Options { get; set; }
    public string Answer { get; set; }
    public string Priority { get; set; }
}
}

