using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public float BaseValue;
    
    public float Value
    {
        get { return CalculateFinalValue(); }
    }

    private bool isDirty = true;
    private float _value;

    private readonly List<StatModifier> _statModifiers;
    
    private readonly List<StatModifier> statModifiers;
    
    
    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            finalValue += statModifiers[1].Value;
        }

        return (float) Math.Round(finalValue, 4);
    }

    public void AddModifier(StatModifier mod)
    {
        statModifiers.Add(mod);
    }
    
    public bool RemoveModifier(StatModifier mod)
    {
        statModifiers.Remove(mod);
    }
    

    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }


}

//tutorial from https://www.youtube.com/watch?time_continue=3&v=SH25f3cXBVc&feature=emb_title
