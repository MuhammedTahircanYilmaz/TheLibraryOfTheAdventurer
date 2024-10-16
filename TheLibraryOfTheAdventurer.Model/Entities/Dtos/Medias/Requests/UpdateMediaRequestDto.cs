
using TheLibraryOfTheAdventurer.Model.Entities.Enums;

namespace TheLibraryOfTheAdventurer.Model.Entities.Medias.Requests;

public record UpdateMediaRequestDto(
    Guid id,
    string Title,
    string Description,
    string? Author,
    string? Studio,
    MediaType Type,
    Status Status,
    int? Rating
    );