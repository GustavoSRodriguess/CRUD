class Tela2
{
    public void montarPokedex()
    {
        Console.WriteLine(@" ________  ________  ___  __    _______   ________  _______      ___    ___ ");
        Console.WriteLine(@"|\   __  \|\   __  \|\  \|\  \ |\  ___ \ |\   ___ \|\  ___ \    |\  \  /  /|");
        Console.WriteLine(@"\ \  \|\  \ \  \|\  \ \  \/  /|\ \   __/|\ \  \_|\ \ \   __/|   \ \  \/  / /");
        Console.WriteLine(@" \ \   ____\ \  \\\  \ \   ___  \ \  \_|/_\ \  \ \\ \ \  \_|/__  \ \    / / ");
        Console.WriteLine(@"  \ \  \___|\ \  \\\  \ \  \\ \  \ \  \_|\ \ \  \_\\ \ \  \_|\ \  /     \/  ");
        Console.WriteLine(@"   \ \__\    \ \_______\ \__\\ \__\ \_______\ \_______\ \_______\/  /\   \  ");
        Console.WriteLine(@"    \|__|     \|_______|\|__| \|__|\|_______|\|_______|\|_______/__/ /\ __\ ");
        Console.WriteLine(@"                                                                |__|/ \|__| ");
    }

    public void montarMoldura(int ci, int li, int cf, int lf)
    {
        int col, lin;
        //this.limparArea(ci,li,cf,lf);

        // desenha as linhas horizontais
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("-");
            Console.SetCursorPosition(col, lf);
            Console.Write("-");
        }

        // desenha as linhas verticais
        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("|");
            Console.SetCursorPosition(cf, lin);
            Console.Write("|");
        }

        // "arruma" os cantos
        Console.SetCursorPosition(ci, li); Console.Write("/");
        Console.SetCursorPosition(ci, lf); Console.Write(@"\");
        Console.SetCursorPosition(cf, li); Console.Write(@"\");
        Console.SetCursorPosition(cf, lf); Console.Write("/");
    }


     public string mostrarMenu(int ci, int li, List<string> opcoes)
    {
        string op;
        int col, lin, cf, lf;

        lf = li + opcoes.Count + 2;
        cf = ci + opcoes[0].Length + 1;
        this.montarMoldura(ci,li,cf,lf);

        col = ci + 1;
        lin = li + 1;
        foreach(string item in opcoes)
        {
            Console.SetCursorPosition(col,lin);
            Console.Write(item);
            lin ++;
        }
        Console.SetCursorPosition(col,lin);
        Console.Write("Opcao : ");
        op = Console.ReadLine();

        return op;
    }



}