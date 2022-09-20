﻿using EducationPortal.BusinessLogic.DTO;
using EducationPortal.DataAccess.DomainModels.Materials;
using FluentValidation;

namespace EducationPortal.BusinessLogic.Validators.FluentValidation;

public class VideoMaterialValidator : AbstractValidator<VideoMaterial>
{
    public VideoMaterialValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
    }
}