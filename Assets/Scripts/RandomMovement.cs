using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomMovement : MonoBehaviour
{
    public float rotSpeed = 100f;
    public Text foodc;
    public float moveSpeed = 3f;
    private bool isWandering = false;
    private bool isRotLeft = false;
    private bool isRotRight = false;
    private bool isWalking = false;

    void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        moveSpeed = moveSpeed * -1;
    }

    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(wander());
        }

        if (isRotRight == true) {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }

        if (isRotLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }

        if (isWalking == true)
        {
            transform.position+=(transform.forward * Time.deltaTime * moveSpeed);
            foodc.transform.position += (transform.forward * Time.deltaTime * moveSpeed);
        }
    }
    IEnumerator wander() {

        int rotTime = Random.Range(1, 3);
        int rotWait = Random.Range(1, 3);
        int rotLorR = Random.Range(1, 3);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;

        yield return new WaitForSeconds(walkTime);
        isWalking = false;

        yield return new WaitForSeconds(rotWait);
        if (rotLorR == 1)
        {
            //right
            isRotRight = true;
            yield return new WaitForSeconds(rotTime);

            isRotRight = false;
        }
        if (rotLorR == 2)
        {
            //left

            isRotLeft = true;

            yield return new WaitForSeconds(rotTime);

            isRotLeft = false;
        }


        isWandering = false;
    }
}
