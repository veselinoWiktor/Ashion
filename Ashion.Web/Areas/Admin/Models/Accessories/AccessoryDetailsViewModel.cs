namespace Ashion.Web.Areas.Admin.Models.Accessories
{
    public class AccessoryDetailsViewModel
    {
        public int Id { get; init; }

        public string Name { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
