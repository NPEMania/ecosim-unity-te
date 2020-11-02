using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiply : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public Material male;
    public Material female;

    public GameObject childobj;
    void Start()
    {
        int chance = Random.Range(1, 3);
        if (chance == 1)
        {
            player.tag="male";
            player.GetComponent<Renderer>().material = male;
    }
        else {
            player.tag="female";

            player.GetComponent<Renderer>().material = female;
        }
                }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "female" && player.tag == "male"|| collision.gameObject.tag == "male" && player.tag == "female")
        {
            Vector3 pos = transform.position;
            Instantiate(childobj,pos,Quaternion.identity);
        }

    }
}
