using System;
namespace CRUDConsole
{
    class Program
    {
        static Equipamento[] equipamentoArray = new Equipamento[0];
        static Chamada[] chamadaArray = new Chamada[0];
        static void Main(string[] args) { Menu(); }
        private static void Menu()
        {
            while (true)
            {
                string menu = "";

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Digite 1 para cadastrar um novo equipamento");
                Console.WriteLine("Digite 2 para visualizar os equipamentos");
                Console.WriteLine("Digite 3 para editar algum equipamentos");
                Console.WriteLine("Digite 4 para excluir algum equipamento");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Digite 5 para cadastrar uma nova chamada");
                Console.WriteLine("Digite 6 para visualizar as chamadas");
                Console.WriteLine("Digite 7 para editar uma chamada");
                Console.WriteLine("Digite 8 para excluir uma chamada");
                Console.WriteLine("-------------------------------------------------");

                menu = Console.ReadLine();

                switch (menu)
                {

                    case "1":
                        Array.Resize(ref equipamentoArray, equipamentoArray.Length + 1);
                        equipamentoArray[equipamentoArray.Length - 1] = CadastraEquipamento();
                        break;

                    case "2":
                        MostraEquipamentos();
                        break;

                    case "3":
                        EditarEquipamento();
                        break;

                    case "4":
                        ExcluirEquipamento();
                        break;

                    case "5":
                        Array.Resize(ref chamadaArray, chamadaArray.Length + 1);
                        chamadaArray[chamadaArray.Length - 1] = CadastraChamada();
                        break;

                    case "6":
                        MostraChamadas();
                        break;

                    case "7":
                        EditarChamada();
                        break;

                    case "8":
                        ExcluirChamada();
                        break;
                }
            }
        }
        private static void EditarEquipamento()
        {

            Console.Clear();
            Console.WriteLine("Digite aqui o número de série do equipamento que deseja editar : ");
            int nSerieEditar = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < equipamentoArray.Length; i++)
            {
                if (equipamentoArray[i].NSerie == nSerieEditar)
                {
                    equipamentoArray[i] = CadastraEquipamento();
                }
            }
        }
        private static void ExcluirEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Digite aqui o número de série do equipamento que deseja excluir : ");
            int nSerieExcluir = Convert.ToInt16(Console.ReadLine());
            int indice = 0;

            for (int i = 0; i < equipamentoArray.Length; i++)
            {
                if (equipamentoArray[i].NSerie == nSerieExcluir)
                {

                    indice = i;
                    break;
                }
            }

            if (indice < equipamentoArray.Length && indice >= 0)
            {
                for (int i = indice + 1; i < equipamentoArray.Length; i++)
                {
                    equipamentoArray[i - 1] = equipamentoArray[i];

                }
                Array.Resize(ref equipamentoArray, equipamentoArray.Length - 1);
            }
        }
        private static void MostraEquipamentos()
        {
            Console.Clear();

            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados!\n");
            }
            else
            {
                for (int i = 0; i < equipamentoArray.Length; i++)
                {
                    equipamentoArray[i].mostraDados();
                    Console.WriteLine("\n");
                }

            }


        }
        private static Equipamento CadastraEquipamento()
        {
            string nomeConstrutor = "", fabricanteConstrutor = "";
            int nSerieConstrutor;
            double precoConstrutor;
            DateTime dataConstrutor;
            Equipamento equipamento;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do equipamento : \n");
                nomeConstrutor = Console.ReadLine();
                if (nomeConstrutor.Length > 5) { break; }
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o preço de aquisição : \n");
                if (double.TryParse(Console.ReadLine(), out precoConstrutor)) { break; }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o número de série : \n");
                if (int.TryParse(Console.ReadLine(), out nSerieConstrutor)) { break; }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite a data de fabricação (dd/MM/yyyy) : \n");
                if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor)) { break; }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do fabricante : \n");
                fabricanteConstrutor = Console.ReadLine();
                if (fabricanteConstrutor.Length > 1) { break; }
            }

            Console.Clear();
            equipamento = new Equipamento(nomeConstrutor, fabricanteConstrutor, precoConstrutor, nSerieConstrutor, dataConstrutor);
            return equipamento;
        }
        private static Chamada CadastraChamada()
        {
            string tituloConstrutor = "", descConstrutor = "", equipamentoConstrutor = "";
            DateTime dataConstrutor;
            Chamada chamada;

            if (equipamentoArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há equipamentos cadastrados!!!\n");
            }
            else
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome da chamada : \n");
                    tituloConstrutor = Console.ReadLine();
                    if (tituloConstrutor.Length < 1) { break; }
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a descrição da chamada : \n");
                    descConstrutor = Console.ReadLine();
                    if (descConstrutor.Length < 1) { break; }
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o equipamento da chamada : \n");
                    equipamentoConstrutor = Console.ReadLine();
                    if (equipamentoConstrutor.Length < 1) { break; }
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a data de abertura da chamada (dd/MM/yyyy) : \n");
                    if (DateTime.TryParse(Console.ReadLine(), out dataConstrutor)) { break; }
                }

                Console.Clear();
                chamada = new Chamada(tituloConstrutor, descConstrutor, equipamentoConstrutor, dataConstrutor);
                return chamada;
            }
            return null;
        }
        private static void MostraChamadas()
        {
            Console.Clear();

            if (chamadaArray.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há chamadas cadastrados!\n");
            }
            else
            {

                for (int i = 0; i < chamadaArray.Length; i++)
                {
                    chamadaArray[i].mostraDados();
                    Console.WriteLine("\n");
                }

            }

        }
        private static void EditarChamada()
        {
            if (CadastraChamada() == null)
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Digite aqui o número de série do equipamento que deseja editar : ");
                string titulo = Console.ReadLine();

                for (int i = 0; i < chamadaArray.Length; i++)
                {
                    if (chamadaArray[i].Titulo.Equals(titulo))
                    {
                        chamadaArray[i] = CadastraChamada();
                    }
                }
            }
        }
        private static void ExcluirChamada()
        {
            Console.Clear();
            Console.WriteLine("Digite aqui o título da chamada que deseja excluir : ");
            string titulo = Console.ReadLine();
            int indice = 0;

            for (int i = 0; i < chamadaArray.Length; i++)
            {
                if (chamadaArray[i].Titulo.Equals(titulo))
                {
                    indice = i;
                    break;
                }
            }

            if (indice < chamadaArray.Length && indice >= 0)
            {
                for (int i = indice + 1; i < chamadaArray.Length; i++)
                {
                    chamadaArray[i - 1] = chamadaArray[i];

                }
                Console.WriteLine("sexo");
                Array.Resize(ref chamadaArray, chamadaArray.Length - 1);
            }
        }
    }
}
