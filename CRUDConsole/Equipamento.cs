using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    class Equipamento
    {

        private string nome, fabricante;
        private double precoAquisicao;
        private int nSerie;
        private DateTime dataAquisicao = new DateTime();
        public Equipamento(string nome, string fabricante, double precoAquisicao, int nSerie, DateTime dataAquisicao)
        {
            this.Nome = nome;
            this.Fabricante = fabricante;
            this.PrecoAquisicao = precoAquisicao;
            this.NSerie = nSerie;
            this.DataAquisicao = dataAquisicao;
        }
        public string Nome { get => nome; set => nome = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public double PrecoAquisicao { get => precoAquisicao; set => precoAquisicao = value; }
        public int NSerie { get => nSerie; set => nSerie = value; }
        public DateTime DataAquisicao { get => dataAquisicao; set => dataAquisicao = value; }
        public void mostraDados()
        {
            Console.WriteLine("\nNome : " + Nome + "\nNúmero de série : " + NSerie + "\nPreço : " + PrecoAquisicao + "\nFabricante : " + Fabricante + "\nData de Aquisição : " + DataAquisicao.ToString("dd/MM/yyyy"));
        }

    }
}