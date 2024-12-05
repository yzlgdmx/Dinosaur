using UnityEngine;

public class DinosaurView : MonoBehaviour
{
    private Animator animator;



    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation(string animationName)
    {
        //animator.Play(animationName);
    }

    public void PlayEffect(GameObject effectPrefab)
    {
        Instantiate(effectPrefab, transform.position, Quaternion.identity);
    }

    /// <summary>
    /// 播放移动动画。
    /// </summary>
    /// <param name="isMoving">是否在移动。</param>
    public void SetMoveAnimation(bool isMoving)
    {
        animator.SetBool("IsMoving", isMoving);
    }

    /// <summary>
    /// 播放攻击动画。
    /// </summary>
    public void PlayAttackAnimation()
    {
        animator.SetTrigger("AttackTrigger");
    }

    /// <summary>
    /// 播放技能 1 动画。
    /// </summary>
    public void PlaySkill1Animation()
    {
        animator.SetTrigger("Skill1Trigger");
    }

    /// <summary>
    /// 播放技能 2 动画。
    /// </summary>
    public void PlaySkill2Animation()
    {
        animator.SetTrigger("Skill2Trigger");
    }

    #region EffectController
    public GameObject[] effectPrefabs;  // 存放不同特效的数组
    private GameObject currentEffect;

    // 通过恐龙类型选择特效
    public void PlayEffect(string effectType)
    {
        GameObject effectPrefab = GetEffectPrefab(effectType);

        if (effectPrefab != null)
        {
            if (currentEffect != null)
            {
                Destroy(currentEffect);  // 销毁旧特效
            }
            currentEffect = Instantiate(effectPrefab, transform.position, Quaternion.identity, transform);
        }
    }

    // 根据类型选择对应的特效
    private GameObject GetEffectPrefab(string effectType)
    {
        foreach (var prefab in effectPrefabs)
        {
            if (prefab.name == effectType)
            {
                return prefab;
            }
        }
        return null;  // 如果没有找到匹配的特效
    }

    // 可选：停止特效
    public void StopEffect()
    {
        if (currentEffect != null)
        {
            Destroy(currentEffect);
        }
    }
    #endregion
}
