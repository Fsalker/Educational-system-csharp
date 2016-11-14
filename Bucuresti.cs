//  Bucuresti! In scopul realizarii acestui proiect, consideram ca nu exista alte 
// orase in afara de Bucuresti :D
//  Avem niste variabile plictisitoare + initializarea celor 6 sectoare

//    Nota:  Sectoarele sunt vectori (nu liste!). Consideram ca nu se adauga/scot 
//          sectoare :D
using System.Collections.Generic;

public class Bucuresti
{
    public string Nume;
    public string NumePrimarGeneral;
    public string Istorie;
    public List<Sector> Sectoare;

    public Bucuresti(List<Sector> sectoare)
    {
        Nume = "Bucuresti";
        NumePrimarGeneral = "Gabriela Firea";
        Istorie = "București este capitala României și, în același timp, cel mai populat oraș și cel mai important centru industrial și comercial al țării. Populația de 1.883.425 de locuitori (2011 face ca Bucureștiul să fie al zecelea oraș ca populație din Uniunea Europeană. Conform unor estimări ale unor specialiști, Bucureștiul adună zilnic peste trei milioane de oameni, iar în următorii cinci ani, acest număr va depăși patru milioane. La acestea se adaugă faptul că localitățile din preajma orașului, care vor face parte din viitoarea Zonă Metropolitană, însumează o populație de aproximativ 430.000 de locuitori.";
        Sectoare = sectoare;
    }
}