using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _MyRigidbody;


    private void Awake()
    {

        Debug.Log("Awake 호출됨");
        _MyRigidbody = GetComponent<Rigidbody>();
        // GetComponent<T>() : 해당 컴포넌트를 소유하는 오브젝트에서 T 형식의 컴포넌트를
        // 하나 찾아 반환합니다.

        if(_MyRigidbody == null)
        {
            Debug.Log("Rigidbody Component 를 찾을 수 없습니다.");
        }
        else
        {
            Debug.Log("Rigidbody Component 를 찾았습니다.");

        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start 호출됨");
        //Debug 클래스 : 게임을 개발하는 동안 쉽게 디버깅할 수 있는 메서드가 포함된 클래스입니다.
        // Log 메서드 : Unity Console Window 에 문자열 메시지를 기록합니다.

        _MyRigidbody.AddForce(new Vector3(0.0f, 0.0f, 1.0f) * 500.0f, ForceMode.Impulse);
        // Vector3 : 하나의 위치나, 방향을 나타내기 위한 구조체 (x, y, z) 모두 float 형식
    }


    private void FixedUpdate()
    {
        // Time -> FixedTimestemp 에 설정된 시간마다 일정하게 호출됩니다.
        //Time.fixedDeltaTime = 0.01f;
    }

    // Update is called once per frame
    private void Update()
    {
        // 매 프레임마다 호출되는 메서드입니다.
        //Debug.Log("Update 호출됨");
    }

    private void LateUpdate()
    {
        // Update 가 호출된 후 Frame 당 한 번 호출됩니다.
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable 호출됨");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable 호출됨");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy 호출됨");

    }
}
