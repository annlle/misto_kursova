using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursova.Scripts
{
    public enum EventType 
    {
        Fire,
        Robbery,
        Attack,
        Vandalism,
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
            { EventType.Other, "����" }
        };
    }

    public class Event
    {
        public EventType EventType { get; set; }
        public Location Location { get; set; }
        public int DangerLevel { get; set; }
    }
}