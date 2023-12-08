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
        GasLeak,
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
            { EventType.GasLeak, "���� ����" },
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