namespace CvProject.Models.Entities
{
    public partial class SocialMedia
    {
        public int Id { get; set; }
        public string? SocialMediaName { get; set; }
        public string? Link { get; set; }
        public string? Icon { get; set; }
        public bool? State { get; set; }
    }
}
