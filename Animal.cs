namespace FourthAssignmentCSharp
{
    class Animal
    {
        public string typeAnimal { get; set; }
        public string color { get; set; }
        public int age { get; set; }
        public Animal()
        {
            typeAnimal = "";
            color = "";
            age = 0;
        }
        public Animal(string type)
        {
            this.typeAnimal = type;
            color = "";
            age = 0;
        }
        public Animal(string type, string color, int age)
        {
            this.typeAnimal = type;
            this.color = color;
            this.age = age;
        }
    }
}