using System.Drawing;
using System.Runtime.CompilerServices;

Console.Title = "Constructor";

// Top-level statements, steps 6-11

Cat tigger = new Cat();

string tagT = String.Format("{0} is a {1} year old {2} cat",
    tigger.getName(),
    tigger.getAge(),
    tigger.getColor()
);

Console.Write(tagT + tigger.cry());

Cat smokey = new Cat();

smokey.setName("Smokey");
smokey.setAge(2);
smokey.setColor("Gray");


string tagS = String.Format("{0} is a {1} year old {2} cat",
    smokey.getName(),
    smokey.getAge(),
    smokey.getColor()
);

Console.WriteLine(tagS + smokey.cry());

Cat longJohnson = new Cat("Long Johnson", 12, "White and Gray", "I'm Loooong Johnson, Long Johnson!");

string tagLJ = String.Format("{0} is a {1} year old {2} cat",
    longJohnson.getName(),
    longJohnson.getAge(),
    longJohnson.getColor()
);

Console.WriteLine(tagLJ + longJohnson.cry());

Cat smellyCat = new Cat("Smelly Cat");

//smokey.setName("Smokey");
//smokey.setAge(2);
smellyCat.setColor("Orange");


string tagSC = String.Format("{0} is a {1} year old {2} cat",
    smellyCat.getName(),
    smellyCat.getAge(),
    smellyCat.getColor()
);

Console.WriteLine(tagSC + smellyCat.cry());

Console.ReadKey();


public class Cat
{
    private string name, color;
    private int age;
    private string cryNoise = "\nMeow, meow!\n";    // generic cat noise

    // Methods, steps 3-5

    public Cat()
    {
        name = "Tigger";
        age = 3;
        color = "Brown";
    }
    // can you overload constructors like Java? let's find out.
    // outcome: yes! absolutely!

    public Cat(string name)
    {
        this.name = name;
        age = 99;
        color = "Generic";
    }
    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age;
        color = "Generic";
    }
    public Cat(string name, int age, string color)
    {
        this.name = name;
        this.age = age;
        this.color = color;
    }

    public Cat(string name, int age, string color, string cry)
    {
        this.name = name;
        this.age = age;
        this.color = color;
        this.cryNoise = "\n\"" + cry + "\"\n";
    }

    public void setName(string name) { this.name = name; }
    public void setAge(int age) { this.age = age; }
    public void setColor(string color) { this.color = color; }

    public string getName() { return name; }
    public int getAge() { return age; }
    public string getColor() { return color; }

    public string cry() { return cryNoise; }
}