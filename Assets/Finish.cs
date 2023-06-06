using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        t = Time.fixedTime;
        _score.gameObject.SetActive(false);
        number.gameObject.SetActive(false);
    }
    public Text _score, number;
    public float t;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            float score = Time.fixedTime - t;
            _score.gameObject.SetActive(true);
            number.gameObject.SetActive(true);
            number.text = ((int)score).ToString();
        }


    }
}
