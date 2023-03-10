using ASPWebsite.Data.Interfaces;

namespace ASPWebsite.Data.Mocks
{
    public class MockFile : IFile
    {
        private IUser _user = new MockUser();
        public IEnumerable<Models.File> AllFiles
        {
            get
            {
                return new List<Models.File>
                {
                    new Models.File { Id = 0, Size = 3.14, Name = "Top secret.txt", DateTime = "10.03.2023", User_id = _user.AllUsers.First().Id },
                    new Models.File { Id = 1, Size = 6.28, Name = "Cats.zip", DateTime = "11.09.2001", User_id = _user.AllUsers.Last().Id }
                };
            }
        }
    }
}
