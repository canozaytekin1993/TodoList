using System;
using System.Xml;
using System.Xml.Serialization;

namespace TodoList
{
    public class MyXmlSerializer
    {
        public void Serialize(string patch, object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            XmlWriter writer = XmlWriter.Create(patch);

            serializer.Serialize(writer, obj);

            writer.Close();
            writer.Dispose();
        }

        public object Deserialize(string path, Type type)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            XmlReader reader = XmlReader.Create(path);

            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();

            return obj;
        }
        public void Serialize<T>(string path, T obj)
        {
            System.Xml.Serialization.XmlSerializer serialize =
                new System.Xml.Serialization.XmlSerializer(typeof(T));

            XmlWriter writer = XmlWriter.Create(path);

            serialize.Serialize(writer, obj);

            writer.Close();
            writer.Dispose();
        }

        public T Deserialize<T>(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(T));

            XmlReader reader = XmlReader.Create(path);

            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();

            return (T)obj;
        }
    }
}
