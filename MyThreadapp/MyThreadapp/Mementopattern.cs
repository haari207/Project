using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyThreadapp
{
    [Serializable]
    public class Memento
    {
        public string State { get; set; }

        public Memento() { } // Parameterless constructor for XML serialization

        public Memento(string state)
        {
            State = state;
        }
    }

    // Originator class
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveState()
        {
            return new Memento(State);
        }

        public void RestoreState(Memento memento)
        {
            State = memento.State;
        }
    }

    // Caretaker class (Handles XML serialization)
    public class Caretaker
    {
        public void SaveToXml(Memento memento, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Memento));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, memento);
            }
        }

        public Memento LoadFromXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Memento));
            using (TextReader reader = new StreamReader(filename))
            {
                return (Memento)serializer.Deserialize(reader);
            }
        }
    }
}
