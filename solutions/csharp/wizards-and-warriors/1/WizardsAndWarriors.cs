abstract class Character
{
    private string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    bool spell_prepared = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => this.Vulnerable() ? 3 : 12;
  
    public override bool Vulnerable() => !this.spell_prepared;

    public void PrepareSpell() => this.spell_prepared = true; 
}
