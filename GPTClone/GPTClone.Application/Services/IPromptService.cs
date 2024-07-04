namespace GPTClone.Application;

public interface IPromptService
{
    void Add(PromptAddDto promptAddDto);
    List<PromptGetAllDto> GetAll();
    PromptGetByIdDto GetById(Guid id);
    void Delete(Guid id);
}
