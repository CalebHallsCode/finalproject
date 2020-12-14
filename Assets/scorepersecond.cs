using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorepersecond : MonoBehaviour
{
    public Text scoretext;
    public float scoreamount;
    public float pointincreasedpersecond;
    // Start is called before the first frame update
    void Start()
    {
        scoreamount = 0f;
        pointincreasedpersecond = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "score: " + (int)scoreamount;
        scoreamount += pointincreasedpersecond * Time.deltaTime;
    }
}
