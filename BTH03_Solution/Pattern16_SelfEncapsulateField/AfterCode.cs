namespace Pattern16_SelfEncapsulateField._2_After
{
    public class AfterCode
    {
        private int _low;
        private int _high;

        public int Low
        {
            get => _low;
            set => _low = value;
        }

        public int High
        {
            get => _high;
            set => _high = value;
        }

        public bool Includes(int arg)
        {
            return arg >= Low && arg <= High;
        }
    }
}