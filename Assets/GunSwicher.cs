using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwicher : MonoBehaviour
{
    public GameObject gun1; // 1번 총 오브젝트
    public GameObject gun2; // 2번 총 오브젝트
    public GameObject hand;
    private bool isGun1Active = true;
    // Start is called before the first frame update
    void Start()
    {
        gun1.SetActive(true);
        gun2.SetActive(false);
        hand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            isGun1Active = false;
            gun1.SetActive(false);
            gun2.SetActive(true);
            hand.SetActive(false);
        }
        // 키보드 1을 누르면 총 교체
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            isGun1Active = true;
            gun1.SetActive(true);
            gun2.SetActive(false);
            hand.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            isGun1Active = false;
            gun1.SetActive(false);
            gun2.SetActive(false);
            hand.SetActive(true);
        }
    }
}
