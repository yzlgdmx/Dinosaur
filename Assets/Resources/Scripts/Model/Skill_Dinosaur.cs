using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_bawanglong : ISkillStrategy
{
    public void Skill1(DinosaurView view)
    {
        Debug.Log("������ʹ���˼���1");

    }

    public void Skill2(DinosaurView view)
    {
        Debug.Log("������ʹ���˼���2");
    }
}
public class Skill_niulong : ISkillStrategy
{
    public void Skill1(DinosaurView view)
    {
        Debug.Log("ţ��ʹ���˼���1");
    }

    public void Skill2(DinosaurView view)
    {
        Debug.Log("ţ��ʹ���˼���2");
    }
}
