public class Scripture
{
   
    //private List<>
    //private List<string> scripture_list()
    private string _scripture;
    private List<Word> _words = new List<Word>();
    //private List<Word> _scripture = new List<Word>();

    public Scripture(string scripture_1)
    {
        //_scripture = "Daryl stop hitting the Griddy in front of the Walkers.";
        _scripture = scripture_1;
        //string[] _word_list = _scripture.Split(" ");
       
    }

    
    public void AddWord(Word w)
    {
        _words.Add(w);
    }

    public void Display_Scrip()
    {
        Console.WriteLine(_scripture);

    }

    private string _broken_scrip;
  

}