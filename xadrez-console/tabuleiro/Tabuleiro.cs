using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linha {  get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linha = linhas;
            this.coluna = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
