﻿using EducationPortal.BusinessLogic.DTO.Abstract;

namespace EducationPortal.BusinessLogic.DTO;

public class BookFormatDto : BaseDto
{
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}