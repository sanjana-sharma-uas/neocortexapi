using System;
using System.Collections.Generic;
using System.Text;
using EncoderTupleModel = NeoCortexApi.Encoders.EncoderTuple;
using NeoCortexApi.Utility;
namespace NeoCortexApi
{
    public class ScalarEncoder2 {
        
        protected SortedDictionary<EncoderTuple, List<EncoderTupleModel>> encoders;
        
        public SortedDictionary<EncoderTuple, List<EncoderTupleModel>> getEncoders() {
            if(encoders == null) {
                encoders = new SortedDictionary<EncoderTuple, List<EncoderTupleModel>>();
            }
            return encoders;
        }
     
  

    public EncoderTuple getEncoderTuple(ScalarEncoder2 e) {
            if (encoders == null) {
                encoders = new SortedDictionary<EncoderTuple, List<EncoderTupleModel>>();
            }
            
            foreach (EncoderTuple tuple in encoders.Keys) {
                if (tuple.GetEncoder().Equals(e)) {
                    return tuple;
                }
                
            }
            
            return null;
        }

    
        public int[] getBucketIndices(string input)
        {
            List<int> l = new List<int>();
            SortedDictionary<EncoderTuple, List<EncoderTupleModel>> encoders = getEncoders();
            if (((encoders != null)
                 && (encoders.Count > 0)))
            {
                foreach (EncoderTuple t in encoders.Keys)
                {
                   l.AddRange(getBucketIndices(input));

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
    SortedDictionary<EncoderTuple, List<EncoderTupleModel>> encoders = getEncoders();
        if (((encoders != null)
    && (encoders.Count > 0)))
    {
        foreach (EncoderTuple t in encoders.Keys) {
            //l.Add(t.GetEncoder());
        }
            
    }
    else {
        throw new ArgumentException(("Should be implemented in base classes that are not " + "containers for other encoders"));
    }
        
    return l.ToArray();
    }
   }
}

