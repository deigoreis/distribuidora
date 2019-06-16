using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distribuidora
{
    class venda
    {
        private List<cerveja> lc;
        private int codv;
        private tdata datavenda;

        public int Codv { get => codv; set => codv = value; }

        public venda()
        {
            datavenda = new tdata();
            lc = new List<cerveja>();
        }

        public void addprod(cerveja c)
        {
            lc.Add(c);
        }

        public string setdatavenda(int d, int m, int a)
        {
            string aux = "";
            if (datavenda.gravar(d, m, a))
                aux = "data valida";
            else
                aux = "data invalida";

            return aux;
        }

        public string getdatavenda()
        {

            return datavenda.mostra();
        }

        public string mostra()
        {
            int i = 0;
            string s = " ";
            s += "Codigo: " + codv + " Data da venda: " + getdatavenda() + " Produtos: ";
            foreach (cerveja item in lc)
            {
                s += i + 1 + "-)" + item + " ";
                if (item != null)
                {
                    s += ", ";
                }
            }
            return s;
        }
    }
}
