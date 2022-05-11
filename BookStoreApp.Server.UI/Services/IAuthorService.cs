using BookStoreApp.Server.UI.Services.Base;

namespace BookStoreApp.Server.UI.Services
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorReadOnlyDto>>> GetAuthors();
    }
}