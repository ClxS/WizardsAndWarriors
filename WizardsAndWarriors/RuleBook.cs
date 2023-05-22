namespace WizardsAndWarriors;

public static class RuleBook
{
    public static bool CanEquip(Player player, Weapon weapon) => player.ClassSpecification.AllowedWeapons.HasFlag(weapon.Type);
}