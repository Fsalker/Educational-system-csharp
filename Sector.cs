// Sectoarele sunt putin mai deosebite, doar ca sa experimentez cu variabilele statice

//  Fiecare Sector are: Numar / Nume / Licee
// Numele = "Sector" + NrSectoare [static]
using System.Collections.Generic;
public class Sector
{
    public static int NrSectoare = 0;
    public int NumarSector {get; set;} // FIXME?: poate n-ar trebui sa set-ez oriunde :) (valabil pt orice get; set;)
    public string NumeSector {get; set;}
    public List<Liceu> Licee {get; set;}

    public Sector()
    {
        ++NrSectoare;
        NumarSector = NrSectoare;
        NumeSector = "Sector "+NumarSector;
    }

    public void AdaugaLiceu(Liceu lic)
    {
        Licee.Add(lic);
    }
    public void ScoateLiceuDupaNume(string nume)
    {
        Licee.RemoveAll(a => a.NumeLiceu == nume);
    }
}