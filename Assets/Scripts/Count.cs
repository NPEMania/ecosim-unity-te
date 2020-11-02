using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Count : MonoBehaviour
{
    public Text count;
   
    private const int timescale = 8640;
     private  double sec ;
    private int day=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string s1 = string.Concat("male :", GameObject.FindGameObjectsWithTag("male").Length);
        string s2 = string.Concat("female :", GameObject.FindGameObjectsWithTag("female").Length);
        string s3 = string.Concat("children :", GameObject.FindGameObjectsWithTag("child").Length);
        sec+= (Time.deltaTime * timescale)/timescale;
        if (sec >= 5)
        {
            sec = 0;
            day = day + 1;
     
        }
        string s4 = string.Concat("Time :", (int)sec);
        string s5 = string.Concat("day :", day);
        count.text = s1+"\n" + s2+"\n" + s3+"\n"+s4 + "\n" + s5;
    }
}
