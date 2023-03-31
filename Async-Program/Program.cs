namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Task chiefGuest = PickUpChiefGuest();
        DecorateStage();
        DropOffRawMaterials();
        CheckSecurity();
        Task BringPrize = BringPrizes();
        Task.WaitAll(BringPrize, chiefGuest);
        
        //ProvideFood();
        Console.ReadLine();
    }
    static async Task PickUpChiefGuest()
    {
        Console.WriteLine("Picking cief guest task started");
        await Task.Delay(10000);
        Console.WriteLine("Chief guest has arrived");
        ReviewSpeech();
    }
    static async Task DecorateStage()
    {
        Console.WriteLine("Decorating stage task started");
        await Task.Delay(5000);
        Console.WriteLine("Stage has been decorated");
    }
    static async Task PrepareFood()
    {
        Console.WriteLine("Food preparation started");
        await Task.Delay(20000);
        Console.WriteLine("Food preparation ended");
    }

    static async Task DropOffRawMaterials()
    {
        Console.WriteLine("Rawmaterial droppoff started");
        await Task.Delay(2000);
        Console.WriteLine("Rawmaterial droppoff ended");
        Task prepareFood = PrepareFood();
        Task.WaitAll(prepareFood);
        ProvideFood();
    }

    static async Task ReviewSpeech()
    {
        Console.WriteLine("Speech is being reviewed");
        await Task.Delay(2000);
        Console.WriteLine("Speech reviewed successfully");
        Task giveSpeech = GiveSpeech();
        Task.WaitAll(giveSpeech);
        DistributePrizes();
    }

    static async Task CheckSecurity()
    {
        Console.WriteLine("Security checking is going on");
        await Task.Delay(28000);
        Console.WriteLine("Security check is completed");
    }

    static async Task BringPrizes()
    {
        Console.WriteLine("Prize is bringing up to the venue");
        await Task.Delay(3000);
        Console.WriteLine("Prize has been bought up to the venue");
    }

    static async Task GiveSpeech()
    {
        Console.WriteLine("Speech started");
        await Task.Delay(5000);
        Console.WriteLine("Speech has ended");
    }

    static async Task DistributePrizes()
    {

        Console.WriteLine("Prize distribution started");
        await Task.Delay(15000);
        Console.WriteLine("Prize distribution ended");
    }

    static async Task ProvideFood()
    {
        Console.WriteLine("Food is being provided");
    }
}