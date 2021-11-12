using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dierenartsenpraktijk.Model;

namespace Dierenartsenpraktijk.Data
{
    internal class AfspraakRepository:BaseRepository<Afspraak>
    {
        //Functie om nieuwe Afspraak aan te maken
        protected override Afspraak Insert(Afspraak afspraak) 
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "INSERT INTO [Afspraken] (DatumTijdstip, ArtsId, KlantId, DierId, RedenConsult)" +
                " VALUES (@DatumTijdstip, @ArtsId, @KlantId, @DierId, @RedenConsult); SELECT SCOPE_IDENTITY()";
            command.Parameters.AddWithValue("@DatumTijdstip", afspraak.DatumTijdstip);
            command.Parameters.AddWithValue("@ArtsId", afspraak.Arts.Id);
            command.Parameters.AddWithValue("@KlantId", afspraak.Klant.Id);
            command.Parameters.AddWithValue("@DierId", afspraak.Dier.Id);
            command.Parameters.AddWithValue("@RedenConsult", afspraak.Reden);

            using var reader = command.ExecuteReader();
            reader.Read();
            afspraak.Id = (int)reader.GetDecimal(0);
            return afspraak;
        }

        //Protected methode om Klant te updaten
        protected override void Update(Afspraak afspraak)
        {
            using var command = _connection.CreateCommand();

            command.CommandText = "UPDATE [Afspraken] SET [DatumTijdstip] = @DatumTijdstip, [ArtsId] = @ArtsId," +
                " [KlantId] = @KlantId, [DierId] = @DierId, [RedenConsult] = @Redenconsult  WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", afspraak.Id);
            command.Parameters.AddWithValue("@DatumTijdstip", afspraak.DatumTijdstip);
            command.Parameters.AddWithValue("@ArtsId", afspraak.Arts.Id);
            command.Parameters.AddWithValue("@KlantId", afspraak.Klant.Id);
            command.Parameters.AddWithValue("@DierId", afspraak.Dier.Id);
            command.Parameters.AddWithValue("@RedenConsult", afspraak.Reden);

