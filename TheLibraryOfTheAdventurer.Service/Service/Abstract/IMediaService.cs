using Core.Entities.ReturnModels;
using TheLibraryOfTheAdventurer.Model.Entities;
using TheLibraryOfTheAdventurer.Model.Entities.Medias.Requests;
using TheLibraryOfTheAdventurer.Model.Entities.Medias.Response;

namespace TheLibraryOfTheAdventurer.Service.Service.Abstract;

public interface IMediaService
{
    ReturnModel<MediaResponseDto> Add(AddMediaRequestDto dto);
    ReturnModel<MediaResponseDto> Update(UpdateMediaRequestDto dto);
    ReturnModel<MediaResponseDto> Delete(Media media);
    ReturnModel<IQueryable<MediaResponseDto>> GetAll();
    ReturnModel<MediaResponseDto> GetById(Guid id);
}
