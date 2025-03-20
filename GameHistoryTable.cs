using Spectre.Console;

namespace MathGame
{
    internal class GameHistoryTable
    {

        internal void GetResults()
        {
            

            var table = new Table();

            table.Border(TableBorder.Rounded);
            table.AddColumn("[yellow]Number[/]");
            table.AddColumn("[yellow]Number[/]");
            table.AddColumn("[yellow]Actual Answer[/]");
            table.AddColumn("[yellow]Your Answer[/]");

            var scores = GameHistoryStore.Scores;

            foreach (var score in scores)
            {
                table.AddRow(
                    $"[cyan]{score.Number1}[/]",
                    $"[cyan]{score.Number2}[/]",
                    $"[cyan]{score.Answer}[/]",
                    $"[blue]{score.UserAnswer}[/]"
                );
            }

            AnsiConsole.Write(table);
        }

    }
}