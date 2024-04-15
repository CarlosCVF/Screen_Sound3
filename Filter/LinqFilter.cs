using Screen_Sounds3.Modelos;

namespace Screen_Sounds3.Filter;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var AllGenres = musics.Select(genre => genre.Genero).Distinct().ToList();
        foreach (var genre in AllGenres)
        {
            System.Console.WriteLine($"--{genre}");
        }
    }
}