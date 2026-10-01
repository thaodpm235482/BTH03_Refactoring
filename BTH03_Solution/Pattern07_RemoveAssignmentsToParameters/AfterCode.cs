using System;

namespace Pattern07_RemoveAssignmentsToParameters._2_After
{
    public class AfterCode
    {
        public int Discount(int inputVal, int quantity)
        {
            // Tạo biến cục bộ để lưu trữ và tính toán
            int result = inputVal;
            if (result > 50) result -= 2;
            if (quantity > 100) result -= 1;
            return result;
        }
    }
}