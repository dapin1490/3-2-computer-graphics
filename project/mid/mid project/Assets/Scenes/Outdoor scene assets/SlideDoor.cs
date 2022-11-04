using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        print("Slide Door script start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        print("Sliding Door Enter: " + other.gameObject.name);
        pivot.GetComponent<Animator>().SetInteger("SD_state", 1);
    }

    public void OnTriggerExit(Collider other)
    {
        print("Sliding Door Exit: " + other.gameObject.name);
        pivot.GetComponent<Animator>().SetInteger("SD_state", 2);
    }
}
