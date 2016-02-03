using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace origami
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 10;

            var paper = new Paper();

            for (int i = 0; i < N; i++)
            {
                paper = paper.Fold();
            }
            
            paper.Folds.ForEach(x => Console.Write((int)x));
        }
    }
}
