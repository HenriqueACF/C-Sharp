using System;
using System.Collections.Generic;
using FilmesAPI.Models;

namespace FilmesApi.Data.Dtos.Gerente
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Cinemas { get; set; }
    }
}