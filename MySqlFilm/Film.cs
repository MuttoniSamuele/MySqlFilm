using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlFilm
{
	public class Film
	{
		public int Id { get; }
		public string Name { get; set; }
		public string Synopsis { get; set; }
		public TimeSpan Duration { get; set; }
		public DateTime ReleaseDate { get; set; }
		public int genreId { get; set; }

		public Film(int id, string name, string synopsis, TimeSpan duration, DateTime releaseDate, int genreId)
		{
			this.Id = id;
			this.Name = name;
			this.Synopsis = synopsis;
			this.Duration = duration;
			this.ReleaseDate = releaseDate;
			this.genreId = genreId;
		}
		public override string ToString()
		{
			return $"Id: {Id}, Nome: {Name}, Trama: {Synopsis}, durata: {Duration}, dataUscita: {ReleaseDate}, idgenere: {genreId}";
		}	
	}
}
