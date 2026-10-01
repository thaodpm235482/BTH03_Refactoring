using System;

namespace Pattern09_SubstituteAlgorithm._1_Before
{
    public class BeforeCode
    {
        public string FoundPerson(string[] people)
        {
            // Thuật toán thủ công bằng vòng lặp và nhiều câu lệnh if
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    return "John";
                }
                if (people[i].Equals("Kent"))
                {
                    return "Kent";
                }
            }
            return "";
        }
    }
}