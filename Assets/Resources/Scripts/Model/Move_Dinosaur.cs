using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bawanglong : IMoveStrategy
{
    public void Move(DinosaurView view, Vector3 direction)
    {
        Debug.Log("�������ƶ���");
        //����д���������ƶ��߼�
        if (view == null)
            throw new System.NotImplementedException();
    }
}
public class Move_niulong : IMoveStrategy
{
    public void Move(DinosaurView view, Vector3 direction)
    {
        Debug.Log("ţ���ƶ���");
        //����дţ�����ƶ��߼�
        if (view == null)
            throw new System.NotImplementedException();
    }
}
