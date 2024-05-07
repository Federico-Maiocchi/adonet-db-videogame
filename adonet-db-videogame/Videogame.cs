using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string Overview {  get; set; }

        public DateTime ReleaseDate {  get; set; }

        public DateTime CreatetAt {  get; set; }

        public DateTime UpdateAt {  get; set; }

        public int SoftwareHouse {  get; set; }
        
        public Videogame(int id, string name, string overview, DateTime release_date, DateTime create_at, DateTime update_at, int software_house) 
        {

            Id = id;
            Name = name;
            Overview = overview;
            ReleaseDate = release_date;
            CreatetAt = create_at;
            UpdateAt = update_at;
            SoftwareHouse = software_house;
        }

    }

    
}
