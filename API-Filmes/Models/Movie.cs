using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Filmes.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Film must have a title")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        [Range(1, 600, ErrorMessage = "Film lenght exceed maximum of 600 minutes")]
        public int Lenght { get; set; }
        //public string Lenght
        //{
        //    get { return Lenght; }
        //    set
        //    {
        //        int lenght = Int32.Parse(Lenght);
        //        int hour = lenght / 60;
        //        int minute = lenght % 60;
        //        Lenght = string.Format("{0:00}:{1:00}", (int)hour, (int)minute);
        //    }
        //}
        //public string LenghtH
        //{
        //    get { return LenghtH; }
        //    private set
        //    {
        //        int hour = Lenght / 60;
        //        int minute = Lenght % 60;
        //        LenghtH = String.Format("{0:00}:{1:00}", (int)hour, (int)minute);
        //    }
        //}
    }
}
