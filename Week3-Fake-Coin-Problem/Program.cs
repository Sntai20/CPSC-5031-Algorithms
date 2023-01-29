class MainClass
{
    public static void Main()
    {
        int numberOfCoins = 9;
        BagOfCoins bagOfCoins = new(numberOfCoins);
        bagOfCoins.FindFakeCoin(bagOfCoins.arrayOfCoins);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

/// <summary>
/// Simple coin class with two properties Weight and Postion.
/// </summary>
public class Coin
{
    public double Weight { get; set; }
    public int Position { get; set; }

    public override string ToString() => $"{this.Position} {this.Weight}";

    public Coin(double weight, int position)
    {
        this.Weight = weight;
        this.Position = position;
    }
}

/// <summary>
/// A simple "Bag of Coins" class to create an array/bag of coins. This class creates
/// an array full of real coins, then randomly sets one of the coins to be a fake coin.
///
/// The BagOfCoins constructor accepts the total number of coins to generate.
/// The FindFakeCoin() method finds the position of the Fake Coin in an array of coins.
/// The CompareCoins() method compares the weight of two bags(arrays) of coins.
/// The DisplayCoinInfo() method prints the coins information
/// </summary>
public class BagOfCoins
{
    private const double fakeCoinWeight = 0.01;
    private const double realCoinWeight = 0.02;
    public Coin[] arrayOfCoins;

    /// <summary>
    /// BagOfCoins Constructor.
    /// </summary>
    /// <param name="numberOfCoins">The total number of coins to generate.</param>
    public BagOfCoins(int numberOfCoins)
    {
        // Create an array full of real coins.
        Coin[] randomArrayOfCoins = new Coin[numberOfCoins];
        for (int i = 0; i < randomArrayOfCoins.Length; i++)
        {
            randomArrayOfCoins[i] = new Coin(realCoinWeight, i);
        }

        // Create a random position in the array to set the fake coin.
        Random randomNumber = new();
        double positionOfFakeCoinAsADouble = numberOfCoins * randomNumber.NextDouble();

        // Use the int value of the double as the position for the fake coin.
        int positionOfTheFakeCoin = ((int)positionOfFakeCoinAsADouble);

        // Set the fake coin.
        randomArrayOfCoins[positionOfTheFakeCoin].Weight = fakeCoinWeight;
        Console.WriteLine($"Setting the fake coin to position {positionOfTheFakeCoin}");

        // Store the array of coins.
        this.arrayOfCoins = randomArrayOfCoins;
    }

    /// <summary>
    /// Finds the position of the Fake Coin in an array of coins.
    /// </summary>
    /// <param name="arrayOfCoins">The array of coins to search through.</param>
    /// returns true if the coin is found, otherwise returns false.
    public bool FindFakeCoin(Coin[] arrayOfCoins)
    {
        bool IsFakeCoinFound = false;

        if (this.arrayOfCoins.Length == 0)
        {
            Console.WriteLine($"Is Fake coin found? {IsFakeCoinFound}");
            return IsFakeCoinFound;
        }
        else if (this.arrayOfCoins.Length == 1)
        {
            IsFakeCoinFound = true;
            Console.WriteLine($"Is Fake coin found? {IsFakeCoinFound} Position {arrayOfCoins[0].ToString()}");
            return IsFakeCoinFound;
        }
        else
        {
            bool oddNumCoins = arrayOfCoins.Length % 2 == 1;
            //int third = arrayOfCoins.Length / 3;

            Coin[] leftCoins = new Coin[9];
            Coin[] middleCoins = new Coin[9];
            Coin[] rightCoins = new Coin[9];

            for (int i = 0; i < arrayOfCoins.Length; i++)
            {
                leftCoins.SetValue(arrayOfCoins[i], i);
                middleCoins.SetValue(arrayOfCoins[i], i);
                rightCoins.SetValue(arrayOfCoins[i], i);
            }
           
            //Array.Copy(arrayOfCoins, leftCoins, arrayOfCoins.Length - 1);
            //Array.Copy(arrayOfCoins, middleCoins, arrayOfCoins.Length - 1);
            //Array.Copy(arrayOfCoins, rightCoins, arrayOfCoins.Length - 1);

            int result = CompareCoins(leftCoins, middleCoins);
            if (result == 0)
            {
                //DisplayCoinInfo(rightCoins);
                return FindFakeCoin(rightCoins);
            }
            else if (result == 1)
            {
                //DisplayCoinInfo(leftCoins);
                return FindFakeCoin(leftCoins);
            }
            else if (result == -1)
            {
                //DisplayCoinInfo(middleCoins);
                return FindFakeCoin(middleCoins);
            }
            else if (oddNumCoins)
            {
                Console.WriteLine("Arrays are not even.");
                return IsFakeCoinFound;
            }
            else
            {
                Console.WriteLine($"End of the Array. Is Fake coin found? {IsFakeCoinFound}");
                return IsFakeCoinFound;
            }
        }
    }

    /// <summary>
    /// Compares the weight of two bags(arrays) of coins.
    /// </summary>
    /// <param name="leftArrayOfCoins">The set of coins to be placed on the left balance pan.</param>
    /// <param name="rightArrayOfCoins">The set of coins to be placed on the right balance pan.</param>
    /// <returns>
    /// -1 means the left pan is heavier.
    ///  0 means the pans have equal weight.
    ///  1 means the right pan is heavier.
    /// </returns>
    private static int CompareCoins(Coin[] leftArrayOfCoins, Coin[] rightArrayOfCoins)
    {
        double leftWeight = 0.0;
        double rightWeight = 0.0;

        if (leftArrayOfCoins.Length != rightArrayOfCoins.Length)
        {
            Console.WriteLine("The arrays are not equal in length.");
            Console.WriteLine($"Left Weight: {leftWeight} Right Weight: {rightWeight}");
        }
        
        foreach (var coin in leftArrayOfCoins)
        {
            leftWeight = leftWeight + coin.Weight;
            Console.WriteLine($"Left Array of coings {coin}");
        }

        foreach (var coin in rightArrayOfCoins)
        {
            rightWeight += coin.Weight;
        }

        Console.WriteLine($"Left Weight: {leftWeight} Right Weight: {rightWeight}");
        if (leftWeight < rightWeight)
        {
            Console.WriteLine($"Left Weight: {leftWeight} Right Weight: {rightWeight}");
            return 1;
        }
        else if (leftWeight > rightWeight)
        {
            Console.WriteLine($"Left Weight: {leftWeight} Right Weight: {rightWeight}");
            return -1;
        }
        else
        {
            Console.WriteLine($"Left Weight: {leftWeight} Right Weight: {rightWeight}");
            return 0;
        }
    }

    /// <summary>
    /// Prints the coins information.
    /// </summary>
    /// <param name="arrayOfCoins">The set of coins to print.</param>
    private static void DisplayCoinInfo(Coin[] arrayOfCoins)
    {
        if (arrayOfCoins.Length >= 1)
        {
            int startOfArray = arrayOfCoins[0].Position;
            int endOfArray = arrayOfCoins.Length - 1;
            string message = $"Searching from {startOfArray} to {endOfArray}";
            Console.WriteLine(message);
            foreach (var coin in arrayOfCoins)
            {
                Console.WriteLine(coin.ToString());
            }
        }

        Console.WriteLine("Searching empty array");
    }
}