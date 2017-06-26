namespace csharp6_features_demo
{
    class AutoPropertyInitializer
    {
        public string Csharp5Name { get; set; }

        public string Name { get; set; } = "Swami";  // new way of initializing property
        // If the setter is removed, SetName method wouldn't compile

        public AutoPropertyInitializer(string name)
        {
            Csharp5Name = name;  //older way to initialize the property
            Name = "Vetri";
            SetName("Swaminathan Vetri");
        }

        public void SetName(string name)
        {
            Name = name;
            Csharp5Name = name;
        }
    }
}
