# NCalc
This is a port of the [CodePlex NCalc](http://ncalc.codeplex.com/) project.

[![Build status](https://ci.appveyor.com/api/projects/status/pm4q0tai6178brsw?svg=true)](https://ci.appveyor.com/project/DavidHoerster/ncalc)

[![Build status](https://ci.appveyor.com/api/projects/status/pm4q0tai6178brsw/branch/master?svg=true)](https://ci.appveyor.com/project/DavidHoerster/ncalc/branch/master)


Changes with this version:

 - Ported project to Visual Studio 2013
 - Added a SUM built in function
   - usage: 
```C#
        var expr = new Expression("sum([vals]) + 10");
        expr.Parameters.Add("vals", new List<int>{ 1, 2, 3, 4, 5 });
        var result = expr.Evaluate();  \\Output = 25
```
