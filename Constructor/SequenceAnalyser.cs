using System;

namespace ConsoleApp1
{
    class SequenceAnalyser
    {
        public readonly int[] Sequence;

        public SequenceAnalyser() : this(new int[0])
        {
        }
        
        public SequenceAnalyser(int[] sequence)
        {
            Sequence = sequence;
        }

        public SequenceAnalyser(Random rng, int length) : this(new int[length])
        {
            for (int i = 0; i < Sequence.Length; i++)
            {
                Sequence[i] = rng.Next(10);
            }
        }

        public SequenceAnalyser(Random rng) : this(rng, rng.Next(100))
        {

        }
    }
}
