// Your Program Code Here
using template_csharp_virtual_Pet;
using template_csharp_virtual_Shelter;
using template_csharp_virtual_Robot;

Console.Clear();
Console.WriteLine("Welcome to Virtual Pet!\n\nWhat is the name of your pet.");
string name = Console.ReadLine();
Console.WriteLine("What is the species of you pet.");
string species = Console.ReadLine();
Pet pet = new Pet(name, species);
Shelter shelters = new Shelter();
shelters.Pets.Add(pet);

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("Welcome to Virtual Pet!\n\n1. Create a pet\n2. Remove a pet\n3. Status\n4. Interact\n5. Swap pets \n0. Quit");
     
    int input;
    try
    {
        input = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        input = -1;
    }

    switch (input)
    {
        case -1:
            Console.Clear();
            Console.WriteLine("Please enter a numeric value from 0-3.\nPress enter to continue.");
            Console.ReadLine();
            break;
        case 0:
            isRunning = false;
            break;
        case 1:
            Console.Clear();
            Console.WriteLine("What is the name of your pet.");
            name = Console.ReadLine();
            Console.WriteLine("What is the species of you pet.");
            species = Console.ReadLine();
            Console.WriteLine("is your pet a robot?");
            if (Console.ReadLine() == "yes")
            {
                Robot r = new Robot(name, species, 100, 100);
                shelters.Pets.Add(r);
            }
            else
            {

            Pet p = new Pet(name, species);
            shelters.Pets.Add(p);
            }
            break;
        case 2:
            for (int i=0; i < shelters.Pets.Count; i++)
            {
                Console.WriteLine(i + " is your pet " + shelters.Pets[i].Name);
            }
            Console.WriteLine("Which one would you like to remove?");
            int remove = Int32.Parse(Console.ReadLine());
            shelters.Pets.RemoveAt(remove);
            break;
        case 3:
            Console.Clear();
            foreach(Pet item in shelters.Pets)
            {
                Console.WriteLine("Your pet's name is " + item.Name + "\nYour pet's species is " + item.Species + "\nYour pet's hunger is " + item.Hunger + "\nYour pet's boredom is " + item.Boredom + "\nYour pet's health is " + item.Health + "\nPress enter to continue");
            }
            break;
            Console.ReadLine();
        case 4:
            Console.Clear();
            Console.WriteLine("how would you like to interact with your pet?\n\n1. Feed\n2. Play\n3. Take to the vet");
            int inputTwo;
            try
            {
                inputTwo = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                inputTwo = 0;
            }
            switch (inputTwo)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Please enter a numeric value from 1-2.\nPress enter to continue.");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.Clear();
                    pet.Feed();
                    Console.WriteLine("Your pet's hunger is now " + pet.Hunger + "\nPress enter to continue.");
                    Console.ReadLine();
                    pet.Tick();
                    break;
                case 2:
                    Console.Clear();
                    pet.Play();
                    Console.WriteLine("Your pet's boredom is now " + pet.Boredom + "\nPress enter to continue.");
                    Console.ReadLine();
                    pet.Tick();
                    break;
                case 3:
                    Console.Clear();
                    pet.Vet();
                    Console.WriteLine("Your pet's health is now " + pet.Health + "\nPress enter to continue.");
                    Console.ReadLine();
                    pet.Tick();
                    break;
            }
            break;
        case 5:
            for (int i = 0; i < shelters.Pets.Count; i++)
            {
                Console.WriteLine(i + " is your pet " + shelters.Pets[i].Name);
            }
            Console.WriteLine("Which one would you like to remove?");
            int swap = Int32.Parse(Console.ReadLine());
            pet = shelters.Pets[swap];
            break;
    }

}