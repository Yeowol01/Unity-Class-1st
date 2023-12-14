using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction;
    public Camera playerCamera;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // Input.GetAxis( ) : 특정한 Key를 누를 때 -1 ~ 1 사이의 값을 반환하는 함수입니다.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // 벡터의 정규화
        direction.Normalize();

        // Time.deltaTime : 이전 프레임이 완료되는 데까지 걸린 시간을 의미합니다.
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.buildIndex != 0)
        {
            playerCamera.gameObject.SetActive(true);
        }
        else
        {
            playerCamera.gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
