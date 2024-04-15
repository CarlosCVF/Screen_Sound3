using System.Text.Json.Serialization;

namespace Screen_Sounds3.Modelos;

internal class Music
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Nome do Artista: {Artista}");
        System.Console.WriteLine($"Nome da musica: {Nome}");
        System.Console.WriteLine($"Duração: {Duracao / 1000}s");
        System.Console.WriteLine($"Gênero da música: {Genero}");
    }
}