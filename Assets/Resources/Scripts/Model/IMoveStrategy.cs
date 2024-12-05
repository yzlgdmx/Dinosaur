using System.Collections;
using UnityEngine;

public interface IMoveStrategy
{
    void Move(DinosaurView view, Vector3 direction);
}
