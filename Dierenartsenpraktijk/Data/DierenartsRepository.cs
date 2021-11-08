using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dierenartsenpraktijk.Model;

namespace Dierenartsenpraktijk.Data
{
    internal class DierenartsRepository:BaseRepository<Dierenarts>
    {
        protected override Dierenarts Insert(Dierenarts dierenarts)
        {
            using var command = _connection.CreateCommand();
            
            command.CommandText = "INSERT INTO [Dierenartsen] (Voornaam, Achternaam, Telefoonnummer, Specialisatie) VALUES (@Voornaam, @Achternaam, @Telefoonnummer, @Specialisatie); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Voornaam", dierenarts.Voornaam);
            command.Parameters.AddWithValue("@Achternaam", dierenarts.Achternaam);
            command.Parameters.AddWithValue("@Telefoonnummer", dierenarts.Telefoonnummer);
            command.Parameters.AddWithValue("@Specialisatie", dierenarts.Specialisatie.ToString());
            
            using var reader = command.ExecuteReader();
            reader.Read();
            dierenarts.Id = (int)reader.GetDecimal(0);
            return dierenarts;
        }


        protected override void Update(Dierenarts dierenarts)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Dierenartsen] SET [Voornaam] = @Voornaam, [Achternaam] = @Achternaam, [Telefoonnummer] = @Telefoonnummer, [Specialisatie] = @Specialisatie";
            command.Parameters.AddWithValue("@Voornaam", dierenarts.Voornaam);
            command.Parameters.AddWithValue("@Achternaam", dierenarts.Achternaam);
            command.Parameters.AddWithValue("@Telefoonnummer", dierenarts.Telefoonnummer);
            command.Parameters.AddWithValue("@Specialisatie", dierenarts.Specialisatie.ToString());

            command.ExecuteNonQuery();
        }

        public override void Delete(Dierenarts dierenarts)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [Dierenartsen] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("Id", dierenarts.Id);
            command.ExecuteNonQuery();
        }
    }
}
