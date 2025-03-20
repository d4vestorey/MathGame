namespace MathGame.Models
{
    internal abstract class ScoreBase
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Answer { get; set; }
        public int UserAnswer { get; set; }
        public bool isCorrect { get; set; }


        internal ScoreBase(int number1, int number2, int answer, int userAnswer, bool iscorrect)
        {
            Number1 = number1;
            Number2 = number2;
            Answer = answer;
            UserAnswer = userAnswer;
            isCorrect = iscorrect;
        }
    }
}