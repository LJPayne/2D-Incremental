using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWood : MonoBehaviour {

    public static int WoodCount;
    public GameObject WoodDisplay;
    public int InternalWood;

    // Update is called once per frame
    void Update()
    {
        InternalWood = WoodCount;
        WoodDisplay.GetComponent<Text>().text = "Wood:" + InternalWood;
    }
}
