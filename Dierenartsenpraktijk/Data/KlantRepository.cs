using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dierenartsenpraktijk.Model;

namespace Dierenartsenpraktijk.Data
{
    internal class KlantRepository:BaseRepository<Klant>
    {
        //Protected methode om nieuwe Klant aan te maken
        protected override Klant Insert(Klant klant)
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "INSERT INTO [Klanten] (Voornaam, Achternaam, Telefoonnummer, Adres) VALUES (@Voornaam, @Achternaam, @Telefoonnummer, @Adres); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@Voornaam", klant.Voornaam);
            command.Parameters.AddWithValue("@Achternaam", klant.Achternaam);
            command.Parameters.AddWithValue("@Telefoonnummer", klant.Telefoonnummer);
            command.Parameters.AddWithValue("@Adres", klant.Adres);

            using var reader = command.ExecuteReader();
            reader.Read();
            klant.Id = (int)reader.GetDecimal(0);
            return klant;
        }

        //Protected methode om Dierenarts te updaten
        protected override void Update(Klant klant)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Klanten] SET [Voornaam] = @Voornaam, [Achternaam] = @Achternaam, [Telefoonnummer] = @Telefoonnummer, [Adres] = @Adres WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", klant.Id);
            command.Parameters.AddWithValue("@Voornaam", klant.Voornaam);
            command.Parameters.AddWithValue("@Achternaam", klant.Achternaam);
            command.Parameters.AddWithValue("@Telefoonnummer", klant.Telefoonnummer);
            command.Parameters.AddWithValue("@Adres", klant.Adres);

            command.ExecuteNonQuery();
        }

        //Als klant verwijderd wordt, moeten ook alle zijn huisdieren en zijn afspraken mee worden verwijdered uit database
        public override void Delete(Klant klant)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [Dieren] WHERE BaasjeId = @Id; " +
                "DELETE FROM [Afspraken] WHERE KlantId = @Id;" +
                "DELETE FROM [Klanten] WHERE Id = @Id";
            //command.CommandText = "DELETE FROM [Klanten] WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", klant.Id);
            command.ExecuteNonQuery();
        }

        //Functie om alle klanten in een keer op te halen uit database en om deze lijst later te kunnen tonen op het venster
        public override List<Klant> GeefAlle()
        {
            List<Klant> resultSet = new List<Klant>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Adres FROM [Klanten]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string voornaam = (string)reader.GetString(1);
                string achternaam = (string)reader.GetString(2);
                int telefoonnummer = (int)reader.GetInt32(3);
                string adres = (string)reader.GetString(4);

                Klant klant = new Klant(voornaam, achternaam, telefoonnummer);
                klant.Id = id;
                klant.Adres = adres;
                resultSet.Add(klant);
            }
            reader.Close();
            return resultSet;
        }


        //Functie om klanten op naam op te halen
        public override List<Klant> GeefOpNaam(string naamIngave)
        {
            List<Klant> resultSet = new List<Klant>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Adres FROM [Klanten]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                string voornaam = (string)reader.GetString(1);
                string achternaam = (string)reader.GetString(2);
                if (voornaam.ToLower().Contains(naamIngave.ToLower()) || achternaam.ToLower().Contains(naamIngave.ToLower()))
                {
                    int id = reader.GetInt32(0);
                    
                    int telefoonnummer = (int)reader.GetInt32(3);
                    string adres = (string)reader.GetString(4);

                    Klant klant = new Klant(voornaam, achternaam, telefoonnummer);
                    klant.Id = id;
                    klant.Adres = adres;
                    resultSet.Add(klant);
                }
            }
            reader.Close();
            return resultSet;
        }


        //Functie om klant op te halen op basis van Id
        public override Klant? GeefOpId(int idIngave)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Adres FROM [Klanten]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                if (id == idIngave)
                {
                    string voornaam = (string)reader.GetString(1);
                    string achternaam = (string)reader.GetString(2);
                    int telefoonnummer = (int)reader.GetInt32(3);
                    string adres = (string)reader.GetString(4);

                    Klant klant = new Klant(voornaam, achternaam, telefoonnummer);
                    klant.Id = id;
                    klant.Adres = adres;
                    reader.Close();
                    return klant;
                }
            }
            return null;
        }

        //Functie om de dieren van de klant te geven
        public void GeefDierenKlant(Klant klant)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Naam, Soort, Ras, Kleur, Geboortedatum, Gezondheidsstatus, BaasjeId FROM [Dieren] WHERE BaasjeId = @Id";
            command.Parameters.AddWithValue("@Id", klant.Id);
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

                Dier dier = new Dier(naam, soort, kleur, geboortedatum, klant);
                dier.Id = id;
                dier.Ras = ras;
                dier.Gezondheidsstatus = gezondheidsstatus;
                klant.Huisdieren.Add(dier);
            }
        }
    }
}
