using System;

namespace ConsoleApp1
{
    class SequenceAnalyser
    {
        public readonly int[] Sequence;
        
        public SequenceAnalyser(int[] sequence) // This is a "base" constructor, which doesn't
        {                                       // call any other constructors; a "base" constructor
            Sequence = sequence;                // typically does the dirty work of actually setting
        }                                       // the typical attributes (Sequence here)

        public SequenceAnalyser() // this(new int[0]) can be inlined with the above signature,
            : this(new int[0])    // but putting it on the next line, might help visualize how
        {                         // this(new int[0]) is simply the "first line" of the body here
        }

        public SequenceAnalyser(Random rng, int length) // We reuse the first constructor here,
            : this(new int[length])                     // since it already has code to set the
        {                                               // sequence array, so we simply pass it
            for (int i = 0; i < Sequence.Length; i++)   // the proper argument. Notice that the
            {                                           // body of this constructor is performed
                Sequence[i] = rng.Next(10);             // **after** the this(new int[length])
            }                                           // is called, so Sequence is set!
        }

        public SequenceAnalyser(Random rng) // This one might seem a bit tricky, but remember that
            : this(rng, rng.Next(100))      // this(rng, rng.Next(100)) is simply "the first line"
        {                                   // of code in this constructor body, so we can use the
                                            // passed in Random argument as we would have!
        }                                   // This is pretty nifty.
    }
}
