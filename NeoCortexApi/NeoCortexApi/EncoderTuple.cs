    using System;
    using System.Text;
    using NeoCortexApi.Entities;

    namespace NeoCortexApi.Utility
    {
        public class EncoderTuple : Tuple
        {

            private static long serialVersionUID;
        }

        public class EncoderTuple
        {
            publicEncoderTuple(String, name, Encoder, <, Question, Greater, e, int, offset);
            {
                base.(name, e, offset);
                if ((name == null))
                {
                    throw new ArgumentException(("Can\'t instantiate an EncoderTuple " + " with a null Name"));
                }

                if ((e == null))
                {
                    throw new ArgumentException(("Can\'t instantiate an EncoderTuple " + " with a null Encoder"));
                }


                public String getName()
                {
                    return ((String) (get(0)));
                }

                public Encoder getEncoder()
                {
                    return ((Encoder) (get(1)));
                }

                public int getOffset()
                {
                    return ((Integer) (get(2)));
                }
            }
        }
    }
    
