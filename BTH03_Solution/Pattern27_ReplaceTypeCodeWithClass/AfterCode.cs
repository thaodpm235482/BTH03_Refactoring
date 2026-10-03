namespace Pattern27_ReplaceTypeCodeWithClass
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);
        public static readonly BloodGroup B = new BloodGroup(2);
        public static readonly BloodGroup AB = new BloodGroup(3);

        public int Code { get; }

        private BloodGroup(int code)
        {
            Code = code;
        }
    }

    public class AfterCode
    {
        public BloodGroup BloodGroup { get; set; }

        public AfterCode(BloodGroup bloodGroup)
        {
            BloodGroup = bloodGroup;
        }
    }
}