namespace Manatee.Validation.ViewModels
{
    public class Param
    {
        public string Name { get; private set; }
        public object Value { get; private set; }

        public Param(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}