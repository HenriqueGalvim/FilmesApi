﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
	[Key]
	[Required]
	public int Id { get; set; }

	[Required(ErrorMessage = "O titulo do filme é obrigatório")]
	[MaxLength(50, ErrorMessage = "O título do filme não pode exceder 50 caracteres")]
	public string Titulo { get; set; }

	[Required(ErrorMessage = "O gênero do filme é obrigatório")]
	public string Genero { get; set; }

	[Required(ErrorMessage = "O campo de duração é obrigatório")]
	[Range(1, 360, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
	public int Duracao { get; set; }

	public virtual ICollection<Sessao> Sessoes { get; set; }
}
