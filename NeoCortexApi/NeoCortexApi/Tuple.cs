using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NeoCortexApi
{
    public class Tuple : IComparable<Tuple>
    {
        private static readonly long serialVersionUID = 1L;


        protected Object[] Container;

        private int hashcode;

        private IComparable<Tuple> _comparator;

        public Tuple()
        {
        }

        public Tuple(String name, Encoder e, int offset)
        {
        }

        public Tuple(Object[] objects = null)
        {
            remake(objects);
        }


        public Tuple(IComparable<Tuple> c, Object[] objects = null)
        {
            _comparator = c;
            remake(objects);
        }

        protected void remake(Object[] objects = null )
        {
            if (objects is null) objects = new object[1];
            Container = new Object[objects.Length];
            for (int i = 0; i < objects.Length; i++)
            {
                Container[i] = objects[i];
            }

            this.hashcode = GetHashCode();
        }


        public Object Get(int index)
        {
            return Container[index];
        }


        public  int Size()
        {
            return Container.Length;
        }


        public List<Object> All()
        {
            // read only --> ReadOnlyCollection output = ReadOnlyCollection(Container.ToList())
            return Container.ToList();
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Container.Length; i++)
            {
                try
                {
                    var containerValue = (double)Container[i];
                    sb.Append(containerValue);
                }
                catch (ArgumentException e)
                {
                    sb.Append("'").Append(Container[i]).Append("'");
                }

                sb.Append(":");
            }

            return sb.ToString();
        }


        
        public override int GetHashCode()
        {

            int prime = 31;
            int result = 1;
            result = prime* result + Container.GetHashCode();
            return result;
        }

    // obj1.Equals(obj2)
    public override bool Equals (Object obj) {
        if (this == obj)  return true;
        if (obj == null) return false;
        if (GetType().Name != obj.GetType().Name)  return false;
        Tuple other = (Tuple) obj;
        if (hashcode != other.hashcode)  return false;
        return true;
    }


    
    public int CompareTo(Tuple t)
    {
        if (_comparator == null)
        {
            throw new ArgumentException("Tuples used for comparison should be " +
                                        "instantiated using the constructor taking a Comparator");
        }

        return _comparator.CompareTo(t);
    }
}
}