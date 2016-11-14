// Directorul ar putea fi mai interesant... 

public class Director : Om
{
    public string Nume {get; set;}
    public string Prenume {get; set;}
    public int Varsta {get; set;}
    public string NumarTelefon {get; set;}
    public int CNP {get; set;}

    public Director(string nume, string prenume, int varsta, string numarTelefon, int cnp)
    {
        Nume = nume;
        Prenume = prenume;
        Varsta = varsta;
        NumarTelefon = numarTelefon;
        CNP = cnp;
    }
}