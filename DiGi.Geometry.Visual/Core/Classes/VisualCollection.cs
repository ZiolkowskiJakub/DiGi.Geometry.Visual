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
        private Dictionary<UniqueReference, T> dictionary = new Dictionary<UniqueReference, T>();

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

            dictionary[new UniqueReference(value)] = value;
            return true;
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            return dictionary.Remove(uniqueReference);
        }

        public bool Remove(T value)
        {
            if(value == null)
            {
                return false;
            }

            return Remove(new UniqueReference(value));
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

            return Contains(new UniqueReference(value));
        }

        public bool Contains(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            return dictionary.ContainsKey(uniqueReference);
        }

        [JsonIgnore]
        public T this[UniqueReference uniqueReference]
        {
            get
            {
                if(uniqueReference == null)
                {
                    return default;
                }

                return dictionary[uniqueReference];
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
