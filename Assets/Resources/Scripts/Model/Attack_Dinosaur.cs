using System;
using UnityEngine;

/// <summary>
/// ������
/// </summary>
public class Attack_bawanglong : MonoBehaviour, IAttackStrategy
{
    public void Attack(DinosaurView view)
    {
        Debug.Log("������ʹ���˹���");
        Action action = () => { Debug.Log("�ӳ�ִ��"); };
        //Э��ֻ���ڼ̳���monobehaviour�����ʵ���е���,�������Ǹ��ӿڵķ�����ʵ��,û��ʵ����
        //���Ծ��ܼ̳���monobehaviour,Ҳ�޷�ֱ�ӵ���startCoroutine
        //StartCoroutine(Tool.Instance.DelayAction(2f, action));��ôд�Ǵ��
        Tool.Instance.StartCoroutine(Tool.Instance.DelayAction(2f, action));
    }
}

/// <summary>
/// ţ��
/// </summary>
public class Attack_niulong : MonoBehaviour, IAttackStrategy
{
    public void Attack(DinosaurView view)
    {
        Debug.Log("ţ��ʹ���˹���");
    }
}