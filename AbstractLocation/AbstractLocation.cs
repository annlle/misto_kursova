using System;

namespace misto
{
    public abstract class Location
    {
        protected string adress;
        protected string picture;
        protected string geo_location;

        public string GetAdress()
        {
            return adress;
        };
        public abstract void SetAdress(string n_adress);    // абстрактні сеттери під 
                                                            // індивідальні потреби класів
        public string GetPicture()
        {
            return picture;
        };
        public abstract void SetPicture(string n_picture);

        public string GetGeoLocation()
        {
            return geo_location;
        };
        public abstract void SetGeoLocation(string n_geo_location);

    }
}
