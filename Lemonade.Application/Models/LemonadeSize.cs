using Lemonade.Domain.Shared;

namespace Lemonade.Application.Models;

public class LemonadeSizeModel
{
    public Guid Id { get; set; }
    public Guid LemonadeId { get; set; }

    public LemonadeSizeEnum Size { get; set; }

    public int Price { get; set; }
}