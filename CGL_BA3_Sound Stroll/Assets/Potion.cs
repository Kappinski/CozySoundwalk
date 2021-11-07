using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    // public GameObject genericObject;
    public GameObject cubeHolder;

    public static bool cubeInHand;

    Rigidbody rb;

    public AudioSource pickUp;
    public AudioSource drop;

    // Start is called before the first frame update
    void Start()
    {
        cubeInHand = false;
        cubeHolder = GameObject.Find("CubeHolder");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {

            if (cubeInHand == true && pickUp.isPlaying == false)
            {
                Debug.Log("fall");
                // this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                transform.parent = null;
                rb.useGravity = true;
                cubeInHand = false;
                return;
            }
        }
       */
    }

    private void OnMouseDown()
    {

        if ((transform.position - Camera.main.transform.position).magnitude > 66.66f && pickUp.isPlaying == true) return;
        pickUp.Play();

        return;
        if (cubeInHand == false)
        {
            pickUp.Play();
            transform.parent = cubeHolder.transform;
            transform.localPosition = Vector3.zero;
            rb.useGravity = false;
            cubeInHand = true;
            return;
            
        }
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        return;
        drop.volume = Mathf.Clamp(rb.velocity.magnitude * 0.5f, 0f, 1f);
        drop.Play();
    }

}
