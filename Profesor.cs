

public class Profesor : Om
{
    public string Nume {get; set;}
    public string Prenume {get; set;}
    public int Varsta {get; set;}
    public string NumarTelefon {get; set;}
    public int CNP {get; set;}
    public string Materie {get; set;}
    public double Rating {get; set;}

    public Profesor(string nume, string prenume, int varsta, string numarTelefon, int cnp, string materie, double rating)
    {
        Nume = nume;
        Prenume = prenume;
        Varsta = varsta;
        NumarTelefon = numarTelefon;
        CNP = cnp;
        Materie = materie;
        Rating = rating;
    }
}