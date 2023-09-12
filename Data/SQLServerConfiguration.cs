namespace DesafioDotNET.Data
{
    public class SQLServerConfiguration
    {
        public readonly string SQLConnectionString;
        public SQLServerConfiguration( string SQLConnectionString ) {
            this.SQLConnectionString = SQLConnectionString;
        }
    }
}
