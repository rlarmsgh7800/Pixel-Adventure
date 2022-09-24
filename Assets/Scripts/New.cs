
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class New : UdonSharpBehaviour
{
    //ȸ���� �ӵ�
    public float Rspeed = 100.0f;
    public float Pspeed = 1.0f;
    //�̵��� ��ǥ
    public Vector3 targetPosition = new Vector3(0, 0, 0);
    //����Ƽ Transform ������Ʈ ����
    private Transform tf;
    void Start()
    {
        tf = gameObject.transform;
    }
    void FixedUpdate()
    {
        // ȸ���� x:0, y:1, z:1 ��ŭ ���������� ���ư� 
        tf.Rotate(new Vector3(0,1,1), Time.deltaTime * Rspeed);

        // ��ǥ
        tf.position = Vector3.MoveTowards(tf.position, targetPosition, Time.deltaTime * Pspeed);
    }
}
