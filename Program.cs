using System;

namespace series
{
    class Program
    {

        private static SerieRepositorio repositorio = new SerieRepositorio();
        private static string ObterUsuario(){
            Console.WriteLine();
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Criar nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
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
                   // Transferir();
                        break;
                    case "4":
                   // Sacar();
                        break;
                    case "5":
                 //   Depositar();
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
            var lista = repositorio.lista();
            if(lista.Count>0){
                foreach( var serie in lista){
                    Console.WriteLine(serie);
                }
            }
        }
        static void CriarSerie(){
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
            Genero tmp =(Genero)Enum.Parse(typeof(Genero),Enum.GetName(typeof(Genero), gen)); 
            var lista = repositorio.lista();
            lista.Add(new Serie(id,tmp,"fghj","rtyu",1));
            

        }
        

        static void Main(string[] args)
        {
            Serie serie = new Serie(1,Genero.Aventura,"Querida encolhi as crianças","Um cinetista maluco acabou encolhendo seus filhso sem querer",1985);
           
            Console.WriteLine(serie);
            Escolher();
            
        }
    }
}
