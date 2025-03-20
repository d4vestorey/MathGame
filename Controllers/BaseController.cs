using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MathGame.Models;
using Spectre.Console;

namespace MathGame.Controllers
{
    internal abstract class BaseController
    {
        Random random = new Random();


        internal int GenerateAnswer(int number1, int number2, char symbol)
        {

            switch (symbol)
            {
                case '+':
                    return number1 + number2;

                case '-':
                    return number1 - number2;

                case '*':
                    return number1 * number2;

                case '/':
                    if (number2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero!");
                    
                    return number1 / number2;

                default:
                    throw new ArgumentException("Invalid operator");
            }
        }


        internal int GenerateRandomNumber()
        {

            return random.Next(1, 100);
        }


        internal char GetOperatorSymbol(Enums.MathOperator mo)
        {
            char symbol;

            switch (mo)
            {
                case Enums.MathOperator.Add:
                    symbol = '+';
                    break;

                case Enums.MathOperator.Subtract:
                    symbol = '-';
                    break;

                case Enums.MathOperator.Multiply:
                    symbol = '*';
                    break;

                case Enums.MathOperator.Divide:
                    symbol = '/';
                    break;

                default:
                    throw new ArgumentException("Invalid operator");
            }

            return symbol;
        }

        internal void CorrectResult(int number1, int number2, int answer, int number, char symbol, Enums.MathOperator mathOperator)
        {

            Console.WriteLine($"Thats correct, {number1} {symbol} {number2} = {number}");

            switch (mathOperator)
            {
                case Enums.MathOperator.Add:
                    var score = new AdditionScore(number1, number2, answer, number, true);
                    GameHistoryStore.Scores.Add(score);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Subtract:
                    var subScore = new SubtractionScore(number1, number2, answer, number, true);
                    GameHistoryStore.Scores.Add(subScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Multiply:
                    var multiplyScore = new MultiplicationScore(number1, number2, answer, number, true);
                    GameHistoryStore.Scores.Add(multiplyScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Divide:
                    var divideScore = new DivisionScore(number1, number2, answer, number, true);
                    GameHistoryStore.Scores.Add(divideScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;
            }

        }

        internal void IncorrectResult(int number1, int number2, int answer, int number, char symbol, Enums.MathOperator mathOperator)
        {

            Console.WriteLine($"Thats correct, {number1} {symbol} {number2} = {number}");

            switch (mathOperator)
            {
                case Enums.MathOperator.Add:
                    var score = new AdditionScore(number1, number2, answer, number, false);
                    GameHistoryStore.Scores.Add(score);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Subtract:
                    var subScore = new SubtractionScore(number1, number2, answer, number, false);
                    GameHistoryStore.Scores.Add(subScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Multiply:
                    var multiplyScore = new MultiplicationScore(number1, number2, answer, number, false);
                    GameHistoryStore.Scores.Add(multiplyScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;

                case Enums.MathOperator.Divide:
                    var divideScore = new DivisionScore(number1, number2, answer, number, false);
                    GameHistoryStore.Scores.Add(divideScore);
                    AnsiConsole.MarkupLine("Press Any Key to Continue.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}