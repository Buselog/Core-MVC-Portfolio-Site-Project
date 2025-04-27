namespace CoreMvcPortfolioProject.DAL.Entities
{
    public class Projects
    {
        public int ProjectsId { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? ProjectDescription { get; set; }
        public string?  ProjectUrl { get; set; }
        public string? ProjectImageUrl { get; set; }

    }
}
