using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    public Filme(string titulo, string genero, int duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
    }

    [Required(ErrorMessage ="O titulo do filme é obrigatória")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    public int Duracao { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine("Titulo: ",this.Titulo);
        Console.WriteLine("Genero: ",this.Genero);
        Console.WriteLine("Duracao: ",this.Duracao);
    }
}
