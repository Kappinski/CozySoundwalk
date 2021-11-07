using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedUpPerson : MonoBehaviour
{
    AudioSource source;
    float timer = 10f;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && timer > 10f)
        {
            source.Play();
            timer = 0f;
        }

    }
}
