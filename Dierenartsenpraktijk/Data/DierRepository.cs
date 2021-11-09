using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dierenartsenpraktijk.Model;

namespace Dierenartsenpraktijk.Data
{
    internal class DierRepository:BaseRepository<Dier>
    {
        //Protected methode om nieuwe dier aan te maken (voor save methode)
        protected override Dier Insert(Dier dier)
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "INSERT INTO [Dieren] (Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId) " +
                "VALUES (@Naam, @Soort, @Ras, @Kleur, @Geboortedatum, @Gezondheidsstatus, (select Id from Klanten where Id = @BaasjeId)); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Naam", dier.Naam);
            command.Parameters.AddWithValue("@Soort", dier.Soort);
            command.Parameters.AddWithValue("@Kleur", dier.Kleur);
            command.Parameters.AddWithValue("@Geboortedatum", dier.Geboortedatum);
            command.Parameters.AddWithValue("@Gezondheidsstatus", dier.Gezondheidsstatus);
            command.Parameters.AddWithValue("@BaasjeId", dier.Baasje.Id);

            using var reader = command.ExecuteReader();
            reader.Read();
            dier.Id = (int)reader.GetDecimal(0);
            return dier;
        }

        //Protected methode om Dier te updaten (voor save methode)
        protected override void Update(Dier dier)
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "UPDATE [Dieren] SET [Naam] = @Naam, [Soort] = @Soort, [Ras] = @Ras," +
                "[Kleur] = @Kleur, [Geboortedatum] = @Geboortedatum, [Gezondheidsstatus] = @Gezondheidsstatus, [BaasjeId] = @BaasjeId";
            command.Parameters.AddWithValue("@Naam", dier.Naam);
            command.Parameters.AddWithValue("@Soort", dier.Soort);
            command.Parameters.AddWithValue("@Kleur", dier.Kleur);
            command.Parameters.AddWithValue("@Geboortedatum", dier.Geboortedatum);
            command.Parameters.AddWithValue("@Gezondheidsstatus", dier.Gezondheidsstatus);
            command.Parameters.AddWithValue("@BaasjeId", dier.Baasje.Id);

            command.ExecuteNonQuery();
        }

        //Delete methode
        public override void Delete(Dier dier)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [Dierenartsen] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("Id", dier.Id);
            command.ExecuteNonQuery();
        }
        //Functie voor alle Dieren op te halen en in lijst te steken
        public override List<Dier> GeefAlle()
        {
            List<Dier> resultSet = new List<Dier>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId FROM Dieren;";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string naam = (string)reader.GetString(1);
                string soort = (string)reader.GetString(2);

                int telefoonnummer = (int)reader.GetInt32(3);
                SpecialisatieType type = mapSpecialisatieType((string)reader.GetString(4));
                Dierenarts dierenarts = new Dierenarts(voornaam, achternaam, telefoonnummer, type);
                dierenarts.Id = id;
                resultSet.Add(dierenarts);
            }
            reader.Close();
            return resultSet;
        }

    }
}
