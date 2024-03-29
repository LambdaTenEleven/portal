﻿using EducationPortal.BusinessLogic.DTO.Abstract;

namespace EducationPortal.BusinessLogic.DTO;

public class SkillDto : AuditedDto
{
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}