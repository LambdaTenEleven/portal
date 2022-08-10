﻿using EducationPortalConsole.BusinessLogic.Services;
using EducationPortalConsole.Core.Entities.Materials;
using EducationPortalConsole.Presentation.Extensions;
using EducationPortalConsole.Presentation.Session;
using Spectre.Console;

namespace EducationPortalConsole.Presentation.Actions.Materials.EditActions;

public class EditVideoAction : Action
{
    private VideoMaterial _videoMaterial;
    public EditVideoAction(VideoMaterial videoMaterial)
    {
        Name = "Edit Video";
        Description = "You can skip field by pressing [blue]<Enter>[/]\n";
        _videoMaterial = videoMaterial;
    }

    public override void Run()
    {
        base.Run();
        
        IMaterialService materialService = Configuration.Instance.MaterialService;
        
        var name = AnsiConsole.Prompt(
            new TextPrompt<string>($"Enter [green]Name[/] (previous: [yellow]{_videoMaterial.Name}[/]):")
                .AllowEmpty());

        if (!name.IsNullOrEmpty())
        {
            _videoMaterial.Name = name;
        }
        
        TimeSpan time = new TimeSpan();
        AnsiConsole.Prompt(
            new TextPrompt<string>("Enter [green]Duration[/] (for example, 10:50):")
                .Validate(x => 
                    TimeSpan.TryParse(x, out time)
                        ? ValidationResult.Success()
                        : ValidationResult.Error("Input is not correct")));

        _videoMaterial.Duration = time;
        
        var qualtity = AnsiConsole.Prompt(
            new TextPrompt<string>($"Enter [green]Quality[/] (previous: [yellow]{_videoMaterial.Quality}[/]):")
                .AllowEmpty());
        
        if (!qualtity.IsNullOrEmpty())
        {
            _videoMaterial.Quality = qualtity;
        }
        
        _videoMaterial.UpdatedOn = DateTime.Now;
        _videoMaterial.UpdatedByUserId = UserSession.Instance.CurrentUser.Id;
        materialService.Update(_videoMaterial);
        
        AnsiConsole.Write(new Markup($"[green]Material[/] updated\n"));
        
        WaitForUserInput();
        Back(2);
    }
}