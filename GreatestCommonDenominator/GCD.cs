// Algorithms and Data Structures (AlgosDS)
/// <summary>
/// Find the greadtest common denominator (GCD)
/// </summary>
public class GCD
{
  public GCD()
  {

  }
  /// <summary>
  /// Find the greatest common denominator (GCD)
  /// </summary>
  /// <param name="numOne">numOne is greater than numTwo</param>
  /// <param name="numTwo">smaller number</param>
  /// <returns>returns the GCD</returns>
  public int FindGCD(int numOne, int numTwo)
  {
    while (numTwo != 0)
    {
      int temp = numOne;
      numOne = numTwo;
      numTwo = temp % numTwo;
    }

    return numOne;
  }
}
