namespace Pattern19_ChangeReferenceToValue._2_After
{
    // Chuyển thành Value Object (Immutable - không thể sửa sau khi khởi tạo)
    public class Currency
    {
        public string Code { get; }
        public Currency(string code) => Code = code;

        public override bool Equals(object obj)
        {
            if (obj is Currency other)
                return Code == other.Code;
            return false;
        }

        public override int GetHashCode() => Code?.GetHashCode() ?? 0;
    }
}