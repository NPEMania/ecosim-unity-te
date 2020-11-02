using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class foodconsume : MonoBehaviour
{


    private const int timescale = 8640;
    private double sec;
    private int day = 1;
    public GameObject player;
    public Text foodcount;
    private GameObject food;
    private int foodc;
    private bool updatefcount=false;
    // Start is called before the first frame update
    void Start()
    {
        foodc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (updatefcount==true)
        {
            foodc = foodc + 1;
            string s1 = string.Concat("Food :", foodc);
            foodcount.text = s1;

            updatefcount = false;
        }
        if (foodc == 5)
        {
            sec += (Time.deltaTime * timescale) / timescale;
            if (sec >= 2)
            {
                foodc = 0;
                sec = 0;

                string s1 = string.Concat("Food :", foodc);
                foodcount.text = s1;
                
            }
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
          if (collision.gameObject.tag == "food" && foodc<5 )
        {

            Vector3 pos = transform.position;
            Destroy(collision.gameObject);
            updatefcount = true;

        }
    }
}
