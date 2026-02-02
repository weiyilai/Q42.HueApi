using System.Text.Json.Serialization;

namespace HueApi.Models
{
  /// <summary>
  /// Feature describing the geometry a light service.
  /// </summary>
  public class Geometry
  {
    /// <summary>
    /// Array of PixelPosition – maxItems: 5
    /// </summary>
    [JsonPropertyName("pixel_positions")]
    public List<PixelPosition>? PixelPositions { get; set; }
  }

  public class PixelPosition
  {
    /// <summary>
    /// Index of the pixel to which the position belongs, use 0 for non-gradient lights
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }

    /// <summary>
    /// Position of the pixel in 3D space. Range of coordinates is -100 to 100 meters.
    /// </summary>
    [JsonPropertyName("position")]
    public HuePosition? Position { get; set; }
  }
}
