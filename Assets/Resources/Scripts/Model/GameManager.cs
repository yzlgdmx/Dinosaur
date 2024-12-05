using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform spawnPoint;

    private DinosaurController currentDinosaur;

    public Button attackBtn;
    public Button skill1Btn;
    public Button skill2Btn;
    public Button changeBtn;



    public VirtualJoystick2 joystick;

    private void Start()
    {

        // 创建一个恐龙
        currentDinosaur = DinosaurFactory.CreateDinosaur("bawanglong", spawnPoint);
        InitBtn();
        changeBtn.onClick.AddListener(ChangeDinosaur);
    }

    private void Update()
    {
        //测试用
        //if (Input.GetKey(KeyCode.W) && currentDinosaur != null)
        //{
        //    currentDinosaur.PerformMove(Vector3.forward);
        //}

        //if (Input.GetMouseButtonDown(0) && currentDinosaur != null)
        //{
        //    currentDinosaur.PerformAttack();
        //}


        // 读取虚拟摇杆输入
        Vector2 joystickInput = joystick.InputVector;

        // 控制恐龙移动
        currentDinosaur.HandleMovement(joystickInput);
    }

    private void InitBtn()
    {
        attackBtn.onClick.AddListener(currentDinosaur.PerformAttack);
        skill1Btn.onClick.AddListener(currentDinosaur.PerformSkill1);
        skill2Btn.onClick.AddListener(currentDinosaur.PerformSkill2);
    }

    private void ChangeDinosaur()
    {
        Debug.Log(currentDinosaur.name);
        if (currentDinosaur.name == "bawanglong(Clone)")
        {
            Destroy(currentDinosaur.gameObject);
            currentDinosaur = DinosaurFactory.CreateDinosaur("niulong", spawnPoint);
            InitBtn();
        }
        else
        {
            Destroy(currentDinosaur.gameObject);
            currentDinosaur = DinosaurFactory.CreateDinosaur("bawanglong", spawnPoint);
            InitBtn();
        }
    }
}
