namespace CoreMvcPortfolioProject.DAL.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string? TestimonialName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? TestimonialImageUrl { get; set; }
    }
}
