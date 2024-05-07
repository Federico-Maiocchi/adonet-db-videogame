using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace adonet_db_videogame
{
    public class Videogame
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Overview {  get; set; }

        public DateTime ReleaseDate {  get; set; }

        public DateTime CreatetAt {  get; set; }

        public DateTime UpdatedAt {  get; set; }

        public int SoftwareHouse {  get; set; }

        public static int countId = 0; 


        
        public Videogame(string name, string overview, DateTime releaseDate, DateTime createAt, DateTime updatedAt, int softwareHouse) 
        {
            
            Id = countId++;
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            CreatetAt = createAt;
            UpdatedAt = updatedAt;
            SoftwareHouse = softwareHouse;
        }

    }

    public static class VideogameManager 
    {
        // stringa di connessione per connetterci al db
        static string stringConnection = "Data Source=localhost;Initial Catalog=db_videogames;Integrated Security=True;";

        //funzione per inserire un nuovo videogioco
        public static void InsertVideogame(string name, string overview, DateTime release_date, DateTime created_at, DateTime updated_at, int software_house_id)
        {
            Videogame NewVideogame = new Videogame(name, overview, release_date, created_at, updated_at, software_house_id);

            using SqlConnection sqlConnection = new SqlConnection(stringConnection);

            //stringa query
            string query = "INSERT INTO videogames(name, overview, release_date, created_at, updated_at, software_house_id) " +
                "VALUES (@name, @overview, @release_date, @created_at, @updated_at, @software_house_id)";

            try
            {
                sqlConnection.Open();

                using SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@overview", overview));
                cmd.Parameters.Add(new SqlParameter("@release_date", release_date));
                cmd.Parameters.Add(new SqlParameter("@created_at", created_at));
                cmd.Parameters.Add(new SqlParameter("@updated_at", updated_at));
                cmd.Parameters.Add(new SqlParameter("software_house_id", software_house_id));

                int affectedRows = cmd.ExecuteNonQuery();

            } catch( Exception ex)
            {
                Console.Write(ex.ToString());
            }


        }

        public static void GetVideogameByID()
        {
            

            using SqlConnection sqlConnection = new SqlConnection(stringConnection);

            try
            {
                sqlConnection.Open();
                string query = @"SELECT *
                FROM videogames 
                WHERE id = '5'";

                using SqlCommand cmd = new SqlCommand(query, sqlConnection);

                using SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    int indexVideogame = reader.GetOrdinal("id");
                    string nameVideogame = reader.GetString("name");
                    Console.WriteLine(nameVideogame);
                   
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        static void SearchVideogameByName()
        {

        }

        static void CancelVideogame()
        {

        }

        static void CloseProgram ()
        {

        }


    }

}
