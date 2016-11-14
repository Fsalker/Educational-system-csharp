using System.Collections.Generic;
public class Clasa
{
    public string NumeClasa {get; set;}
    public List<Profesor> Profesori {get; set;}
    public List<Elev> Elevi {get; set;}
    public Clasa(string numeClasa, List<Profesor> profesori, List<Elev> elevi)
    {
        NumeClasa = numeClasa;
        Profesori = profesori;
        Elevi = elevi;  
    }
}