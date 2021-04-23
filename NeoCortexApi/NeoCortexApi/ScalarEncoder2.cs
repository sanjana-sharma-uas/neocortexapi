using System;
using System.Collections.Generic;
using NeoCortexApi.Encoders;

namespace NeoCortexApi
{
    public class ScalarEncoder2
    {
        public int[] getBucketIndices(string input)
        {
            List<int> l = new List<int>();
            Dictionary<EncoderTuple, List<EncoderTuple>> encoders = getEncoders();
            if (((encoders != null)
                 && (encoders.Count > 0)))
            {
                foreach (EncoderTuple t in encoders.Keys)
                {
                    l.addAll(t.getEncoder().getBucketIndices(input));
                    
                }

            }
            else
            {
                throw new ArgumentException (("Should be implemented in base classes that are not " +
                                             "containers for other encoders"));
            }

            return l.ToArray();
        }
    }
}