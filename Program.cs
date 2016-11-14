/*
======================================
SCHEMA CLASELOR (TOP to BOTTOM)

    Bucuresti
        |
    []Sector
        |
    []Liceu --- Director (Om) & []Profseor (Om) 
        |
    []Clasa --- []Elev (Om), []Profesor (Om)
        
    interface Om

======================================
TERMINOLOGIE
    Elev (Om) == public class Elev implements Om
    
    Liceu --- Director (Om) ==  Liceu base class, Director derived class

    Liceu
      | 
    Clasa == Liceu base class, Clasa derived class  

======================================
TO-DO
    Baza de date

======================================
*/

using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Elev> Elevi = new List<Elev>();
            Elevi.Add(new Elev("Popescu", "Alex", 15, "0729128412", 8.28));

            List<Sector> Sectoare = new List<Sector>();
            for(int i=0; i<6; ++i) Sectoare.Add(new Sector());

            Bucuresti Bucurica = new Bucuresti(Sectoare);

            Console.WriteLine("Hello "+Bucurica.Nume+"\n");
            try 
            {
                for(int i=0; i<6; ++i) Console.WriteLine(Bucurica.Sectoare[i].NumeSector);
            }
            catch (NullReferenceException e)
            {
                    Console.WriteLine("Eroare: Poate n-ai initializat o variabila [NullReferenceException]");
                    Console.WriteLine("\n"+e+"\n");
            } 
        }
    }
}
