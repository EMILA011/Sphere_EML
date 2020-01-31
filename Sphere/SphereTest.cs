/**
 * This class tests the Sphere class.
 * @author Elena Milan Lopez
 * @version 1.0
 * Project 1 -Solution
 * SP20
 */

using System;

namespace Sphere
{
     class SphereTest
     {
          static void Main(string[] args)
          {
               Sphere sp1 = new Sphere();
               Sphere sp2 = new Sphere(5);

               sp1.setDiameter(3);

               double sp1diameter =  sp1.getDiameter();
               double sp1volume = sp1.getVolume();
               double sp1surfacearea = sp1.getSurfaceArea();

               Console.WriteLine(sp1.toString());
               Console.WriteLine(sp2.toString());

               Console.WriteLine("Sphere1 diameter: " + sp1diameter);
               Console.WriteLine("Sphere2 diameter: " + sp2.getDiameter());

               Console.WriteLine("Sphere1 volume: " + sp1volume);
               Console.WriteLine("Sphere2 volume: " + sp2.getVolume());

               Console.WriteLine("Sphere1 surface area: " + sp1surfacearea);
               Console.WriteLine("Sphere2 surface area: " + sp2.getSurfaceArea());


          }
     }
}
