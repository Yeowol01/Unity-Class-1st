using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{    
    [SerializeField] GameObject target;
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 5.0f;

    private void Awake()
    {
        target = GameObject.Find("Player");
    }

    public void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        // 1. Target의 벡터 - 자신의 위치 벡터
        direction = target.transform.position - transform.position;

        // 2. y축을 0으로 설정합니다.
        direction.y = 0;

        // 3. 벡터의 정규화
        direction.Normalize();
        
        // 4. 특정한 대상을 바라봅니다.
        transform.LookAt(target.transform);

        // 5. 방향 벡터를 구한 값을 가지고 이동을 합니다.
        transform.position += direction * speed * Time.deltaTime;
    }

    // OnTriggerEnter() : Trigger 충돌이 되었을 때 이벤트를 호출하는 함수입니다.
    private void OnTriggerEnter(Collider other)
    {
        speed = 0;
        Debug.Log("OnTriggerEnter");
    }

    // OnTriggerStay() : Trigger가 충돌 중일 때 이벤트를 호출하는 함수입니다.
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // OnTriggerExit() : Trigger와 충돌이 끝났을 때 이벤트를 호출하는 함수입니다.
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
