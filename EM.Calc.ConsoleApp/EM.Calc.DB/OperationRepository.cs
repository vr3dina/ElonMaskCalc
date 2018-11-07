namespace EM.Calc.DB
{
    public class OperationRepository : BaseRepository<Operation>
    {
        public OperationRepository(string connection) : base(connection)
        {
        }

        //public override string Fields { get => "Name, Rating"; }

        //public override string TableName { get => "Operation"; }

    }
}
