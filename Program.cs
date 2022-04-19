using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 

      Rover[] Rovers = new Rover[]{lunokhod, apollo, sojourner};
      // DirectAll(Rovers);

      Object[] oprobes = new Object[]{lunokhod, apollo, sojourner, sputnik};

      // foreach (Object obj in probes){
      //   Console.WriteLine(obj.GetType());
      // }

      IDirectable[] iprobes = new IDirectable[]{lunokhod, apollo, sojourner, sputnik};

      DirectAll(iprobes);
      
      

  		
    }

    static void DirectAll(IDirectable[] rovers){
      foreach(IDirectable rover in rovers){
        Console.WriteLine(rover.GetInfo());
        Console.WriteLine(rover.Explore());
        Console.WriteLine(rover.Collect());

      }
    }
  }
}
