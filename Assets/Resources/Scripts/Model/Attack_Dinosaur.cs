using System;
using UnityEngine;

/// <summary>
/// 霸王龙
/// </summary>
public class Attack_bawanglong : MonoBehaviour, IAttackStrategy
{
    public void Attack(DinosaurView view)
    {
        Debug.Log("霸王龙使用了攻击");
        Action action = () => { Debug.Log("延迟执行"); };
        //协程只能在继承于monobehaviour的类的实例中调用,由于这是个接口的方法的实现,没有实例化
        //所以尽管继承于monobehaviour,也无法直接调用startCoroutine
        //StartCoroutine(Tool.Instance.DelayAction(2f, action));这么写是错的
        Tool.Instance.StartCoroutine(Tool.Instance.DelayAction(2f, action));
    }
}

/// <summary>
/// 牛龙
/// </summary>
public class Attack_niulong : MonoBehaviour, IAttackStrategy
{
    public void Attack(DinosaurView view)
    {
        Debug.Log("牛龙使用了攻击");
    }
}