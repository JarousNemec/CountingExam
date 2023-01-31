namespace CountingExam.Models
{
    public class Settings
    {
        public Settings(Difficulties difficulty, int interval, bool speech)
        {
            Difficulty = difficulty;
            Interval = interval;
            Speech = speech;
        }

        public Difficulties Difficulty { get; set; }
        public int Interval { get; set; }
        public bool Speech { get; set; }
        
    }
}