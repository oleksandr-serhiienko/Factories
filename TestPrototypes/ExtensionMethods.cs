using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace TestPrototypes
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formater.Deserialize(stream);
            return (T)copy;

        }

        public static T DeepCopyXml<T>(this T self)
        {
            using var ms = new MemoryStream();
            var s = new XmlSerializer(typeof(T));
            s.Serialize(ms, self);
            ms.Position = 0;
            return (T)s.Deserialize(ms);
        }


    }
}
