﻿namespace EducationPortal.BusinessLogic.DTO;

public class SkillProgressDto
{
    public Guid SkillId { get; set; }

    public string Name { get; set; }

    public int Level { get; set; }

    public override string ToString()
    {
        return Name + " " + Level + " lvl";
    }
}