            command.ExecuteNonQuery();
        }


        //Methode om Afspraak te verwijderen
        public override void Delete(Afspraak afspraak)
        {
            using var command = _connection.CreateCommand();
            command.CommandText = "DELETE FROM [Afspraken] WHERE [Id] = @Id";
            command.Parameters.AddWithValue("@Id", afspraak.Id);
            command.ExecuteNonQuery();
        }


        //Functie om alle afspraken in een keer op te halen uit database en om deze lijst later te kunnen tonen op het venster
        public override List<Afspraak> GeefAlle()
        {
            List<Afspraak> resultSet = new List<Afspraak>();
            KlantRepository klantRepository = new KlantRepository();
            DierenartsRepository dierenartsRepository= new DierenartsRepository();
            DierRepository dierRepository = new DierRepository();

            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, DatumTijdstip, ArtsId, KlantId, DierId, RedenConsult FROM [Afspraken]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int id = (int)reader.GetInt32(0);
                DateTime datumTijdstip = reader.GetDateTime(1);
                int artsId = (int)reader.GetInt32(2);
                int klantId = (int)reader.GetInt32(3);
                int dierId = (int)reader.GetInt32(4);
                RedenAfspraak redenConsult = mapRedenAfspraak((string)reader.GetString(5));

                Dierenarts arts = dierenartsRepository.GeefOpId(artsId);
                Klant klant = klantRepository.GeefOpId(klantId);
                Dier dier = dierRepository.GeefOpId(dierId);

                Afspraak afspraak = new Afspraak(datumTijdstip, arts, klant, dier, redenConsult);
                afspraak.Id = id;
                resultSet.Add(afspraak);
            }
            reader.Close();
            return resultSet;
        }


        //Functie om afpsraken te selecteren op naam van dierenarts
        public override List<Afspraak> GeefOpNaam(string naamIngaveArts)
        {
            List<Afspraak> resultSet = new List<Afspraak>();
            KlantRepository klantRepository = new KlantRepository();
            DierenartsRepository dierenartsRepository = new DierenartsRepository();
            DierRepository dierRepository = new DierRepository();

            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, DatumTijdstip, ArtsId, KlantId, DierId, RedenConsult FROM [Afspraken]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int artsId = (int)reader.GetInt32(2);
                Dierenarts arts = dierenartsRepository.GeefOpId(artsId);
                if(arts.Voornaam == naamIngaveArts)
                {
                    int id = (int)reader.GetInt32(0);
                    DateTime datumTijdstip = reader.GetDateTime(1);
                    int klantId = (int)reader.GetInt32(3);
                    int dierId = (int)reader.GetInt32(4);
                    RedenAfspraak redenConsult = mapRedenAfspraak((string)reader.GetString(5));
                    Klant klant = klantRepository.GeefOpId(klantId);
                    Dier dier = dierRepository.GeefOpId(dierId);

                    Afspraak afspraak = new Afspraak(datumTijdstip, arts, klant, dier, redenConsult);
                    afspraak.Id = id;
                    resultSet.Add(afspraak);
                }
  
            }
            reader.Close();
            return resultSet;
        }


        //extra functie: Geef Afspraak op naam klant (om te controleren)
        public List<Afspraak> GeefOpNaamKlant(string naamIngaveArts)
        {
            List<Afspraak> resultSet = new List<Afspraak>();
            KlantRepository klantRepository = new KlantRepository();
            DierenartsRepository dierenartsRepository = new DierenartsRepository();
            DierRepository dierRepository = new DierRepository();

            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, DatumTijdstip, ArtsId, KlantId, DierId, RedenConsult FROM [Afspraken]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {
                int klantId = (int)reader.GetInt32(3);
                Klant klant = klantRepository.GeefOpId(klantId);
                if (klant.Voornaam == naamIngaveArts)
                {
                    int id = (int)reader.GetInt32(0);
                    DateTime datumTijdstip = reader.GetDateTime(1);
                    int artsId = (int)reader.GetInt32(2);
                    int dierId = (int)reader.GetInt32(4);
                    RedenAfspraak redenConsult = mapRedenAfspraak((string)reader.GetString(5));
                    Dierenarts arts = dierenartsRepository.GeefOpId(artsId);
                   
                    Dier dier = dierRepository.GeefOpId(dierId);

                    Afspraak afspraak = new Afspraak(datumTijdstip, arts, klant, dier, redenConsult);
                    afspraak.Id = id;
                    resultSet.Add(afspraak);
                }

            }
            reader.Close();
            return resultSet;
        }

        //Geef Afspraak op basis van id
        public override Afspraak GeefOpId(int idIngave)
        {
            KlantRepository klantRepository = new KlantRepository();
            DierenartsRepository dierenartsRepository = new DierenartsRepository();
            DierRepository dierRepository = new DierRepository();

            using var command = _connection.CreateCommand();
            command.CommandText = "SELECT Id, DatumTijdstip, ArtsId, KlantId, DierId, RedenConsult FROM [Afspraken]";
            using var reader = command.ExecuteReader();
            reader.Read();
            while (reader.Read())
            {

                int id = (int)reader.GetInt32(0);
                if (id == idIngave)
                {
                    DateTime datumTijdstip = reader.GetDateTime(1);
                    int artsId = (int)reader.GetInt32(2);
                    int klantId = (int)reader.GetInt32(3);
                    int dierId = (int)reader.GetInt32(4);
                    RedenAfspraak redenConsult = mapRedenAfspraak((string)reader.GetString(5));

                    Dierenarts arts = dierenartsRepository.GeefOpId(artsId);
                    Klant klant = klantRepository.GeefOpId(klantId);
                    Dier dier = dierRepository.GeefOpId(dierId);

                    Afspraak afspraak = new Afspraak(datumTijdstip, arts, klant, dier, redenConsult);
                    afspraak.Id = id;
                    reader.Close();
                    return afspraak;
                }

            }
            return null;
        }





        //Functie om het RedenCosnult vanuit database (string) te mappen op deze van object Afspraak (enum Reden)
        public RedenAfspraak mapRedenAfspraak(string DbValue)
        {
            RedenAfspraak returnType = new RedenAfspraak();
            switch (DbValue)
            {
                case "BinnenbrengenOperatie":
                    returnType = RedenAfspraak.BinnenbrengenOperatie;
                    break;
                case "Ophalen":
                    returnType = RedenAfspraak.Ophalen;
                    break;
                case "Consult":
                    returnType = RedenAfspraak.Consult;
                    break;
                case "Vaccinatie":
                    returnType = RedenAfspraak.Vaccinatie;
                    break;
            }
            return returnType;
        }

    }
}
