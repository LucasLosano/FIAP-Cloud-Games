﻿namespace Domain.Entity
{
    public class Promocao : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int ValorDoDescontoPorcetagem { get; set; }

        public ICollection<Jogo> Jogos { get; set; }
    }
}
