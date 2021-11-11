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
        //Protected methode om nieuwe Dierenarts aan te maken
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

        //Protected methode om Dierenarts te updaten
        protected override void Update(Dierenarts dierenarts)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "UPDATE [Dierenartsen] SET [Voornaam] = @Voornaam, [Achternaam] = @Achternaam, [Telefoonnummer] = @Telefoonnummer, [Specialisatie] = @Specialisatie  WHERE Id = @Id";
            command.Parameters.AddWithValue("@Voornaam", dierenarts.Voornaam);
            command.Parameters.AddWithValue("@Id", dierenarts.Id);
            command.Parameters.AddWithValue("@Achternaam", dierenarts.Achternaam);
            command.Parameters.AddWithValue("@Telefoonnummer", dierenarts.Telefoonnummer);
            command.Parameters.AddWithValue("@Specialisatie", dierenarts.Specialisatie.ToString());

            command.ExecuteNonQuery();
        }

        //Als dierenarts wordt verwijderd worden ook alle afspraken met hem verwijderd
        public override void Delete(Dierenarts dierenarts)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [Afspraken] WHERE ArtsId = @Id; DELETE FROM [Dierenartsen] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", dierenarts.Id);
            command.ExecuteNonQuery();
        }

        //Functie om alle dierenarten in een keer op te halen uit database en om deze lijst later te kunnen tonen op het venster
        public override List<Dierenarts> GeefAlle()
        {
            List<Dierenarts> resultSet = new List<Dierenarts>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Specialisatie FROM [Dierenartsen]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string voornaam = (string)reader.GetString(1);
                string achternaam = (string)reader.GetString(2);
                int telefoonnummer = (int)reader.GetInt32(3);
                SpecialisatieType type = mapSpecialisatieType((string)reader.GetString(4));
                Dierenarts dierenarts = new Dierenarts(voornaam, achternaam, telefoonnummer, type);
                dierenarts.Id = Id;
                resultSet.Add(dierenarts);
            }
            reader.Close();
            return resultSet;
        }

        //Functie om een selectie van klanten of één specifieke klant op te halen op basis van ingave van Voornaam
        public override List<Dierenarts> GeefOpNaam(string naamIngave)
        {
            List<Dierenarts> resultSet = new List<Dierenarts>();
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Specialisatie FROM [Dierenartsen]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                string voornaam = (string)reader.GetString(1);
                if (voornaam.Contains(naamIngave))
                {
                    int id = reader.GetInt32(0);
                    string achternaam = (string)reader.GetString(2);
                    int telefoonnummer = (int)reader.GetInt32(3);
                    SpecialisatieType type = mapSpecialisatieType((string)reader.GetString(4));
                    Dierenarts dierenarts = new Dierenarts(voornaam, achternaam, telefoonnummer, type);
                    dierenarts.Id = id;
                    resultSet.Add(dierenarts);
                }
            }
            reader.Close();
            return resultSet;
        }


        public override Dierenarts? GeefOpId(int idIngave)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, Voornaam, Achternaam, Telefoonnummer, Specialisatie FROM [Dierenartsen]";
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
                    SpecialisatieType type = mapSpecialisatieType((string)reader.GetString(4));
                    Dierenarts dierenarts = new Dierenarts(voornaam, achternaam, telefoonnummer, type);
                    dierenarts.Id = id;
                    reader.Close();
                    return dierenarts;
                }
            }
            return null;
        }

        //Functie om het Specialisatietype vanuit database (string) te mappen op deze van object Dierenarts (enum Specialisatietype)
        protected SpecialisatieType mapSpecialisatieType(string DbValue)
        {
            SpecialisatieType returnType = new SpecialisatieType();
            switch (DbValue)
            {
                case "KattenEnHonden":
                    returnType = SpecialisatieType.KattenEnHonden;
                    break;
                case "Reptielen":
                    returnType = SpecialisatieType.Reptielen;
                    break;
                case "Vogels":
                    returnType = SpecialisatieType.Vogels;
                    break;
                case "Knaagdieren":
                    returnType = SpecialisatieType.Knaagdieren;
                    break;
            }
            return returnType;
        }
    }
}
