using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace StardewValleySave {
    [XmlRoot("dictionary")]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable,
        INotifyCollectionChanged {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public XmlSchema GetSchema() {
            return null;
        }

        public void ReadXml(XmlReader reader) {
            var xmlSerializer = new XmlSerializer(typeof(TKey));
            var xmlSerializer1 = new XmlSerializer(typeof(TValue));
            var isEmptyElement = reader.IsEmptyElement;
            reader.Read();
            if (isEmptyElement) {
                return;
            }
            while (reader.NodeType != XmlNodeType.EndElement) {
                reader.ReadStartElement("item");
                reader.ReadStartElement("key");
                var tKey = (TKey) xmlSerializer.Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                var tValue = (TValue) xmlSerializer1.Deserialize(reader);
                reader.ReadEndElement();
                Add(tKey, tValue);
                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer) {
            var xmlSerializer = new XmlSerializer(typeof(TKey));
            var xmlSerializer1 = new XmlSerializer(typeof(TValue));
            foreach (var key in Keys) {
                writer.WriteStartElement("item");
                writer.WriteStartElement("key");
                xmlSerializer.Serialize(writer, key);
                writer.WriteEndElement();
                writer.WriteStartElement("value");
                xmlSerializer1.Serialize(writer, base[key]);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }

        public new void Add(TKey key, TValue value) {
            base.Add(key, value);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, key, 0));
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
            CollectionChanged?.Invoke(null, e);
        }

        public new bool Remove(TKey key) {
            var flag = base.Remove(key);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, key, 0));
            return flag;
        }
    }
}