using System;

namespace GreenStyling.Models
{
	internal class Title
	{
		internal int Id;
		internal string Name;
		internal string Artist;
		internal TimeSpan Length;



		internal Title(int id, string name, string artist, TimeSpan length)
		{
			Id = id;
			Name = name;
			Artist = artist;
			Length = length;
		}
	}
}
