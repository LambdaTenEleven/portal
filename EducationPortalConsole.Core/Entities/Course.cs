﻿namespace EducationPortalConsole.Core.Entities;

public class Course : AuditedEntity
{
    public Course()
    {
        Materials = new HashSet<Material>();
    }

    public string? Description { get; set; }

    public IEnumerable<Material> Materials { get; set; }

    public IEnumerable<Skill> Skills { get; set; }
}