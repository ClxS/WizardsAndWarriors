// See https://aka.ms/new-console-template for more information

using Spectre.Console;
using WizardsAndWarriors;
using WizardsAndWarriors.Classes;

Weapon[] startingGear = new[]
{
    new Weapon("Celestial Sword", WeaponType.Sword),
    new Weapon("Celestial Staff", WeaponType.Staff),
    new Weapon("Celestial Axe", WeaponType.Axe),
    new Weapon("Celestial Dagger", WeaponType.Dagger),
    new Weapon("Celestial Bow", WeaponType.Bow),
    new Weapon("Celestial Lance", WeaponType.Lance),
};

AnsiConsole.MarkupLine("[underline red]Welcome to[/] [bold yellow]Wizards and Warriors![/]");

AnsiConsole.MarkupLine("[bold]Guide: [/] Now then, what is your name?");

var name = AnsiConsole.Ask<string>("[bold]You: [/]");

AnsiConsole.MarkupLine($"[bold]Guide: [/]Hmmm, [underline]{name}[/] is it? What a bizarre name... What class would you like to play?");

ClassSpecification classSpecification = AnsiConsole.Prompt(
    new SelectionPrompt<ClassSpecification>()
        .Title("[bold]Guide: [/]Choose your class")
        .AddChoices(Classes.All.OrderBy(a => a.Name))
        .UseConverter(x => x.Name));

Player player = new()
{
    Name = name,
    ClassSpecification = classSpecification,
};

AnsiConsole.MarkupLine($"[bold]Guide: [/]A {classSpecification.Name}! Magnificent! I dated a {classSpecification.Name} once... Long story, a lot of bloodshed... Anyway... Let's get you started. You need some weapons, hurry up, choose!");

Weapon weapon = AnsiConsole.Prompt(
    new SelectionPrompt<Weapon>()
        .Title("[bold]Guide: [/]Choose your weapon")
        .AddChoices(startingGear.Where(weapon => RuleBook.CanEquip(player, weapon)))
        .UseConverter(x => x.Name));

player.Weapon = weapon;
AnsiConsole.MarkupLine($"[bold]Guide: [/]A {weapon.Name}! Excellent choice! Now, go forth and conquer!");