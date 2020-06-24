using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            posicao = null;
            this.cor = cor;
            this.tab = tab;
            qteMovimentos = 0;
        }
    }
}
