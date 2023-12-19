using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] Transform spawnPosition;

    // Unit -> 소서리스, 마법사, 전사, 오크, 
    public GameObject CreateUnit(Unit unit)
    {
        // 1. 게임 오브젝트를 생성합니다.
        GameObject monster = Instantiate(unit.gameObject, spawnPosition);

        // 2. 게임 오브젝트를 반환합니다.
        return monster;
    }
}
