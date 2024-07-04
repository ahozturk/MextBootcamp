namespace GPTClone.Application;

public interface IPromptService
{
    void Add(PromptAddDto promptAddDto);
    List<PromptGetAllDto> GetAll();
}
