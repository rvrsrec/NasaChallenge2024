using System.Text.Json.Serialization;

namespace NasaChallenge2024.Definitions.Models;

public class Exoplanet
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("discovered_year")]
    public int DiscoveredYear { get; set; }

    [JsonPropertyName("planet_type")]
    public string PlanetType { get; set; }

    [JsonPropertyName("brief_description")]
    public string BriefDescription { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("orbital_radius")]
    public double? OrbitalRadius { get; set; }

    [JsonPropertyName("orbital_period")]
    public double? OrbitalPeriod { get; set; }

    [JsonPropertyName("orbital_eccentricity")]
    public double? OrbitalEccentricity { get; set; }

    [JsonPropertyName("earth_radius")]
    public double? EarthRadius { get; set; }

    [JsonPropertyName("jupiter_radius")]
    public double? JupiterRadius { get; set; }

    [JsonPropertyName("earth_mass")]
    public double? EarthMass { get; set; }

    [JsonPropertyName("jupiter_mass")]
    public double? JupiterMass { get; set; }

    [JsonPropertyName("earth_distance")]
    public int? EarthDistance { get; set; }

    [JsonPropertyName("host_star_ids")]
    public IEnumerable<int> HostStarIds { get; set; }

    [JsonPropertyName("detection_method")]
    public string DetectionMethod { get; set; }

    [JsonPropertyName("telescope_ids")]
    public IEnumerable<int> TelescopeIds { get; set; }

    [JsonPropertyName("texture_path")]
    public string TexturePath { get; set; }

    [JsonPropertyName("observatory_ids")]
    public IEnumerable<int> ObservatoryIds { get; set; }
}
