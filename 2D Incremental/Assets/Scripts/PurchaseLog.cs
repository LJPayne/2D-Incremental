using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoCookie;

    public void StartAutoCookie()
    {
        Debug.Log("Hello");
        AutoCookie.SetActive(true);
    }
}
