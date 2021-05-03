using System;
using System.Collections.Generic;
using NeoCortexApi.Encoders;

namespace NeoCortexApi
{
    public class ScalarEncoder2{
        
        protected SortedDictionary<EncoderTuple, List<EncoderTuple>> encoders;
        
        public SortedDictionary<EncoderTuple, List<EncoderTuple>> getEncoders() {
            if(encoders == null) {
                encoders = new SortedDictionary<EncoderTuple, List<EncoderTuple>>();
            }
            return encoders;
        }
     
  

    public EncoderTuple getEncoderTuple(ScalarEncoder2 e) {
            if (encoders == null) {
                encoders = new SortedDictionary<EncoderTuple, List<EncoderTuple>>();
            }
            
            foreach (EncoderTuple tuple in encoders.Keys) {
                if (tuple.getEncoder.equals(e)) {
                    return tuple;
                }
                
            }
            
            return null;
        }

    
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
                throw new ArgumentException(("Should be implemented in base classes that are not " +
                                             "containers for other encoders"));
            }

            return l.ToArray();
        }
    


public int[] getBucketIndices(double input) {
    List<int> l = new List<int>();
    Dictionary<EncoderTuple, List<EncoderTuple>> encoders = getEncoders();
        if (((encoders != null)
    && (encoders.Count > 0)))
    {
        foreach (EncoderTuple t in encoders.Keys) {
            l.addAll(t.getEncoder().getBucketIndices(input));
        }
            
    }
    else {
        throw new ArgumentException(("Should be implemented in base classes that are not " + "containers for other encoders"));
    }
        
    return l.ToArray();
    }
   }
}

