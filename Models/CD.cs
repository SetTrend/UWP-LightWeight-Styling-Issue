namespace GreenStyling.Models
{
	internal class CD
	{
		internal int Id;
		internal string Name;
		internal string Artist;
		internal GenreEnum Genre;
		internal Title[] Titles;


		internal CD(int id, string name, GenreEnum genre, Title[] titles) : this(id, name, null, genre, titles) { }

		internal CD(int id, string name, string artist, GenreEnum genre, Title[] titles)
		{
			Id = id;
			Name = name;
			Artist = artist;
			Genre = genre;
			Titles = titles;
		}
	}
}
