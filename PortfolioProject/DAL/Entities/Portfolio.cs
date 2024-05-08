using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PortfolioProject.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string subTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public String Description { get; set; }

    }
}
