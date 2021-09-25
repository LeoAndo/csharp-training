namespace CustomOperatorSample
{
    internal class Counter
    {
        public Counter(int cnt)
        {
            Count = cnt;
        }

        public int Count { get; internal set; }

        // + operatorをカスタマイズ
        public static Counter operator +(Counter x, Counter y)
        {
            return new Counter(x.Count + y.Count);
        }

        // 明示的な型変換
        public static explicit operator int(Counter value)
        {
            return value.Count;
        }
        // 暗黙的な型変換
        public static implicit operator Counter(int value)
        {
            return new Counter(value);
        }
    }
}