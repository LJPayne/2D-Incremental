using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClicker : MonoBehaviour {

    public GameObject textBox;

    public void ClickThatButton() {
        GlobalCookies.CookieCount += 1;
    }
}
