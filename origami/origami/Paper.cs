using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace origami
{
   public class Paper
    {
        public List<FoldType> Folds { get; private set; } = new List<FoldType>();

        public Paper() { }

        private Paper(List<FoldType> folds)
        {
            this.Folds = folds;
        }

        public Paper Fold()
        {
            if (!Folds.Any())
            {
                return new Paper(new List<FoldType>() {FoldType.Tani});
            }
            var size = (int) Folds.Count()/2 + 1;

            // 中央を軸にして対称の位置にある2つの折り目は山折りと谷折りが1つずつ。前半分はと今までの折り目は一致する。
            var newFolds = new List<FoldType>();
            Folds.ForEach(x => newFolds.Add(x));
            newFolds.Add(FoldType.Tani);
            Folds.AsEnumerable().Reverse().ToList().ForEach(x => newFolds.Add(x.Reverse()));
            

            return new Paper(newFolds);
        }

    }
}