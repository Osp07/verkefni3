using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnCollisionEnter(Collision collision)
    {
        // þegar eitthvað kemur við hliðið
        if (Kassi.count >= 79)
        // ef að leikmaður er með 79 eða fleiri stig
        {
            if (collision.collider.tag=="Player")
            // ef að það er leikmaður sem að kemur við hliðið
            {
            Destroy(gameObject);
            gameObject.SetActive(false);
            // eyðist hliðið og leikmaður kemst í gegn
            }
        }

    }
}
