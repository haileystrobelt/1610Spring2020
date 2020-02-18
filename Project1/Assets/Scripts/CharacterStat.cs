using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public float BaseValue;

    private readonly List<StatModifier> statModifiers;

    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }


}

//tutorial from https://www.youtube.com/watch?time_continue=3&v=SH25f3cXBVc&feature=emb_title
