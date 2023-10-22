using System;

namespace misto
{
public abstract class Location
{
		protected string adress;
		protected string geo_location;
		protected string picture;

	public Location(string adress)
	{
		this.adress = adress;
	}


}
}
