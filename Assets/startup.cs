using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<runner>().enabled = false;
        GameObject.Find("PrototypeWhite04x01 (1)").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Level Generator").GetComponent<recycle>().enabled = false;
        GameObject.Find("Level Generator").GetComponent<scorepersecond>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) { 
            GetComponent<runner>().enabled = true;
        GameObject.Find("PrototypeWhite04x01 (1)").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Level Generator").GetComponent<recycle>().enabled = true;
            GameObject.Find("Level Generator").GetComponent<scorepersecond>().enabled = true;

        }
    }
}
