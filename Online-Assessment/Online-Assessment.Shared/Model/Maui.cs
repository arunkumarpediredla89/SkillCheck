using System;
using Online_Assessment.Shared.Model;

namespace Online_Assessment.Shared.Model
{

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Question
    {
        public string question { get; set; }
        public List<string> options { get; set; }
        public string answer { get; set; }
    }
    

    public class Root
    {
        public List<Question> questions { get; set; }
    }
}