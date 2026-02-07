using System.Text.Json.Serialization;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
    // Create additional classes as necessary

}

public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public double? Magnitude { get; set; }
}