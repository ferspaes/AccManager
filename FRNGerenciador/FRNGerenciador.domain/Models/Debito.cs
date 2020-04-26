﻿using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Debito
    {
        public int Id { get; set; }
        public string MesAno { get; set; }
        public string ValePagamento { get; set; }
        public List<Conta> Contas { get; set; }
        public decimal Valor { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
