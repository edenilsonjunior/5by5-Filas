namespace Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoa fila = new FilaPessoa();

            fila.Enqueue(new Pessoa("Edenilson"));
            fila.Enqueue(new Pessoa("Augusto"));
            fila.Enqueue(new Pessoa("Caua"));
            fila.Enqueue(new Pessoa("Odair"));
            fila.Enqueue(new Pessoa("Felipe"));

            Console.Write(fila.Print());


            fila.Dequeue();
            Console.Write(fila.Print());

            fila.Dequeue();
            Console.Write(fila.Print());

            fila.Dequeue();
            Console.Write(fila.Print());

            fila.Dequeue();
            Console.Write(fila.Print());

            fila.Dequeue();
            Console.Write(fila.Print());

            Console.ReadKey();
        }


        static Pessoa CriarPessoa()
        {
            Console.WriteLine("====Criar Pessoa====");
            Console.Write("Digite o nome: ");
            string? nome = Console.ReadLine();

            if (nome == null)
                return CriarPessoa();
            else
                return new Pessoa(nome);
        }

    }
}
