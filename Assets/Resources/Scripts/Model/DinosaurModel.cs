public class DinosaurModel
{
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 生命
    /// </summary>
    public float Health { get; private set; }
    /// <summary>
    /// mp
    /// </summary>
    public float Mp { get; private set; }
    /// <summary>
    /// 攻击角度
    /// </summary>
    public float AttackAngle { get; private set; }
    /// <summary>
    /// 普通攻击伤害
    /// </summary>
    public float AttackDamage { get; private set; }
    /// <summary>
    /// 技能1伤害
    /// </summary>
    public float Skill1Damage { get; private set; }
    /// <summary>
    /// 技能2伤害
    /// </summary>
    public float Skill2Damage { get; private set; }
    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed { get; private set; }
    /// <summary>
    /// 攻击冷却时间
    /// </summary>
    public float AttackCooldowm { get; private set; }
    /// <summary>
    /// 技能1冷却时间
    /// </summary>
    public float Skill1Cooldowm { get; private set; }
    /// <summary>
    /// 技能2冷却时间
    /// </summary>
    public float Skill2Cooldowm { get; private set; }

    public DinosaurModel(string name, float health, float mp, float attackAngle, float attackDamage, float skill1Damage, float skill2Damage, float moveSpeed, float attackCooldowm, float skill1Cooldowm, float skill2Cooldowm)
    {
        Name = name;
        Health = health;
        this.Mp = mp;
        this.AttackAngle = attackAngle;
        this.AttackDamage = attackDamage;
        this.Skill1Damage = skill1Damage;
        this.Skill2Damage = skill2Damage;
        this.MoveSpeed = moveSpeed;
        this.AttackCooldowm = attackCooldowm;
        this.Skill1Cooldowm = skill1Cooldowm;
        this.Skill2Cooldowm = skill2Cooldowm;
    }
    public DinosaurModel() { }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
}