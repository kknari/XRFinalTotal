using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isDoorOpen = false;
    public Transform door;
    public float rotationSpeed = 45f;
    private bool isRotating = false; // 회전 중인지 여부
    private float currentRotation = 0f; // 현재 회전량

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            // 회전 중일 때
            currentRotation += rotationSpeed * Time.deltaTime;
            door.rotation = Quaternion.Euler(0f, currentRotation, 0f);

            if (currentRotation >= 45f)
            {
                // 45도 회전을 넘어가면 회전 멈춤
                isRotating = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!isDoorOpen && other.CompareTag("Key"))
        {
            // 문이 열려있지 않고, 충돌한 물체가 "Key" 태그를 가진 경우

            isDoorOpen = true; // 문을 열린 상태로 변경
            Debug.Log("문이 열렸습니다!");

            isRotating = true;
        }
    }
}
