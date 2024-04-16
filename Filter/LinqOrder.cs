using Screen_Sounds3.Modelos;

namespace Screen_Sounds3.Filter;

internal class LinqOrder
{
    public static void OrderByName(List<Music> musics)
    {
        var ArtistOrdered = musics.OrderBy(musics => musics.Artista).Select(musics => musics.Artista).Distinct().ToList();
        System.Console.WriteLine("Mostrando lista de Artistas (A-Z)");
        foreach (var Artist in ArtistOrdered)
        {
            System.Console.WriteLine($"->{Artist}");
        }
    }
}