using GPTClone.Application;

namespace GPTClone.Infrastructure;

public class PromptService : IPromptService
{
    private readonly GPTCloneDbContext _dbContext;

    public PromptService(GPTCloneDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(PromptAddDto promptAddDto)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<PromptGetAllDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public PromptGetByIdDto GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
