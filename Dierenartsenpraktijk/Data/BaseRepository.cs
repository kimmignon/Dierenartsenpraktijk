using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dierenartsenpraktijk.Model;
using System.Data.SqlClient;

namespace Dierenartsenpraktijk.Data
{
    //Baserepository om de code voor de aanpassingen van de databasetabellen van de verschillende modelklassen te delen
    internal abstract class BaseRepository<TEntity> : IDisposable where TEntity : Entity  //Werken mer Generics
    {
        protected readonly SqlConnection _connection = new SqlConnection("Data Source=(local);Initial Catalog=Dierenartsenpraktijk;Integrated Security=True");

        //Vanaf opbject wordt aangemaakt wordt connectie met databank geopend
        public BaseRepository()
        {
            _connection.Open();
        }

        public TEntity Opslaan(TEntity entity)
        {
            if (entity.Id is null)
            {
                entity = Insert(entity);
            }
            else
            {
                Update(entity);
            }

            return entity;
        }

        protected abstract TEntity Insert(TEntity entiteit);
        protected abstract void Update(TEntity entiteit);

        public abstract void Delete(TEntity entiteit);


        public void Dispose()
        {
            _connection.Close();
        }
    }
}
