using TheLibraryOfTheAdventurer.Model.Entities.Enums;

namespace TheLibraryOfTheAdventurer.Model.Entities.Medias.Response;

public record MediaResponseDto(
    string Title,
    string Description,
    string? Author,
    string? Studio,
    MediaType Type,
    Status Status,
    int? Rating
    );