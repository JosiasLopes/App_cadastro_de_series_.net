using System;

namespace series
{
    class Program
    {

        private static SerieRepositorio repositorio = new SerieRepositorio();
        private static string ObterUsuario(){
            Console.WriteLine();
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Criar nova Serie");
            Console.WriteLine("3 - Atualizar Serie");
            Console.WriteLine("4 - Excluir Serie");
            Console.WriteLine("x - Sair");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine();
            return Console.ReadLine().ToUpper();
        }
        private static void Escolher(){
           string opcao = "";
            //Console.WriteLine("4 - Sacar"+opcao);
           while(opcao!="x" || opcao!="X"){
               opcao = ObterUsuario();
               switch (opcao)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        CriarSerie();
                        break;
                    case "3":
                    AtualizarSerie();
                        break;
                    case "4":
                   Deletar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                     case "X":
                     Console.WriteLine("Saindo...");
                     Environment.Exit(0);

                        break;
                    default:
                    opcao = "X";
                        break;
                }
           }
        }   

        static void ListarSeries(){
            Console.WriteLine("-----LISTAR SERIE-----");
            var lista = repositorio.lista();
            if(lista.Count>0){
                foreach( var serie in lista){
                    Console.WriteLine(serie);
                }
            }
        }
        static void CriarSerie(){
            Console.WriteLine("-----CRIAR SERIE-----");
            Console.WriteLine("Insira um identificador");
            int id = int.Parse(Console.ReadLine());
            for(int i=1;i<15;i++){
            //Enum.GetValues(typeof(Genero)) 
            var generos =Enum.GetName(typeof(Genero), i);
            Console.WriteLine("Para "+generos+" digite "+i);
            }
            Console.WriteLine("Insira um genero");
            int gen = int.Parse(Console.ReadLine());
            //nesse trecho é pego uma string do enum e convertido para um novo enum
            //para que possa ser colocado no construtor
            Genero tmp =GetEnumFromInteger(gen);
            Console.WriteLine("Insira um titulo");
            string titulo = Console.ReadLine();
             Console.WriteLine("Insira uma descrição");
            string desc = Console.ReadLine();
            Console.WriteLine("Insira o ano de lançamento");
            int an = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ano de lançamento "+an);
            var lista = repositorio.lista();
            lista.Add(new Serie(id,tmp,titulo,desc,an));
        }

        static Genero GetEnumFromInteger(int x){
            Genero tmp = (Genero)Enum.Parse(typeof(Genero),Enum.GetName(typeof(Genero), x));
            return tmp;
        }
        static void AtualizarSerie(){
             Console.WriteLine("-----ATUALIZAR SERIE-----");
            var lista = repositorio.lista();
             Console.WriteLine("Insira um identificador");
             int id = int.Parse(Console.ReadLine());
             Console.WriteLine("Insira um genero");
            int gen = int.Parse(Console.ReadLine());
            Genero tmp =GetEnumFromInteger(gen);
            Console.WriteLine("Insira um titulo");
            string titulo = Console.ReadLine();
            Console.WriteLine("Insira uma descrição");
            string desc = Console.ReadLine();
            Console.WriteLine("Insira o ano de lançamento");
            int an = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ano de lançamento "+an);
             Serie s= new Serie(id,tmp,titulo,desc,an);
           // Serie tx = lista.Find(x => x.Id==id);
           // tx = s;
            int index =lista.FindIndex(x => x.Id==id);
            lista[index] = s;
             Console.WriteLine(lista[index]);
            // repositorio.update(id,s);

        }

        /*
        Nesse caso como os items estão salvos em memoria a ideia
        era apenas mudar o atributo excluido para true
        e quando fosse-mos listar as series seriam exibidas
        somente as que não estivessem excluidas, como é um
        projeto simulado optei por remover o item ja que
        antes do RemoveAT usei o FindIndex e comparei com o
        id assim é garantido que o registro correto seja apagado
        */
        static void Deletar(){
             Console.WriteLine("-----APAGAR SERIE-----");
            var lista = repositorio.lista();
             Console.WriteLine("Insira um identificador");
             int id = int.Parse(Console.ReadLine());
             int index =lista.FindIndex(x => x.Id==id);
             lista[index].Exclui();
             lista.RemoveAt(index);

        }
        

        static void Main(string[] args)
        {
          
           
           
            Escolher();
            
        }
    }
}
