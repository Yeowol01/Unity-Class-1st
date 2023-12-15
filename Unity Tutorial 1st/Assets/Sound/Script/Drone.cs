using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 55;
    public Vector3 direction;

    private void Start()
    {
        direction = transform.position;

        // InvokeRepeation() : 특정한 함수를 특정한 시간이 지난 후에 특정한 시간마다 반복적으로 호출하는 함수입니다.
        // 첫 번째 매개변수 : 실행할 함수의 이름
        // 두 번째 매개변수 : 특정한 시간이 지난 후 실행할 시간
        // 세 번째 매개변수 : 특정한 시간마다 반복적으로 함수를 호출하는 시간

        InvokeRepeating("NewPosition", 5, 5);
    }

    void Update()
    {
        transform.Translate
        (
            Vector3.forward * speed * Time.deltaTime
        );
    }

    public void NewPosition()
    {
        transform.position = direction;
        transform.Find("Canvas").gameObject.SetActive(false);
    }
}
