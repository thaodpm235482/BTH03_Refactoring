namespace Pattern16_SelfEncapsulateField._1_Before
{
    public class BeforeCode
    {
        private int _low;
        private int _high;

        public bool Includes(int arg)
        {
            // Truyn cập trực tiếp biến private trong chính class đó
            return arg >= _low && arg <= _high;
        }
    }
}