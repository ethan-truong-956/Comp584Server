namespace Comp584Server.Data.DTOs
{
    public class CountryPopulation
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public required string Iso2 { get; set; }

        public required string Iso3 { get; set; }

        public int Population { get; set; }
    }
}
