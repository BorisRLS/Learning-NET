namespace Random.Shared
{
    internal class NextDouble
    {
        private object min;
        private object max;

        public NextDouble(object min, object max)
        {
            this.min = min;
            this.max = max;
        }
    }
}