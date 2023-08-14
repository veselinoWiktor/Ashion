namespace Ashion.Web.Areas.Admin.Models.Cosmetics
{
    public class CosmeticDetailsViewModel
    {
        public int Id { get; init; }

        public string Name { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
