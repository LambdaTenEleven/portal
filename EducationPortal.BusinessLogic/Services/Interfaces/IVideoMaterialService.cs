﻿using EducationPortal.BusinessLogic.DTO;
using FluentResults;

namespace EducationPortal.BusinessLogic.Services.Interfaces;

public interface IVideoMaterialService
{
    Task<Result<VideoMaterialDto>> GetVideoByIdAsync(Guid id);

    Task<Result<IEnumerable<VideoMaterialDto>>> GetVideosPageAsync(int page, int pageSize);

    Task<Result<int>> GetVideosCountAsync();

    Task<Result<Guid>> AddVideoAsync(VideoMaterialDto dto, Guid createdById);

    Task<Result> UpdateVideoAsync(VideoMaterialDto dto, Guid updatedById);

    Task<Result> DeleteVideoByIdAsync(Guid id);
}