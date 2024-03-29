﻿using EducationPortalConsole.Core.Entities.Materials;
using EducationPortalConsole.Presentation.Session;
using Spectre.Console;

namespace EducationPortalConsole.Presentation.Actions.Materials.EditActions;

public class EditArticleAction : Action
{
    private ArticleMaterial _articleMaterial;

    public EditArticleAction(ArticleMaterial articleMaterial)
    {
        Name = "Edit Article";
        Description = "You can skip field by pressing [blue]<Enter>[/]\n";
        _articleMaterial = articleMaterial;
    }

    public override void Run()
    {
        base.Run();
        var materialService = Configuration.Instance.MaterialService;

        var name = AnsiConsole.Prompt(
            new TextPrompt<string>($"Enter [green]Name[/] (previous: [yellow]{_articleMaterial.Name}[/]):")
                .AllowEmpty());

        if (!string.IsNullOrEmpty(name))
        {
            _articleMaterial.Name = name;
        }

        //Date edit
        DateTime date = new DateTime();
        var dateStr = AnsiConsole.Prompt(
            new TextPrompt<string>($"Enter [green]Date[/] (previous: [yellow]{_articleMaterial.Date.Date}[/]):")
                .AllowEmpty()
        );

        if (!string.IsNullOrEmpty(dateStr))
        {
            if (DateTime.TryParse(dateStr, out date))
            {
                _articleMaterial.Date = date;
            }
            else
            {
                AnsiConsole.Write(new Markup("[red]Input Date[/] was in wrong format, it was not changed\n"));
            }
        }

        var source = AnsiConsole.Prompt(
            new TextPrompt<string>($"Enter [green]Source[/] (previous: [yellow]{_articleMaterial.Source}[/]):")
                .AllowEmpty());

        if (!string.IsNullOrEmpty(source))
        {
            _articleMaterial.Source = source;
        }

        _articleMaterial.UpdatedOn = DateTime.Now;
        _articleMaterial.UpdatedById = UserSession.Instance.CurrentUser.Id;

        materialService.UpdateMaterial(_articleMaterial);

        AnsiConsole.Write(new Markup($"[green]Material[/] updated\n"));

        WaitForUserInput();
        Back(2);
    }
}