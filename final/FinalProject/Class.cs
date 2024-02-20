using System.Collections.Generic;

public class Class
{
    private string _name;
    private List<Ability> _abilities;

    public Class()
    {
        _abilities = new List<Ability>();
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void AddAbility(Ability ability)
    {
        _abilities.Add(ability);
    }

    public void SetAbilities(List<Ability> abilities)
    {
        _abilities = abilities;
    }

    public List<Ability> GetAbilities()
    {
        return _abilities;
    }
}
