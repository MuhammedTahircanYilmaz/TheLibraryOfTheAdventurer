using AutoMapper;
using Core.Entities.ReturnModels;
using TheLibraryOfTheAdventurer.Model.Entities;
using TheLibraryOfTheAdventurer.Model.Entities.Medias.Requests;
using TheLibraryOfTheAdventurer.Model.Entities.Medias.Response;
using TheLibraryOfTheAdventurer.Repository.Repositories.Abstract;
using TheLibraryOfTheAdventurer.Service.Service.Abstract;

namespace TheLibraryOfTheAdventurer.Service.Service.Concrete;

public class MediaService : IMediaService
{
    public readonly IMediaRepository _mediaRepository;
    public readonly IMapper _mapper;
    public MediaService(IMediaRepository mediaRepository, IMapper mapper)
    {
        _mediaRepository = mediaRepository;
        _mapper = mapper;
    }
    public ReturnModel<MediaResponseDto> Add(AddMediaRequestDto dto)
    {
        Media createdMedia = _mapper.Map<Media>(dto);
        createdMedia.Id = Guid.NewGuid();
        Media media = _mediaRepository.Add(createdMedia);
        MediaResponseDto response = _mapper.Map<MediaResponseDto>(media);
        return new ReturnModel<MediaResponseDto>(response, "Media Added", true, 200);
    }

    public ReturnModel<MediaResponseDto> Update(UpdateMediaRequestDto dto)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<MediaResponseDto> Delete(Media media)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<IQueryable<MediaResponseDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<MediaResponseDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
