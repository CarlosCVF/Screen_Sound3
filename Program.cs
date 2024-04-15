﻿using System.Text.Json;
using Screen_Sounds3.Modelos;
using Screen_Sounds3.Filter;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;
        LinqFilter.FilterAllGenres(musicas);
    }
    catch(Exception ex)
    {
        System.Console.WriteLine($"Erro: {ex.Message}");
    }
}