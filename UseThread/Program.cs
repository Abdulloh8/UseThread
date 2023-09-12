

using UseThread.Classes;
using UseThread.Entity;

var value = new EnterValue();
var see = new inspection();
var student = new Student(); 



student = value.Create();

await see.See(student);

Console.ReadKey();


