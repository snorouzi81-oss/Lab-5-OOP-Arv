namespace Lab_5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Sima", 35);
            Lion lion = new Lion("Simba", 5);
            Elephant elephant = new Elephant("Dumbo", 10);
            Dog dog = new Dog("Bobby", 3 , "breed");
            Bulldog bulldog = new Bulldog("Rocky", 5);
            Chihuahua chihuahua = new Chihuahua("Lulu", 2);
            Snake snake = new Snake("Kaa", 5);
            Penguin penguin = new Penguin("Pingo", 4);

            human.MakeSound();
            human.Talk();

            elephant.MakeSound();
            elephant.SprayWater();

            lion.MakeSound();
            lion.Hunt();

            dog.MakeSound();
            dog.Fetch();
            bulldog.MakeSound();
            bulldog.Snore();
            bulldog.Fetch();
            chihuahua.MakeSound();
            chihuahua.BarkLoudly();

            snake.MakeSound();
            snake.Slither();

            penguin.MakeSound();
            penguin.Swim();

        }
    }
}
