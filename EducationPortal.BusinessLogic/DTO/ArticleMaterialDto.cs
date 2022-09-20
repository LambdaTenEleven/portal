﻿using EducationPortal.BusinessLogic.DTO.Abstract;

namespace EducationPortal.BusinessLogic.DTO;

public class ArticleMaterialDto : AuditedDto
{
    public string Name { get; set; }

    public DateTime PublishDate { get; set; }

    public string Source { get; set; }
}