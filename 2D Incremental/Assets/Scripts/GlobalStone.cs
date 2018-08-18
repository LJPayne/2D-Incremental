using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalStone : MonoBehaviour {

    public static int StoneCount;
    public GameObject StoneDisplay;
    public int InternalStone;

    // Update is called once per frame
    void Update()
    {
        InternalStone = StoneCount;
        StoneDisplay.GetComponent<Text>().text = "Wood:" + InternalStone;
    }
}

