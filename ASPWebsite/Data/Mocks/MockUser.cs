using ASPWebsite.Data.Interfaces;
using ASPWebsite.Data.Models;

namespace ASPWebsite.Data.Mocks
{
    public class MockUser : IUser
    {
        public IEnumerable<User> AllUsers
        {
            get
            {
                return new List<User>
                {
                    new User {Id=0, Email = "vasya@asd.com", Name = "vasya123", Password = "qwerty" },
                    new User {Id=1, Email = "345.wer@wewe.su", Name = "FakeAdmin", Password = "123456"}
                };
            }
        }

        public User getUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
