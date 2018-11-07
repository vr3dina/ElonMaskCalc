namespace EM.Calc.DB
{
    public class UserRepository : BaseRepository<Users>
    {
        public UserRepository(string connection) : base(connection)
        {
        }

        //public override string TableName { get => "Users"; }
        //public override string Fields { get => "Login, BirthDay, Sex"; }
    }
}