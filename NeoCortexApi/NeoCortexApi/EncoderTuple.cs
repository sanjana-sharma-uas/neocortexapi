using System;
using System.Text;
using NeoCortexApi.Entities;

namespace NeoCortexApi.Utility
{
    public class EncoderTuple : Tuple
    {
        private static long serialVersionUID;
    

    
        public EncoderTuple(String name, Encoder e, int offset)
        
            : base(name, e, offset)
        {
            if ((name == null))
            {
                throw new ArgumentException(("Can\'t instantiate an EncoderTuple " + " with a null Name"));
            }

            if ((e == null))
            {
                throw new ArgumentException(("Can\'t instantiate an EncoderTuple " + " with a null Encoder"));
            }
        }


        public String GetName()
        {
            return (String)Get(0);
        }

        public Encoder GetEncoder()
        {
            return (Encoder)Get(1);
        }

        public int GetOffset()
        {
            return (Integer)Get(2);
        }
    }
}

