using System.Collections.Generic;

namespace series
{
    /*utilizando o Design pattern para desenhar a interface
    //e armazenar os dados*/
    public interface IRepositorio<T>
    {
        List<T> lista();
        T getById(int Id);
        void insertById(T entity);
        void deleteById(int Id);
        void update(int Id,T entity);
        int nextId();
         
    }
}