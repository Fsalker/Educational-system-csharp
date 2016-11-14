//  Fiecare Liceu are: Nume / Adresa / Director / Clase / Profesori
using System.Collections.Generic;

public class Liceu
{
    public string NumeLiceu {get; set;}
    public string Adresa {get; set;}
    public Director DirectorLiceu {get; set;}
    public Profesor[] Profesori {get; set;}
    public List<Clasa> Clase {get; set;}

    public Liceu(string numeLiceu, string adresa, Director directorLiceu, Profesor[] profesori, List<Clasa> clase)
    {
        NumeLiceu = numeLiceu;
        Adresa = adresa;
        DirectorLiceu = directorLiceu;
        Profesori = profesori;
        Clase = clase;
    }
    public void AdaugaClasa(Clasa clasa)
    {
        Clase.Add(clasa);
    }
    public void ScoateClasaDupaNume(string nume)
    {
        Clase.RemoveAll(a => a.NumeClasa == nume);
    }
}