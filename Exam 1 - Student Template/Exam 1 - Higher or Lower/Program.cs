namespace LargestNumberFinder {
  public class NumberProgram {
    static void Main(string[] args) {
      int counter = 0;
      int largest = -1;
      int number = 0;
      string listOfNums = "";
      for (; ; ) {
        if (counter >= 10)
          break;

        try {
          Console.Write("Enter a non-zero positive integer\n>>");
          string sNum = Console.ReadLine() ?? "";
          number = ProcessInput(sNum, ref largest);

          listOfNums += number + " ";

          counter++;
          Console.WriteLine();
        } catch (FormatException ex) {
          Console.WriteLine($"Format Exception : {ex.Message} \n");
        } catch (Exception ex) {
          Console.WriteLine($"Exception : {ex.Message} '\n'");
        }
      }

      Console.WriteLine("You entered : " + listOfNums);
      Console.WriteLine("The largest number is : " + largest);
    }

    public static int ProcessInput(string input, ref int largest) {
      int holdNum = 0;
      if (!Int32.TryParse(input, out holdNum))
        throw new FormatException("Not in the format of an int");

      if (holdNum <= 0)
        throw new Exception("Number cannot be negative or zero");

      if (holdNum > largest)
        largest = holdNum;

      return holdNum;
    }
  }
}
