using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vatn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ef að eitthvað kemur við varnið sem tengt er við trigger
        if (other.tag == "Player")
        {
            // ef að leikmaður kemur við vatnið
            Debug.Log("Drukknaði");
            // koma upp skilaboð sem segja að leikmaður hafi drukknað
            SceneManager.LoadScene(0);
            // við förum yfir á byrjunarsenu
            Ovinur.health = 70;
            // líf endurstillast á 70
            Kassi.count = 0;
            // leikmaður byrjar aftur með 0 stig

        }
    }
}
