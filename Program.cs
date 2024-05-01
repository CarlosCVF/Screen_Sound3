using System.Text.Json;
using Screen_Sounds3.Modelos;
using Screen_Sounds3.Filter;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;
        // LinqFilter.FilterAllGenres(musicas);
        //LinqOrder.OrderByName(musicas);
        LinqFilter.FilterArtistsByMusicalGenre(musicas,"pop");
    }
    catch(Exception ex)
    {
        System.Console.WriteLine($"Erro: {ex.Message}");
    }
}