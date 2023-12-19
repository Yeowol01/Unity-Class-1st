using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<Unit> listUnits;

    [SerializeField] Factory factory;

    private void Start()
    {
        StartCoroutine(CreateRoutine());

        Debug.Log("Hello World");
    }

    public IEnumerator CreateRoutine()
    {
        while (true)
        {
            // Random.Range : 0 ~ �ִ�-1�� ���� ��ȯ�ϴ� �Լ��Դϴ�.
            // Random.Range(0, listUnits.Count)
            factory.CreateUnit(listUnits[Random.Range(0, listUnits.Count)]);

            // new WaitForSeconds(5f) : Ư���� �ð����� �ڷ�ƾ�� ����մϴ�.
            yield return new WaitForSeconds(5f);
        }
    }
}
