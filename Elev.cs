public class Elev : Om
{
    public string Nume {get; set;}
    public string Prenume {get; set;}
    public int Varsta {get; set;}
    public string NumarTelefon {get; set;}
    public int CNP {get; set;}
    public double MedieAdmitere {get; set;}

    public Elev(string nume, string prenume, int varsta, string numarTelefon, int cnp, double medieAdmitere)
    {
        Nume = nume;
        Prenume = prenume;
        Varsta = varsta;
        NumarTelefon = numarTelefon;
        CNP = cnp;
        MedieAdmitere = medieAdmitere;
    }
}