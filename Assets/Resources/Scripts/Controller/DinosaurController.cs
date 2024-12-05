using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.EventSystems;

public class DinosaurController : MonoBehaviour
{
    private DinosaurModel model;
    private DinosaurView view;
    //private DinosaurAnimatorController animatorController;

    private IAttackStrategy attackStrategy;
    private IMoveStrategy moveStrategy;
    private ISkillStrategy skillStrategy;

    public void Initialize(DinosaurModel model, DinosaurView view, IAttackStrategy attackStrategy, IMoveStrategy moveStrategy, ISkillStrategy skillStrategy)
    {
        this.model = model;
        this.view = view;
        this.attackStrategy = attackStrategy;
        this.moveStrategy = moveStrategy;
        this.skillStrategy = skillStrategy;
        //animatorController = GetComponent<DinosaurAnimatorController>();
    }

    public void PerformAttack()
    {
        attackStrategy.Attack(view);
        view.PlayAttackAnimation();//��������
    }

    public void PerformSkill1()
    {
        skillStrategy.Skill1(view);
        view.PlaySkill1Animation();
    }
    public void PerformSkill2()
    {
        skillStrategy.Skill2(view);
        view.PlaySkill2Animation();
    }

    public void PerformMove(Vector3 direction)
    {
        moveStrategy.Move(view, direction);
    }

    public void TakeDamage(float damage)
    {
        model.TakeDamage(damage);
        //view.PlayAnimation("Hit");
    }


    private Vector3 moveDirection;
    public void HandleMovement(Vector2 input)
    {
        // �� 2D ����ת��Ϊ 3D ���緽��
        moveDirection = new Vector3(input.x, 0, input.y);
        //Debug.Log(input.x);
        //Debug.Log(input.y);
        if (moveDirection.sqrMagnitude > 0.1f)
        {
            // ִ���ƶ�����
            moveStrategy.Move(view, moveDirection.normalized * model.MoveSpeed);

            // �����ƶ�����
            //view.PlayAnimation("IsWalking");
            //Debug.Log(input.sqrMagnitude > 0.1f);
            view.SetMoveAnimation(input.sqrMagnitude > 0.1f);

            // ��������
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
        else
        {
            // ֹͣ�ƶ�����
            view.SetMoveAnimation(false);
        }
    }

    private void Update()
    {

    }
}
