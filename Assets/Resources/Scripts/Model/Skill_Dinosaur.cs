using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_bawanglong : ISkillStrategy
{
    public void Skill1(DinosaurView view)
    {
        Debug.Log("霸王龙使用了技能1");

    }

    public void Skill2(DinosaurView view)
    {
        Debug.Log("霸王龙使用了技能2");
    }
}
public class Skill_niulong : ISkillStrategy
{
    public void Skill1(DinosaurView view)
    {
        Debug.Log("牛龙使用了技能1");
    }

    public void Skill2(DinosaurView view)
    {
        Debug.Log("牛龙使用了技能2");
    }
}
