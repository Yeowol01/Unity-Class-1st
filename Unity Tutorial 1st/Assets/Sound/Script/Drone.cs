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

        // InvokeRepeation() : Ư���� �Լ��� Ư���� �ð��� ���� �Ŀ� Ư���� �ð����� �ݺ������� ȣ���ϴ� �Լ��Դϴ�.
        // ù ��° �Ű����� : ������ �Լ��� �̸�
        // �� ��° �Ű����� : Ư���� �ð��� ���� �� ������ �ð�
        // �� ��° �Ű����� : Ư���� �ð����� �ݺ������� �Լ��� ȣ���ϴ� �ð�

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
