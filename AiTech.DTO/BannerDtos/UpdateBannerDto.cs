namespace AiTech.DTO.BannerDtos
{
    public record UpdateBannerDto(int Id, string Title, string Description, string? Image, bool IsActive);
}
