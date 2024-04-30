// See https://aka.ms/new-console-template for more information
using ATM_simulation_application;
using Spectre.Console;

var isAppRunning = true;
while (isAppRunning)
{
    var option = AnsiConsole.Prompt(
    new SelectionPrompt<MenuOptions>()
    .Title("Please select an action:")
    .AddChoices(
        MenuOptions.CreateAccount,
        MenuOptions.DeleteAccount,
        MenuOptions.UpdateAccount,
        MenuOptions.SearchAccount));

    switch (option)
    {
        case MenuOptions.CreateAccount:
            AccountController.CreateAccount();
            break;
        case MenuOptions.DeleteAccount:
            AccountController.DeleteAccount();
            break;
        case MenuOptions.UpdateAccount:
            AccountController.UpdateAccount();
            break;
        case MenuOptions.SearchAccount:
            AccountController.SearchAccount();
            break;
    } 
}

    enum MenuOptions
    {
        CreateAccount,
        DeleteAccount,
        UpdateAccount,
        SearchAccount,
        Exit
    }


