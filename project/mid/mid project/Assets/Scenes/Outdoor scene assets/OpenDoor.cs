using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        print("Open Door script start");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        print("Opening Door Enter: " + other.gameObject.name);
        pivot.GetComponent<Animator>().SetInteger("OD_state", 1);
    }

    public void OnTriggerExit(Collider other)
    {
        print("Opening Door Exit: " + other.gameObject.name);
        pivot.GetComponent<Animator>().SetInteger("OD_state", 2);
    }
}
