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
Shelter pets = new Shelter();
Shelter shelters = new Shelter();
shelters.Pets.Add(pet);
Robot robot = new Robot();

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
            shelters.Pets.Add(pet);
            break;
        case 2:

            break;
        case 3:
            Console.Clear();
            foreach(Pet p in pets)
            {
                Console.WriteLine("Your pet's name is " + pet.Name + "\nYour pet's species is " + pet.Species + "\nYour pet's hunger is " + pet.Hunger + "\nYour pet's boredom is " + pet.Boredom + "\nYour pet's health is " + pet.Health + "\nPress enter to continue");
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

            break;
    }

}