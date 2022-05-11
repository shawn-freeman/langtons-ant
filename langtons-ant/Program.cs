// See https://aka.ms/new-console-template for more information
using langtons_ant;

while (true)
{
    Console.WriteLine("Enter the number of steps to move the ant:");

    int numSteps;
    while (!Int32.TryParse(Console.ReadLine(), out numSteps))
    {
        Console.WriteLine("Invalid Entry.");
        Console.WriteLine("Enter the number of steps to move the ant:");
    }


    Sim sim = new Sim();

    sim.RunSim(numSteps);
}

