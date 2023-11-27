namespace AzureOpenAIChat.Models
{
    public class StepsTaken
    {
        public string thought { get; set; }
        public string action { get; set; }
        public Dictionary<string, string> action_variables { get; set; }
        public string observation { get; set; }
        public string final_answer { get; set; }
        public string original_response { get; set; }
    }
}
