namespace ASPWebsite.Data.Interfaces
{
    public interface IUser
    {
        IEnumerable<Models.User> AllUsers { get; }
        Models.User getUser(int id);
    }
}
