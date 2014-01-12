namespace FakesTutorialLib
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public double CalculatePostage()
        {
            // some complicated math here.... with calls to external sources

            return 35.5d;
        }
    }
}