using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class IKCV : Imposto
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }
        public bool DeveUserMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);           
        }
        public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
    }

