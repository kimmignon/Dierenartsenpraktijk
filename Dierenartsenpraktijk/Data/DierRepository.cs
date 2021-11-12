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
                "VALUES (@Naam, @Soort, @Ras, @Kleur, @Geboortedatum, @Gezondheidsstatus, @BaasjeId); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Naam", dier.Naam);
            command.Parameters.AddWithValue("@Soort", dier.Soort);
            command.Parameters.AddWithValue("@Ras", dier.Ras);
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
                "[Kleur] = @Kleur, [Geboortedatum] = @Geboortedatum, [Gezondheidsstatus] = @Gezondheidsstatus, [BaasjeId] = @BaasjeId  WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", dier.Id);
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
            command.CommandText = "DELETE FROM [Afspraken] WHERE DierId = @Id; DELETE FROM [Dieren] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", dier.Id);
            command.ExecuteNonQuery();
        }


        //Functie voor alle Dieren op te halen en in lijst te steken
        public override List<Dier> GeefAlle()
        {
            List<Dier> resultSet = new List<Dier>();
            KlantRepository klantRepository = new KlantRepository();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId FROM [Dieren]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string naam = (string)reader.GetString(1);
                string soort = (string)reader.GetString(2);
                string? ras = (string)reader.GetString(3);
                string kleur = (string)reader.GetString(4);
                DateTime geboortedatum = (DateTime)reader.GetDateTime(5);
                string? gezondheidsstatus = (string)reader.GetString(6);
                int baasjeId = (int)reader.GetInt32(7);
                Klant baasje = klantRepository.GeefOpId(baasjeId);

                Dier dier = new Dier(naam, soort, kleur, geboortedatum, baasje);
                dier.Id = id;
                dier.Ras = ras;
                dier.Gezondheidsstatus = gezondheidsstatus;
                resultSet.Add(dier);
            }
            reader.Close();
            return resultSet;
        }

        //Functie voor alle Dieren op naam op te halen (functie geeft lijst met dieren die letters bevatten)
        public override List<Dier> GeefOpNaam(string naamIngave)
        {
            List<Dier> resultSet = new List<Dier>();
            KlantRepository klantRepository = new KlantRepository();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId FROM [Dieren]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                string naam = (string)reader.GetString(1);
                if (naam.ToLower().Contains(naamIngave.ToLower()))
                {
                    int id = reader.GetInt32(0);
                    string soort = (string)reader.GetString(2);
                    string? ras = (string)reader.GetString(3);
                    string kleur = (string)reader.GetString(4);
                    DateTime geboortedatum = (DateTime)reader.GetDateTime(5);
                    string? gezondheidsstatus = (string)reader.GetString(6);
                    int baasjeId = (int)reader.GetInt32(7);
                    Klant baasje = klantRepository.GeefOpId(baasjeId);

                    Dier dier = new Dier(naam, soort, kleur, geboortedatum, baasje);
                    dier.Id = id;
                    dier.Ras = ras;
                    dier.Gezondheidsstatus = gezondheidsstatus;
                    resultSet.Add(dier);
                }
                
            }
            reader.Close();
            return resultSet;
        }

        //Functie om 1 dier op Id te selecteren
        public override Dier? GeefOpId(int idIngave)
        {
            KlantRepository klantRepository = new KlantRepository();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId FROM [Dieren]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                if (id == idIngave)
                {
                    string naam = (string)reader.GetString(1);
                    string soort = (string)reader.GetString(2);
                    string? ras = (string)reader.GetString(3);
                    string kleur = (string)reader.GetString(4);
                    DateTime geboortedatum = (DateTime)reader.GetDateTime(5);
                    string? gezondheidsstatus = (string)reader.GetString(6);
                    int baasjeId = (int)reader.GetInt32(7);
                    Klant baasje = klantRepository.GeefOpId(baasjeId);

                    Dier dier = new Dier(naam, soort, kleur, geboortedatum, baasje);
                    dier.Id = id;
                    dier.Ras = ras;
                    dier.Gezondheidsstatus = gezondheidsstatus;
                    reader.Close();
                    return dier;
                }

            }
            reader.Close();
            return null;
        }

    }
}
