internal class Program
{
    private static void Main(string[] args)
    {
        String formula = "(2+[3-12]*{8/3})";


       

        String aperturas = "([{";
        String cierres = ")]}";
        String formulaLimpia = "";

        foreach (var item in formula)
        {
            if (aperturas.Contains(item) || cierres.Contains(item))
                formulaLimpia += item;
        }

        Stack<char> pila = new Stack<char>();


        foreach (var cadena in formulaLimpia)
        {

            if (aperturas.Contains(cadena))
            {
                pila.Push(cadena);
            }

            if (cierres.Contains(cadena))
            {
                if (pila.Count > 0) {
                    if (Corresponde( pila.Peek() , cadena))
                    {
                        pila.Pop();
                    }
                    else
                    {
                        pila.Push(cadena);
                    }
                }

            }
        }

        if (pila.Count == 0) {
            Console.WriteLine("Formula correcta");
        }
        else
        {
            Console.WriteLine("Formula incorrecta");
        }
    }

    private static bool Corresponde(char apertura, char cierre)
    {
        if((apertura == '(' &&  cierre == ')') ||
            (apertura == '{' && cierre == '}') ||
            (apertura == '[' && cierre == ']')) 
            return true;

        return false;
    }

}