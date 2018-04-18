namespace ConsoleApp1
{
    class Human
    {
        public string Name;
        public Dog BestFriend;
        public Cat Owner;

        public Human(Dog dog)
        {
            BestFriend = dog;
        }
    }
}
