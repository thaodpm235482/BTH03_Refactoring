using System;
using System.Collections.Generic;

namespace Pattern09_SubstituteAlgorithm._2_After
{
    public class AfterCode
    {
        public string FoundPerson(string[] people)
        {
            // Thay thế bằng danh sách mẫu và sử dụng List.Contains để tra cứu nhanh hơn
            var candidates = new List<string> { "Don", "John", "Kent" };
            foreach (var person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }
            return "";
        }
    }
}