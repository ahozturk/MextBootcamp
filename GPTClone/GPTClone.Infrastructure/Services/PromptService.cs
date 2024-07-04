using GPTClone.Application;
using GPTClone.Domain;

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
        _dbContext.Prompts.Add(new Prompt
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTimeOffset.UtcNow,
            Text = promptAddDto.Text,
            Response = promptAddDto.Response,
            CreatedBy = promptAddDto.CreatedBy
        });

        _dbContext.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var prompt = _dbContext.Prompts
            .FirstOrDefault(x => x.Id == id);

        if (prompt is null)
            throw new Exception("Prompt not found");

        _dbContext.Prompts.Remove(prompt);

        _dbContext.SaveChanges();
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
