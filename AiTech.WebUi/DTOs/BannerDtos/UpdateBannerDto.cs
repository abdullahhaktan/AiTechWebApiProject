namespace AiTech.WebUi.DTOs.BannerDtos
{
    public class UpdateBannerDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
