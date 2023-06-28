using System;
using System.Diagnostics;

//ref link:https://www.youtube.com/watch?v=o4GRN_3ulNw&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=14
//

/*class Cow
{
    public string Name { [DebuggerStepThrough] get { return "Bessy"; } }
    public int Age { get { return 5;} }      // Tools > Options > Debugging General > Disable Step over properties and operators(Managed only)
}

class MainClass
{
    static void Main()
    {
        var cow = new Cow();
        EyeCowForButchering(cow.Name, cow.Age); // Tools > Options > Debugging General > Enable Step over properties and operators(Managed only)
    }
    static void EyeCowForButchering(string name, int age)
    {
        Console.WriteLine(name + " " + age);
    }
}*/
// ctrl kb (code snippet shortcut key)

class MainClass
{
    static void Main()
    {
        FirstMethod();
    }
    static void FirstMethod()
    {
        SecondMethod();
    }
    //[DebuggerStepThrough]
    [DebuggerHidden]
    static void SecondMethod()
    {
        Console.WriteLine("Second method from the past......");
        ThirdMethod();
    }
    static void ThirdMethod()
    {

    }
}