namespace series
{
    public class Serie: BaseEntity
    {

        private int ano{get;set;}
        private string descricao{get;set;}
        private string titulo{get;set;}

        private Genero genero;


          public Serie(int Id,Genero genero,string titulo, string descricao,int ano){
              this.genero = genero;
              this.titulo = titulo;
              this.descricao = descricao;
              this.ano = ano;
              this.Id = Id;
            }

        public override string ToString()
        {
            return "Titulo: "+this.titulo+" descricao: "+this.descricao+" Gênero: "+this.genero+" ano de lançamento: "+this.ano;
        }

        public int getId(){
            return this.Id;
        }

        public void setId(int Id){
            this.Id = Id;
        }

        public string getTitulo(){
            return this.titulo;
        }

        
    }

  
}