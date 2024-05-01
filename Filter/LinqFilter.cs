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

    public static void FilterArtistsByMusicalGenre(List<Music> musics, string genero)
    {
        var ArtistsByMusicalGenre = musics.Where(music => music.Genero!.Contains(genero)).Select(music => music.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibindo Artistas do estilo Musical {genero}");
        foreach (var artist in ArtistsByMusicalGenre)
        {
            System.Console.WriteLine($"- {artist}");
        }
    }
}