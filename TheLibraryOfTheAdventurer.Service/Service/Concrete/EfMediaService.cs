using AutoMapper;
using Core.Entities.ReturnModels;
using Core.Repository;
using Core.Service.Concrete;
using Core.Service.Rules;
using TheLibraryOfTheAdventurer.Model.Dtos.Medias.Requests;
using TheLibraryOfTheAdventurer.Model.Dtos.Medias.Response;
using TheLibraryOfTheAdventurer.Model.Entities;
using TheLibraryOfTheAdventurer.Model.Entities.Dtos.Medias.Requests;
using TheLibraryOfTheAdventurer.Model.Enums;
using TheLibraryOfTheAdventurer.Repository.Repositories.Abstract;
using TheLibraryOfTheAdventurer.Service.Service.Abstract;

namespace TheLibraryOfTheAdventurer.Service.Service.Concrete;

public class EfMediaService : IMediaService
{
    IMapper _mapper;    
    IMediaRepository _mediaRepository;
    public EfMediaService(IMapper mapper, IMediaRepository repository) : base(mapper, repository)
    {
        _mapper = mapper;
        _mediaRepository = repository;

    }

    public override ReturnModel<MediaResponseDto> Update(UpdateMediaRequestDto dto)
    {
        try
        {
            Media media = _mediaRepository.GetById(dto.Id);
            media.Studio = dto.Studio;
            media.Author = dto.Author;
            media.Title = dto.Title;
            media.Description = dto.Description;
            media.Rating = dto.Rating;
            media.Type = dto.Type;
            media.Status = dto.Status;
            Media updated = _mediaRepository.Update(media);
            var data = _mapper.Map<MediaResponseDto>(updated);
            return ReturnModel<MediaResponseDto>.ReturnModelOfSuccess(data, "The Item has been updated", 200);
        }
        catch (Exception exception)
        {
            return ExceptionHandler<MediaResponseDto>.HandleExceptions(exception);
        }
    }

    public ReturnModel<List<MediaResponseDto>> GetAllByStatus(Status status)
    {
        throw new NotImplementedException();
    }
}
