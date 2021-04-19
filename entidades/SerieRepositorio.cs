using System.Collections.Generic;

namespace series
{
    public class SerieRepositorio : IRepositorio<Serie>
    
    {
        private List<Serie> listaRepositorio = new List<Serie>();
        public void deleteById(int Id)
        {
            //normalmente usarfiamos o RemoveAt caso estivessemos utilizando banco de dados
            //como estamos salvando em memoria se usarmos esse RemoveAt os indices do vetor
            //(ja que list pode ser acessado dessa forma) são reclassificado então para contornar
            //o problema vamos criar um campo na classe Serie para diermos se item foi excluido
            //e sempre que criarmos um objeto da classe Serie esse campo excuido será false
           // listaRepositorio.RemoveAt(Id);
           listaRepositorio[Id].Exclui();
        }

        public Serie getById(int Id)
        {
            return listaRepositorio[Id];
        }

        public void insertById(Serie entity)
        {
            listaRepositorio.Add(entity);
        }

        public List<Serie> lista()
        {
            return listaRepositorio;
        }

        public int nextId()
        {
            return listaRepositorio.Count;
        }

        public void update(int Id, Serie entity)
        {
            listaRepositorio[Id] = entity;
        }
    }
}