using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMillControl : MonoBehaviour
{
    Animator anim;
    bool play;
    
    // Start is called before the first frame update
    void Start()
    {
        print("WindMillControl start");
        anim = GetComponent<Animator>();
        anim.SetFloat("Speed", 1f);
        play = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (play)
            {
                print("pressed Space or mouse0 - stop: set speed 0");
                anim.SetFloat("Speed", 0f);
                play = !play;
            }
            else if (!play)
            {
                print("pressed Space or mouse0 - play: set speed 1");
                anim.SetFloat("Speed", 1f);
                play = !play;
            }
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            print("pressed P - play: set speed 1");
            anim.SetFloat("Speed", 1f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            print("pressed S - stop: set speed 0");
            anim.SetFloat("Speed", 0f);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            print("pressed B - playback: set speed -1");
            anim.SetFloat("Speed", -1f);
        }
    }
}
