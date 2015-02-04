# NCalc
This is a port of the [CodePlex NCalc](http://ncalc.codeplex.com/) project.

Changes with this version:

 - Ported project to Visual Studio 2013
 - Added a SUM built in function
   - usage: 

```C#
        var expr = new Expression("sum([vals]) + 10");
        expr.Parameters.Add("vals", new List<int>{ 1, 2, 3, 4, 5 });
        var result = expr.Evaluate();  \\Output = 25
```