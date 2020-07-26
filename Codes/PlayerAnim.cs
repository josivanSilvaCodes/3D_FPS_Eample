using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator a;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AnimFire(); Invoke("AnimIdle", 0.45f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            AnimLoad(); Invoke("AnimIdle", 0.45f);
        }
    }

    void AnimIdle(){
        a.SetBool("i", true); a.SetBool("f", false); a.SetBool("l", false);
    }
    void AnimFire()
    {
        a.SetBool("f", true); a.SetBool("i", false); a.SetBool("l", false);
    }
    void AnimLoad()
    {
        a.SetBool("l", true); a.SetBool("f", false); a.SetBool("i", false);
    }

}
