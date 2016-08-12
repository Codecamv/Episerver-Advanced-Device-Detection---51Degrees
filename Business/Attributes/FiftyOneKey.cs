namespace FiftyOneDegrees.Business.Attributes
{
    public class FiftyOneKey : System.Attribute
    {
        private string _value;
        public FiftyOneKey(string value)
        {
            _value = value;
        }
        public string Value
        {
            get { return _value; }
        }
    }
}
