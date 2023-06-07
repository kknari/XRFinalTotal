using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool isPickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp)
        {
            // 키가 집혀있을 때 Player와 함께 이동
            transform.position = transform.parent.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other != null && other.CompareTag("Hand"))
        {
            Debug.Log("잡았다");
            // 키를 손에 든 위치로 조정
            transform.SetParent(other.transform);
            transform.localPosition = new Vector3(0.8f, 0f, 0f);
            transform.localRotation = Quaternion.identity;

            // 함께 이동하기 위해 isPickedUp 변수를 true로 설정
            isPickedUp = true;
        }

    }
}
