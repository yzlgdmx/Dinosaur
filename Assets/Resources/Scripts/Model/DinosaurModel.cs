public class DinosaurModel
{
    /// <summary>
    /// ����
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// ����
    /// </summary>
    public float Health { get; private set; }
    /// <summary>
    /// mp
    /// </summary>
    public float Mp { get; private set; }
    /// <summary>
    /// �����Ƕ�
    /// </summary>
    public float AttackAngle { get; private set; }
    /// <summary>
    /// ��ͨ�����˺�
    /// </summary>
    public float AttackDamage { get; private set; }
    /// <summary>
    /// ����1�˺�
    /// </summary>
    public float Skill1Damage { get; private set; }
    /// <summary>
    /// ����2�˺�
    /// </summary>
    public float Skill2Damage { get; private set; }
    /// <summary>
    /// �ƶ��ٶ�
    /// </summary>
    public float MoveSpeed { get; private set; }
    /// <summary>
    /// ������ȴʱ��
    /// </summary>
    public float AttackCooldowm { get; private set; }
    /// <summary>
    /// ����1��ȴʱ��
    /// </summary>
    public float Skill1Cooldowm { get; private set; }
    /// <summary>
    /// ����2��ȴʱ��
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