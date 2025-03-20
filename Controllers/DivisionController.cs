using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;
using MathGame.Models;

namespace MathGame.Controllers
{
    internal class DivisionController : BaseController
    {
        internal void GenerateQuestion(Enums.MathOperator mathOperator)
        {
            int number1;
            int number2;
            
            do
            {
                number1 = GenerateRandomNumber();

                number2 = GenerateRandomNumber();

                if (number1 < number2)
                {
                    SwitchNumbers(ref number1, ref number2);
                }

            } while (number1 % number2 != 0);

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

        internal void SwitchNumbers(ref int a, ref int b)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }
}