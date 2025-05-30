﻿namespace CoreMvcPortfolioProject.DAL.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
    }
}
