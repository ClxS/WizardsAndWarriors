using WizardsAndWarriors.Classes;

namespace WizardsAndWarriors;

public class Player
{
    public required string Name { get; init; }
    
    public required ClassSpecification ClassSpecification { get; init; }
    
    public Weapon Weapon { get; set; }
}