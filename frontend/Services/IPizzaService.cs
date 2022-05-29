using frontend.Models;

namespace frontend.Services;

public interface IPizzaService
{
    Task<IEnumerable<PizzaInfo>> GetPizzasAsync();
}
