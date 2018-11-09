namespace EM.Calc.DB
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(string connection) : base(connection, "Users")
        {
        }
    }
}