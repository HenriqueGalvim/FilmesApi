﻿using FilmesApi.Data.Dtos.Sessao;

namespace FilmesApi.Data.Dtos.Filme;

public class ReadFilmeDto
{
	public int Id { get; set; }
	public string Titulo { get; set; }
	public string Genero { get; set; }
	public int Duracao { get; set; }

	public DateTime HoraConsulta { get; set; } = DateTime.Now;
	public ICollection<ReadSessaoDto> Sessoes { get; set; }
}
