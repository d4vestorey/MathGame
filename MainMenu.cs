using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathGame.Controllers;
using Spectre.Console;
using static MathGame.Enums;

namespace MathGame
{
    internal class MainMenu
    {

        AdditionController additionController = new AdditionController();

        SubtractionController subtractionController= new SubtractionController();

        MultiplicationController multiplicationController= new MultiplicationController();

        DivisionController divisionController= new DivisionController();

        GameHistoryTable gameHistoryTable= new GameHistoryTable();


        internal void MainMenuPage()
        {
            

            while (true)
            {

                Console.Clear();

                var gameSelection = AnsiConsole.Prompt(
                    new SelectionPrompt<GameSelection>()
                    .Title("What game do you want to play?")
                    .AddChoices(Enum.GetValues<GameSelection>())
                    );

                switch (gameSelection)
                {

                    case GameSelection.Addition:
                        additionController.GenerateQuestion(MathOperator.Add);
                        break;

                    case GameSelection.Subtraction:
                        subtractionController.GenerateQuestion(MathOperator.Subtract);
                        break;

                    case GameSelection.Multiplication:
                        multiplicationController.GenerateQuestion(MathOperator.Multiply);
                        break;

                    case GameSelection.Division:
                        divisionController.GenerateQuestion(MathOperator.Divide);
                        break;
                    
                    case GameSelection.History:
                        gameHistoryTable.GetResults();
                        Console.ReadLine();
                        break;
                }
            }
        }
    }

}