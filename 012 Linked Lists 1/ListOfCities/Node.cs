namespace ListOfCities
{
    class Node
    {
        // Data
        public City City { get; private set; }
        public Node Next { get; set; }

        // ctor
        public Node(City city)
        {
            City = city;
        }

        public override string ToString()
        {
            return City.Name;
        }
    }
}
