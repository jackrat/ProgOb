using System;
using System.Text;
using System.Windows.Forms;

namespace _12_Exceptions
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int a;
      int b;
      if (int.TryParse(textBox1.Text, out a))
      {
        if (int.TryParse(textBox2.Text, out b))
        {
          if (b != 0)
          {
            int c = a / b;
            label1.Text = string.Format("a/b = {0}", c);
          }
          else
            MessageBox.Show("Ja przez zero nie dzielę!!");
        }
        else
          MessageBox.Show("Coś ty wpisał jako B???");
      }
      else
        MessageBox.Show("Coś ty wpisał jako A???");
    }


    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        int a = int.Parse(textBox1.Text);
        int b = int.Parse(textBox2.Text);
        int c = a / b;
        label1.Text = string.Format("a/b = {0}", c);
      }
      catch (Exception exc)
      {
        if (exc is FormatException)
          MessageBox.Show("Coś ty wpisał");
        else
          if (exc is DivideByZeroException)
          MessageBox.Show("Ja przez zero nie dzielę!!");
        else
          MessageBox.Show("Jakiś błąd!\r\n" + exc.Message +"\r\n"+ exc.StackTrace);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      try
      {
        int a = int.Parse(textBox1.Text);
        int b = int.Parse(textBox2.Text);
        int c = a / b;
        label1.Text = string.Format("a/b = {0}", c);
      }
      catch (FormatException exc)
      { MessageBox.Show("Coś ty wpisał"); }
      catch (DivideByZeroException exc)
      { MessageBox.Show("Ja przez zero nie dzielę!!"); }
      catch (Exception exc)
      { MessageBox.Show("Jakiś błąd!\r\n" + exc.Message); }
      finally
      {
        MessageBox.Show("To jest w finally!");
      }
    }


    private void button6_Click(object sender, EventArgs e)
    {

      try
      {
        int a;
        try
        {
          a = int.Parse(textBox1.Text);
          int b;
          try
          {
            b = int.Parse(textBox2.Text);
            int c;
            try
            {
              c = a / b;
              label1.Text = string.Format("a/b = {0}", c);
            }
            catch (DivideByZeroException exc)
            {
              MessageBox.Show("Ja przez zero nie dzielę!!");
            }
          }
          catch (FormatException fe)
          {
            MessageBox.Show("Coś ty wpisał");
          }
        }
        catch (FormatException fe)
        {
          MessageBox.Show("Coś ty wpisał");
        }
      }
      catch (Exception exc)
      { MessageBox.Show("Jakiś błąd!\r\n" + exc.Message); }
      finally
      {
        MessageBox.Show("To jest w finally!");
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Exception iexc = new Exception("To jest inner");
      Exception exc = new Exception("To jest BŁĄD nasz osobisty!", iexc);
      throw exc;
    }


    int a(int x, int y)
    {
      int w = 0;
      try
      {
        w = b(x, y);
      }
      catch (Exception exc)
      {
        string s = "To jest w a \r\n" + exc.Message;
        MessageBox.Show(s);
        Exception exc2 = new Exception(s, exc);
        throw exc2;
      }
      return w;
    }

    int b(int a, int b)
    {
      int w = 0;
      try
      {
        w = c(a, b);
      }
      catch (Exception exc)
      {
        string s = "To jest w b \r\n" + exc.Message;
        MessageBox.Show(s);
        Exception exc2 = new Exception(s, exc);
        throw exc2;
      }
      return w;
    }

    int c(int a, int b)
    {
      int w = 0;
      try
      {
        throw new Exception("ORYGINALNY BŁĄD!");
        w = a / b;
        return w;
      }
      catch (Exception exc)
      {
        string s = "To jest w c \r\n" + exc.Message;
        MessageBox.Show(s);
        Exception exc2 = new Exception(s, exc);
        throw exc2;
      }
      return w;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      int la = int.Parse(textBox1.Text);
      int lb = int.Parse(textBox2.Text);

      try
      {
        int wyn = a(la, lb);
        label1.Text = wyn.ToString();
      }
      catch (Exception exc)
      {
        label1.Text = "???";
        MessageBox.Show("Błąd " + exc.Message);
        StringBuilder sb = new StringBuilder();
        analizuj(sb, exc, "");
        MessageBox.Show(sb.ToString());
      }
    }

    private void analizuj(StringBuilder sb, Exception exc, string tabs)
    {
      sb.AppendLine(tabs + "To jest błąd typu: " + exc.GetType().Name);
      sb.AppendLine(tabs + exc.Message);
      sb.AppendLine(tabs + exc.StackTrace);
      if (exc.InnerException != null)
      {
        sb.AppendLine(tabs + "To nie koniec - zagłębiamy się dalej...");
        tabs += "\t";
        analizuj(sb, exc.InnerException, tabs);
      }
    }

   
  }
}
