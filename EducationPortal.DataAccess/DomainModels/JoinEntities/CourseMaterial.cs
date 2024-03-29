﻿namespace EducationPortal.DataAccess.DomainModels.JoinEntities;

public class CourseMaterial
{
    public Guid CourseId { get; set; }

    public Course Course { get; set; }

    public Guid MaterialId { get; set; }

    public Material Material { get; set; }
}