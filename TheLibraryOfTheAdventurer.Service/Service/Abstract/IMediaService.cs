using Core.Entities.ReturnModels;
using TheLibraryOfTheAdventurer.Model.Dtos.Medias.Response;
using TheLibraryOfTheAdventurer.Model.Entities;
using TheLibraryOfTheAdventurer.Model.Entities.Medias.Requests;
using TheLibraryOfTheAdventurer.Model.Enums;

namespace TheLibraryOfTheAdventurer.Service.Service.Abstract;

public interface IMediaService 
{
    ReturnModel<List<MediaResponseDto>> GetAllByStatus(Status status);
}
