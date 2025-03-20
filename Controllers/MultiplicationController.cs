namespace MathGame.Controllers
{
    internal class MultiplicationController : BaseController
    {
        internal void GenerateQuestion(Enums.MathOperator mathOperator)
        {

            int number1 = GenerateRandomNumber();

            int number2 = GenerateRandomNumber();

            char symbol = GetOperatorSymbol(mathOperator);

            int answer = GenerateAnswer(number1, number2, symbol);

            Console.WriteLine($"What is the answer: {number1} {symbol} {number2} = ??");

            var userAnswer = Console.ReadLine();

            if (int.TryParse(userAnswer, out int number))
            {

                if (number == answer)
                {
                    CorrectResult(number1, number2, answer, number, symbol, mathOperator);
                }
                else
                {
                    IncorrectResult(number1, number2, answer, number, symbol, mathOperator);
                }

            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }    
    }
}