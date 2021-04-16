using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsole
{
    class Chamada
    {

        private string titulo = "", desc = "", equipamento = "";
        DateTime dataAbertura;

        public Chamada(string titulo, string desc, string equipamento, DateTime dataAbertura)
        {
            this.Titulo = titulo;
            this.Desc = desc;
            this.Equipamento = equipamento;
            this.DataAbertura = dataAbertura;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Equipamento { get => equipamento; set => equipamento = value; }
        public DateTime DataAbertura { get => dataAbertura; set => dataAbertura = value; }

        public void mostraDados()
        {
            Console.WriteLine("\nTítulo do chamado : " + Titulo + "\nEquipamento : " + Equipamento + "\nData de abertura : " + DataAbertura.ToString("dd/MM/yyyy") + "\nDias em aberto : " + DateTime.Now.Subtract(DataAbertura).TotalDays);    
        }
    }
}
