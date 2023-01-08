using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Barbarian = 1,
        Warlock = 2,
        Shaman = 3,
    }
}