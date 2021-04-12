namespace NeoCortexApi
{
    public class ScalarEncoder2
    {
        public int[] getBucketIndices(String input)
        {
            TIntList l = new TIntArrayList();
            Map<EncoderTuple, List<EncoderTuple>> encoders = getEncoders();
            if (((encoders != null)
                 && (encoders.size() > 0)))
            {
                foreach (EncoderTuple t in encoders.keySet())
                {
                    l.addAll(t.getEncoder().getBucketIndices(input));
                }

            }
            else
            {
                throw new IllegalStateException(("Should be implemented in base classes that are not " +
                                                 "containers for other encoders"));
            }

            return l.toArray();
        }
    }
}