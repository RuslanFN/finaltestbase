internal class Program
{
    private static void Main(string[] args)
    {
        string fpath = "text.txt";
        int len_file = File.ReadAllLines(fpath).Length;
        StreamReader reader = new StreamReader(fpath);
        string[] old_array = new string[len_file];
        int len_res = 0;
        for (int i = 0; i < len_file; i++)
        {
            string text = reader.ReadLine();
            if (text != null) old_array[i] = text;
             
        }
        foreach (string str in old_array)
        {
            if (str.Length <= 3) len_res++;
        }
        string[] res_arr = new string[len_res];

        int ind = 0;

        foreach (string str in old_array)
        {
            if (str.Length <= 3)
            {
                res_arr[ind] = str;
                ind++;
            }

        }
        foreach (string str in res_arr) Console.Write($"{str} ");
        
    }
}