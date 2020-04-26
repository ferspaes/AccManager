﻿using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public List<Saldo> Saldos { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}