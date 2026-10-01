using System;

namespace Pattern07_RemoveAssignmentsToParameters._1_Before
{
    public class BeforeCode
    {
        public int Discount(int inputVal, int quantity)
        {
            // Gán lại trực tiếp giá trị mới cho tham số truyền vào (Bad Practice)
            if (inputVal > 50) inputVal -= 2;
            if (quantity > 100) inputVal -= 1;
            return inputVal;
        }
    }
}
