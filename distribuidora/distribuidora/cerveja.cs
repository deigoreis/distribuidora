using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distribuidora
{
	class cerveja:produto
	{
		private string nome;
		private double preco;

		public cerveja(string m) : base(m)
		{ }


		public string Nome { get => nome; set => nome = value; }
		public double Preco { get => preco; set => preco = value; }

		public override string mostra()
		{
			return "Nome: " + Nome + " ,Preco: " + Preco.ToString("R$0.00") + " ," + base.mostra();
		}
	}
}
