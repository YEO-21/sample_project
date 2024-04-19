using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _MyRigidbody;


    private void Awake()
    {

        Debug.Log("Awake ȣ���");
        _MyRigidbody = GetComponent<Rigidbody>();
        // GetComponent<T>() : �ش� ������Ʈ�� �����ϴ� ������Ʈ���� T ������ ������Ʈ��
        // �ϳ� ã�� ��ȯ�մϴ�.

        if(_MyRigidbody == null)
        {
            Debug.Log("Rigidbody Component �� ã�� �� �����ϴ�.");
        }
        else
        {
            Debug.Log("Rigidbody Component �� ã�ҽ��ϴ�.");

        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start ȣ���");
        //Debug Ŭ���� : ������ �����ϴ� ���� ���� ������� �� �ִ� �޼��尡 ���Ե� Ŭ�����Դϴ�.
        // Log �޼��� : Unity Console Window �� ���ڿ� �޽����� ����մϴ�.

        _MyRigidbody.AddForce(new Vector3(0.0f, 0.0f, 1.0f) * 500.0f, ForceMode.Impulse);
        // Vector3 : �ϳ��� ��ġ��, ������ ��Ÿ���� ���� ����ü (x, y, z) ��� float ����
    }


    private void FixedUpdate()
    {
        // Time -> FixedTimestemp �� ������ �ð����� �����ϰ� ȣ��˴ϴ�.
        //Time.fixedDeltaTime = 0.01f;
    }

    // Update is called once per frame
    private void Update()
    {
        // �� �����Ӹ��� ȣ��Ǵ� �޼����Դϴ�.
        //Debug.Log("Update ȣ���");
    }

    private void LateUpdate()
    {
        // Update �� ȣ��� �� Frame �� �� �� ȣ��˴ϴ�.
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable ȣ���");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable ȣ���");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy ȣ���");

    }
}
