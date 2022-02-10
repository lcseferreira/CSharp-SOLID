namespace SOLID.DIP
{
    internal class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com o banco de dadaos...");
        }
    }
}