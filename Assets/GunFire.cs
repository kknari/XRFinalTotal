using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public Bullet b1;
    public GameObject e;
    // Start is called before the first frame update
    void Start()
    {
      
    }

  
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet temp = GameObject.Instantiate(b1, e.transform.position, transform.rotation);
            temp.dir = e.transform.position - transform.position;
            temp.fire();
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Enemy")
        {
            Debug.Log("아프다");
        }


    }*/


}
