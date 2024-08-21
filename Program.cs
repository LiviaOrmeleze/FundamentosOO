using Fundamentos;

internal class Program
{

    private static void Main(string[] args)
    {
        /*
        Livro livro1 = new Livro();
        livro1.Titulo = "História de uma alma";
        livro1.Editora = "Minha Biblioteca Católica";
        livro1.Autor = "Santa Teresinha do Menino Jesus";
        livro1.AnoLancamento = 2018;

        Livro livro2 = new Livro();
        livro2.Titulo = "Diario de Santa Faustina";
        livro2.Editora = "Província Misericórdia";
        livro2.Autor = "Santa Irmã Maria Faustina Kowalska";
        livro2.AnoLancamento = 1982;

        Livro livro3 = new Livro();
        livro3.Titulo = "Padre Pio: um santo entre nós";
        livro3.Editora = "Paulinas";
        livro3.Autor = "Renzo Allegri";
        livro3.AnoLancamento = 1998;
        */

        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();

        aluno1.Nome = "Livia Modesto Ormeleze";
        aluno1.RM = "3776";
        aluno1.Email = "lormeleze@gmail.com";
        aluno1.Nascimento = new DateOnly(2007, 11, 27);

        aluno2.Nome = "Gabriela Siqueira Caputti";
        aluno2.RM = "4449";
        aluno2.Email = "gabrielasiqueiracaputti@gmail.com";
        aluno2.Nascimento = new DateOnly(2008, 03, 16);

        aluno3.Nome = "Bryan Martins Fusco";
        aluno3.RM = "2222";
        aluno3.Email = "ratinsemqueeijo@gmail.com";
        aluno3.Nascimento = new DateOnly(2007, 08, 09);

        Console.WriteLine("Aluno1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("E-mail: " + aluno1.Email);
        Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        Console.WriteLine("=========================================================");

        Console.WriteLine("Aluno2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("E-mail: " + aluno2.Email);
        Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        Console.WriteLine("=========================================================");

        Console.WriteLine("Aluno3");
        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("RM: " + aluno3.RM);
        Console.WriteLine("E-mail: " + aluno3.Email);
        Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        Console.WriteLine("=========================================================");

        //Instanciar um objeto de tipo Produto 
        Produto p1 = new Produto();
        p1.Codigo = 217712;
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        // Nova contidade no estoque
        p1.QuantidadeEstoque();

        Console.WriteLine("=========================================================");
        Console.WriteLine();

        //Instanciar um objeto do tipo Carro 
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("=========================================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Livia";
        pessoa1.Idade = 16;

        Console.WriteLine(pessoa1.Nome);
        Console.WriteLine(pessoa1.Idade);
        pessoa1.Envelhecer(10);
        pessoa1.Envelhecer(10);
        pessoa1.Envelhecer(10);

        Console.WriteLine("=========================================================");
        Console.WriteLine();

        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Jubiscreudo";
        funcionario1.Idade = 40;
        funcionario1.Cargo = "Empresário";
        funcionario1.Salario = 15000;

        funcionario1.ApresentarSe();

        Console.WriteLine("=========================================================");
        Console.WriteLine();


        //Animal animal1 = new Animal();

        //animal1.Especie = "Cachorro";
        //animal1.emitirSom();
        //Console.WriteLine("O animal " + animal1.Especie + "Emitiu um som");

        Cat cat = new Cat();
        cat.Nome = "Jeferson";
        Console.WriteLine(cat.Nome + " faz: ");
        cat.emitirSom();
        Console.WriteLine();

        Porco porco = new Porco();
        porco.Nome = "Rabicó";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();

        Console.WriteLine();
        Galinha galinha = new Galinha();
        galinha.Nome = "Pintadinha";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();

        Console.WriteLine("=========================================================");
        Console.WriteLine();

        Mago mago = new Mago();
        mago.Nome = "Mestre gogo";
        mago.Nivel = 9;
        mago.Vida = 1200;
        mago.Forca = 80;
        mago.Inteligencia = 98;
        mago.Agilidade = 67;

        Elfo elfo = new Elfo();
        elfo.Nome = "Aurion";
        elfo.Vida = 1150;
        elfo.Inteligencia = 83;
        elfo.Forca = 56;
        elfo.Agilidade = 90;
        elfo.Nivel = 7;


        mago.apresentarSe();
        elfo.apresentarSe();

        Console.WriteLine("======================================================");
        Console.WriteLine();

        mago.batalhar(elfo);


    }

}