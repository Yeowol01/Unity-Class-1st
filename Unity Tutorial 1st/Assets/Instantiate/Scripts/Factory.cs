using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] Transform spawnPosition;

    // Unit -> �Ҽ�����, ������, ����, ��ũ, 
    public GameObject CreateUnit(Unit unit)
    {
        // 1. ���� ������Ʈ�� �����մϴ�.
        GameObject monster = Instantiate(unit.gameObject, spawnPosition);

        // 2. ���� ������Ʈ�� ��ȯ�մϴ�.
        return monster;
    }
}
