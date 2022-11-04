using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportPortal : MonoBehaviour
{
    Scene CurrentScene;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScene = gameObject.scene;
        print("TeleportPortal script start\nCurrent Scene is " + CurrentScene.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (CurrentScene.name == "Outdoors")
        {
            SceneManager.LoadScene("Indoors");
        }
        else if (CurrentScene.name == "Indoors")
        {
            SceneManager.LoadScene("Outdoors");
        }
    }
}
