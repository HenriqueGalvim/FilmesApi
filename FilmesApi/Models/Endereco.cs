﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Endereco
{
	[Key]
	[Required]
	public int Id { get; set; }

	[Required]
	public string Logradouro { get; set; }

	[Required]
	public string Numero { get; set; }

	public int CinemaId { get; set; }

	public virtual Cinema Cinema { get; set; }
}
