using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Collections;
using System.Text.Json.Serialization;


namespace DiGi.Geometry.Visual.Core.Classes
{
    public abstract class VisualCollection<T> : Visual, IVisualCollection<T> where T : IVisual
    {
        [JsonIgnore]
        private Dictionary<GuidReference, T> dictionary = new Dictionary<GuidReference, T>();

        public VisualCollection(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VisualCollection(VisualCollection<T> visualCollection)
            : base(visualCollection)
        {

        }

        public VisualCollection(IEnumerable<T> visuals)
            : base()
        {

        }

        public VisualCollection()
            : base()
        {

        }

        [JsonInclude, JsonPropertyName("Values")]
        private IEnumerable<T> values
        {
            get
            {
                return GetValues();
            }

            set
            {
                SetValues(value);
            }
        }

        public bool Add(T value)
        {
            if (value == null)
            {
                return false;
            }

            dictionary[new GuidReference(value)] = value;
            return true;
        }

        public bool Remove(GuidReference guidReference)
        {
            if(guidReference == null)
            {
                return false;
            }

            return dictionary.Remove(guidReference);
        }

        public bool Remove(T value)
        {
            if(value == null)
            {
                return false;
            }

            return Remove(new GuidReference(value));
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Contains(T value)
        {
            if(value == null)
            {
                return false;
            }

            return Contains(new GuidReference(value));
        }

        public bool Contains(GuidReference guidReference)
        {
            if(guidReference == null)
            {
                return false;
            }

            return dictionary.ContainsKey(guidReference);
        }

        [JsonIgnore]
        public T this[GuidReference guidReference]
        {
            get
            {
                if(guidReference == null)
                {
                    return default;
                }

                return dictionary[guidReference];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetValues().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> GetValues()
        {
            return dictionary == null ? null : new List<T>(dictionary.Values);
        }

        public void SetValues(IEnumerable<T> values)
        {
            dictionary.Clear();
            if(values == null)
            {
                return;
            }

            foreach(T value in values)
            {
                Add(value);
            }

        }
    }
}
