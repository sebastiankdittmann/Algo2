﻿namespace MergeSort.Algorithms
{
    public class FibonacciCounter : IAlgorithm
    {
        public int[] GetSequence(int steps)
        {
            var sequence = new int[steps];
            sequence[0] = 1;

            if(steps > 1)
            {
                sequence[1] = 2;
            }

            for (var i = 2; i < steps; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }

            return sequence;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Visualize()
        {
            throw new System.NotImplementedException();
        }
    }
}
