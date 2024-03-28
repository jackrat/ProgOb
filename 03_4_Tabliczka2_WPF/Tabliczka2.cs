using System.ComponentModel;
using System.Text;

namespace _03_2_Tabliczka
{
  public class Tabliczka2 : INotifyPropertyChanged
  {
    public int Row1 { get => row1; set { row1 = value; Wyznacz(); OnPropertyChanged("Row1"); } }
    private int row1;
    public int Row2 { get => row2; set { row2 = value; Wyznacz(); OnPropertyChanged("Row2"); } }
    private int row2;
    public int Col1 { get => col1; set { col1 = value; Wyznacz(); OnPropertyChanged("Col1"); } }
    private int col1;
    public int Col2 { get => col2; set { col2 = value; Wyznacz(); OnPropertyChanged("Col2"); } }
    private int col2;

    public string Wynik
    {
      get => wynik; 
      set
      {
        wynik = value;
        OnPropertyChanged("Wynik");
      }
    }
    private string wynik;

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string pn)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(pn));
    }

    private void Wyznacz()
    {
      StringBuilder sb = new StringBuilder();
      for (int i = row1; i <= row2; i++)
      {
        for (int j = col1; j <= col2; j++)
          sb.Append($"{i * j,5}");
        sb.AppendLine();
      }
      sb.ToString();
      Wynik = sb.ToString();
    }

  }
}
