namespace GitExercise
{
    class myClass
    {
    private string _navn;         
    private string _addresse;        
     private int _postNr;       
    private string _by;          
    
    
    public myClass2 (string Navn, string Addresse, string By, int PostNr)         
    {
        _navn = Navn;            
        _addresse = Addresse;            
        _postNr = PostNr;            
        _by = By;         
    }
    public int PostNr { get => _postNr; set => _postNr = value; }         
    public string Addresse { get => _addresse; set => _addresse = value; }        
    public string Navn { get => _navn; set => _navn = value; }       
    public string By { get => _by; set => _by = value; }         
              
    public override string ToString()         {return $"{Navn}'s addresse er {Addresse} i {By} med postNr {PostNr}"; }
        

    
}