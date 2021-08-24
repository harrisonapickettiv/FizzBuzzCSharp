using System.Collections.Generic;

namespace FizzBuzzMVC.Models
{
  public class FizzBuzz
  {
    public FizzBuzz Update()
    {
      if (FizzValue != 0 && BuzzValue != 0)
      {
        List<string> fbData = new();
        for (var i = 1; i <= 100; i++)
        {
          string fb = "";
          if (i % FizzValue == 0) { fb += "Fizz"; }
          if (i % BuzzValue == 0) { fb += "Buzz"; }
          fbData.Add(fb == "" ? i.ToString() : fb);
        }
        Result = fbData;
      }
      return this;
    }
    public int FizzValue { get; set; } = 3;
    public int BuzzValue { get; set; } = 5;
    public List<string> Result { get; private set; } = new();
  }
}