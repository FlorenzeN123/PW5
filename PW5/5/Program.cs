
List<IAnimal> myAnimals = new List<IAnimal>();

myAnimals.Add(new Dog());
myAnimals.Add(new Cat());
myAnimals.Add(new Owl());
myAnimals.Add(new Wolf());
myAnimals.Add(new Snake());

foreach (IAnimal animal in myAnimals)
{
    animal.Voice();
}


Console.ReadKey(true);




static void PetAnimal(IAnimal animal)
{
    Console.WriteLine("Мы гладим зверушку, а она нам говорит: ");
    animal.Voice();

}





interface IAnimal
{
    void Voice();
}


class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав!");
    }
}
class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу!");
    }
}
class Owl : IAnimal
{
    private int GetCurrentTime()
    {
        return Convert.ToInt32(File.ReadAllText("current_time.txt"));
    }
    public void Voice()
    {
        int currentTime = GetCurrentTime();

        if ((currentTime >= 8) && (currentTime <= 21))
        {
            Console.WriteLine("Тисе, я сплю");
        }
        else
        {
            Console.WriteLine("УХ! УХ! УХ!");
        }
    }
}
class Wolf : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Работа не волк! Волк это ходить(ауф)");
    }
}
class Snake : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("KABAN(hruuuuuuuuuuuuuuuu)");
    }
}
