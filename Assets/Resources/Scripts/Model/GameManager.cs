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

        // ����һ������
        currentDinosaur = DinosaurFactory.CreateDinosaur("bawanglong", spawnPoint);
        InitBtn();
        changeBtn.onClick.AddListener(ChangeDinosaur);
    }

    private void Update()
    {
        //������
        //if (Input.GetKey(KeyCode.W) && currentDinosaur != null)
        //{
        //    currentDinosaur.PerformMove(Vector3.forward);
        //}

        //if (Input.GetMouseButtonDown(0) && currentDinosaur != null)
        //{
        //    currentDinosaur.PerformAttack();
        //}


        // ��ȡ����ҡ������
        Vector2 joystickInput = joystick.InputVector;

        // ���ƿ����ƶ�
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
