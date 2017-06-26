namespace csharp6_features_demo
{
    class ReadOnlyProperty
    {
        public string FirstName { get; }
        public string LastName { get; }
        public ReadOnlyProperty()
        {
            FirstName = "Swaminathan";
            LastName = "Vetri";
        }

        public void setName()
        {
            //The below two lines will fail as the properties are read only by default

            //FirstName = "AnotherFirstName";
            //LastName = "AnotherLastName";
        }
    }
}
