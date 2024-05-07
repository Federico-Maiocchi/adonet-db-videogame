using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
        
        public Videogame(int id, string name, string overview, DateTime releaseDate, DateTime createAt, DateTime updatedAt, int softwareHouse) 
        {

            Id = id;
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
        static void InsertVideogame(int id, string name, string overview, DateTime release_date, DateTime created_at, DateTime updated_at, int software_house)
        {
            Videogame NewVideogame = new Videogame(id, name, overview, release_date, created_at, updated_at, software_house);

        }

        static void GetVideogameByID()
        {

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
