using System.Diagnostics;
using System.Text;

// Q1 - create a class based on the data given 
public class Downpat
{
    public string s1="";
    public string s2="";
    public Downpat(string x, string y)
    {
        s1=x;
        s2=y;
    }
}
class Program
{
    static string reverse(string s)
    {
        StringBuilder sb=new StringBuilder();
        for(int i = s.Count() - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
    static bool is_before(string s, string l)
    {
        foreach(char C in s)
        {
            foreach(char c in l)
            {
                if (C < c)
                {
                    return false;
                }
            }
        }
        return true;
    }
    static bool is_pat(string s)
    {
        if (s.Count() == 1)
        {
            return true;
        }
        else
        {
            for(int i = 0; i < s.Count()-1; i++)
            {
                StringBuilder left=new StringBuilder();
                StringBuilder right=new StringBuilder();
                for(int j = 0; j <= i; j++)
                {
                    left.Append(s[j]);
                }
                for(int j = i + 1; j < s.Count(); j++)
                {
                    right.Append(s[j]);
                }
                //Console.WriteLine(left.ToString()+" "+right.ToString());
                if (is_pat(reverse(left.ToString()))&&is_pat(reverse(right.ToString()))&&is_before(left.ToString(),right.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
    static void Main()
    {
        Downpat dp=new Downpat("DE", "C");
        if (is_pat(dp.s1)){Console.WriteLine("YES");}
        else{Console.WriteLine("NO");}

        if (is_pat(dp.s2)){Console.WriteLine("YES");}
        else{Console.WriteLine("NO");}

        if (is_pat(dp.s1+dp.s2)){Console.WriteLine("YES");}
        else{Console.WriteLine("NO");}
    }
}
//b:CDAB
