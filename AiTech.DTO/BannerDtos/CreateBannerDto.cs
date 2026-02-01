namespace AiTech.DTO.BannerDtos
{
    public record CreateBannerDto(int Id, string Title, string Description, string? Image, bool IsActive, DateTime CreatedDate, DateTime UpdatedDate);
}
