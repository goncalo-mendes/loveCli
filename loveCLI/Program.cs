// See https://aka.ms/new-console-template for more information

using Spectre.Console;

AnsiConsole.Write(new FigletText("The real question").Color(Color.Red3));
// Ask for the user's favorite fruit
var fruit = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Do you [red]love[/] your [green]Guga[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to make your choice)[/]")
        .AddChoices(new[]
        {
            "Yes", "No"
        }));

if (fruit == "Yes")
{
// Echo the fruit back to the terminal
    AnsiConsole.WriteLine($"I agree. {fruit} is a good choice!");
}
else
{
    AnsiConsole.WriteLine($"Please try again...");
    var fruit2 = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Do you [red]love[/] your [green]Guga[/]?")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to make your choice)[/]")
            .AddChoices(new[]
            {
                "Yes", "No"
            }));
    if (fruit2 == "Yes")
    {
        // Echo the fruit back to the terminal
        AnsiConsole.WriteLine($"A little time but good!");
    }
    else
    {
        AnsiConsole.WriteLine($"Dont you dare lie...");
        var fruit3 = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Do you [red]love[/] your [green]Guga[/]?")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to make your choice)[/]")
                .AddChoices(new[]
                {
                    "Yes", "No"
                }));

        if (fruit3 == "No")
        {
            AnsiConsole.WriteLine($"Lie is bad! Lets go again...");
            var fruit4 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Do you [red]love[/] your [green]Guga[/]?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to make your choice)[/]")
                    .AddChoices(new[]
                    {
                        "Yes", "No"
                    }));
            if (fruit4 == "No")
            {
                AnsiConsole.WriteLine($"For the love of god and your love for your cats tell the truth...");
                var fruit5 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Do you [red]love[/] your [green]Guga[/]?")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to make your choice)[/]")
                        .AddChoices(new[]
                        {
                            "Yes", "No"
                        }));
                AnsiConsole.WriteLine(fruit4 == "Yes" ? $"Finally!" : $"I quit...");
            }
            else
            {
                AnsiConsole.WriteLine($"Finally!");
            }
        }
        else
        {
            AnsiConsole.WriteLine($"Good good!");
        }
    }
}