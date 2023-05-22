namespace WizardsAndWarriors;

[Flags]
public enum WeaponType
{
    Sword = 1 << 0,
    Staff = 1 << 1,
    Axe = 1 << 2,
    Dagger = 1 << 3,
    Bow = 1 << 4,
    Lance = 1 << 5,
}