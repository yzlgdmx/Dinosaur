using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurFactory : MonoBehaviour
{
    public static DinosaurController CreateDinosaur(string type, Transform spawnPoint)
    {
        GameObject prefab = Resources.Load<GameObject>($"Prefab/Dinosaurs/{type}");
        GameObject dinosaurObject = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        DinosaurController controller = dinosaurObject.GetComponent<DinosaurController>();
        DinosaurView view = dinosaurObject.GetComponent<DinosaurView>();

        DinosaurModel model;

        // 根据恐龙类型分配策略
        IAttackStrategy attackStrategy;
        IMoveStrategy moveStrategy;
        ISkillStrategy skillStrategy;

        if (type == "bawanglong")
        {
            model = new DinosaurModel(type, 10000f, 100f, 45, 500f, 1000f, 2000f, 2f, 3, 6, 10);
            attackStrategy = new Attack_bawanglong();
            moveStrategy = new Move_bawanglong();
            skillStrategy = new Skill_bawanglong();
        }
        else if (type == "niulong")
        {
            model = new DinosaurModel(type, 10000f, 100f, 45, 500f, 1000f, 2000f, 2f, 3, 6, 10);
            attackStrategy = new Attack_niulong();
            moveStrategy = new Move_niulong();
            skillStrategy = new Skill_niulong();
        }
        else
        {
            throw new System.Exception("Unknown dinosaur type!");
        }

        controller.Initialize(model, view, attackStrategy, moveStrategy, skillStrategy);

        return controller;
    }
}
