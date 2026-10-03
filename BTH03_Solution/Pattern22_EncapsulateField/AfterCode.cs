namespace Pattern22_EncapsulateField
{
    public class AfterCode
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set => _name = value ?? string.Empty;
        }
    }
}