using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCookie : MonoBehaviour {

    public GameObject textBox;

    public void ClickThatButton() {
        GlobalCookies.CookieCount -= 1;
        GlobalCash.CashCount += 1;
    }
}
