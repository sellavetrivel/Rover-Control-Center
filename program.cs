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
      //Object[] probes = {lunokhod, apollo, sojourner, sputnik};
     // foreach(Object o in probes)
      //{
      //   Console.WriteLine($"Tracking a {o.GetType()}");
      //}
  	//	Rover[] rovers = {lunokhod, apollo, sojourner, sputnik};
     // DirectAll(rovers);

      
     IDirectable[] directables = {lunokhod, apollo, sojourner, sputnik};
     DirectAll(directables);
    }
      public static void DirectAll(IDirectable[] directables)
      {
        foreach(IDirectable r in directables)
        {
          Console.WriteLine(r.GetInfo());
          Console.WriteLine(r.Explore());
          Console.WriteLine(r.Collect());
        }
      }
  }
}
