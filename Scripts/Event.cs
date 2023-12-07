using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kursova.Scripts
{
    public enum EventType 
    {
        Fire,
        Robbery,
        Attack,
        Vandalism,
        TrafficAccident,
        NaturalDisaster,
        Accident,
        StructuralCollapse,
        Flood,
        Other
    }

    public static class EventTranslations
    {
        public static Dictionary<EventType, string> UkrainianTranslations = new Dictionary<EventType, string>
        {
            { EventType.Fire, "������" },
            { EventType.Robbery, "�����" },
            { EventType.Attack, "�����" },
            { EventType.Vandalism, "��������" },
            { EventType.TrafficAccident, "���" },
            { EventType.NaturalDisaster, "�������� ����������" },
            { EventType.Accident, "�������� �������" },
            { EventType.StructuralCollapse, "��������� ������" },
            { EventType.Flood, "����������" },
            { EventType.Other, "����" }
        };
    }

    public class Event
    {
        public EventType EventType { get; set; }
        public Location Location { get; set; }
        public int DangerLevel { get; set; }

        public static List<Location> ReadAddress()
        {
            string xmlFilePath = "Data/addresses.xml";

            XDocument xdoc = XDocument.Load(xmlFilePath);

            var locations = from location in xdoc.Element("Addresses").Elements("Name")
                            select new Location((string)location);

            return locations.ToList();
        }
    }
}