namespace WizardsAndWarriors.Classes;

public record class ClassSpecification(string Name, WeaponType AllowedWeapons)
{
}

public static class Classes
{
    public static readonly ClassSpecification Warrior = new("Warrior", WeaponType.Sword | WeaponType.Axe | WeaponType.Dagger);
    
    public static readonly ClassSpecification Wizard = new("Wizard", WeaponType.Staff | WeaponType.Dagger);
    
    public static readonly ClassSpecification Archer = new("Archer", WeaponType.Bow | WeaponType.Dagger);
    
    public static readonly ClassSpecification Lancer = new("Lancer", WeaponType.Lance | WeaponType.Dagger);
    
    public static readonly ClassSpecification[] All = { Warrior, Wizard, Archer, Lancer };
}