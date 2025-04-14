using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    // leikmunur sem er kúlan (tengjum leikmunin við í unity)
    public GameObject sprenging;
    // leikmunur sem er sprengingin (tengjum leikmunin við í unity)
    public float speed = 4000f;
    // hraði kúlunnar
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        // ef að ýtt er á z á lyklaborðinu
        {
            Debug.Log("skjOtttttttta");  
            // koma upp skilaboð sem segja skjóta     
           
            //GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            // setjum inn kúluma í leikinn
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            // gefum kúlunni rigidbody
            instBulletRigidbody.AddForce(transform.forward * speed);
            // setjum hreyfingu á kúluna
            Destroy(instBullet, 0.5f);//kúl eytt eftir 0.5sek
            // eyðum kúlunni eftir hálfa sekúndu
            Sprengin();
            // köllum á fallið sem að kemur með sprengingu
           
        }
    }

        void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
        // setjum inn sprengingu
    }
}
