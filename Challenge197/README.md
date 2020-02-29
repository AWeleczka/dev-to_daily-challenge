# Daily Challenge #197 - Population Growth

https://dev.to/thepracticaldev/daily-challenge-197-population-growth-e4p



> Thank you to [CodeWars](https://www.codewars.com/), who has licensed redistribution of this challenge under the [2-Clause BSD](https://opensource.org/licenses/BSD-2-Clause) License!  
> Thank you for [dev.to](https://dev.to/) for doing these.

---

## For my solutions of the tests given in the challenge:

```csharp
Assert.AreEqual(15, Population.NbYear(1500, 5, 100, 5000));
Assert.AreEqual(10, Population.NbYear(1500000, 2.5, 10000, 2000000));
Assert.AreEqual(94, Population.NbYear(1500000, 0.25, 1000, 2000000));
```

The results used in the tests where previously calculated using the console application so they it would be weird for them not to pass with these values ;) - they also match the ones in the original comments though.