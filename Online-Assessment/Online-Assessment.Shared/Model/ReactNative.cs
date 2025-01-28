using System;
using Online_Assessment.Shared.Model;

namespace Online_Assessment.Shared.Model
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ReactNativeQuestion
    {
        public string question { get; set; }
        public List<string> options { get; set; }
        public string answer { get; set; }
        public string priority { get; set; }
    }

    public class ReactNativeRoot
    {
        public List<ReactNativeQuestion> questions { get; set; }
    }

}



