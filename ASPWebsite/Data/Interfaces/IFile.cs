namespace ASPWebsite.Data.Interfaces
{
    public interface IFile
    {
        IEnumerable<Models.File> AllFiles { get; }
    }
}
