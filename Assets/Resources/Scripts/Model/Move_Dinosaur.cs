using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bawanglong : IMoveStrategy
{
    public void Move(DinosaurView view, Vector3 direction)
    {
        Debug.Log("霸王龙移动了");
        //这里写霸王龙的移动逻辑
        if (view == null)
            throw new System.NotImplementedException();
    }
}
public class Move_niulong : IMoveStrategy
{
    public void Move(DinosaurView view, Vector3 direction)
    {
        Debug.Log("牛龙移动了");
        //这里写牛龙的移动逻辑
        if (view == null)
            throw new System.NotImplementedException();
    }
}
