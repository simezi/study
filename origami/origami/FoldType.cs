namespace origami
{
    public enum FoldType
    {
        Tani = 0,
        Yama = 1
    }

    public static class FoldTypeExt
    {
        public static FoldType Reverse(this FoldType type)
        {
            return 1-type;
        }
    }
}