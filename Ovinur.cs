using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;
using TMPro;

public class Ovinur : MonoBehaviour
{
    public static int health = 70;
    // leikmaður hefur 70 í heilsu
    public Transform player;
    // skilgreinum hver leikmaðurinn er sem óvinurinn á að elta
    private  TextMeshProUGUI texti;
    // notum texta sem segir hve mörg líf leikmaðurinn hefur
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 2f;
    // breyta sem að skilgreinir hraða óvinsins

    // Start is called before the first frame update
    void Start()
    {
        texti= GameObject.Find("Text2").GetComponent<TextMeshProUGUI>();
        // setjum inn virkni textans
        rb = this.GetComponent<Rigidbody>();
        texti.text = "Líf " + health.ToString();
        // setjum inn textan sem að kemur inn á skjáinn
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
        // óvinur fylgir leikmanni eftir
        
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
        // óvinur fylgir leikmanni eftir á þeim hraða sem að settur hefur verið fyrir
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Þegar eitthvað kemur við óvininn
        if (collision.collider.tag=="Player")
        // ef að það sem að kemur við óvininn er leikmaður
        {
            Debug.Log("Leikmaður fær í sig óvin");
            // koma upp skilaboð sem segja að leikmaður hafi fengið í sig óvin
            TakeDamage(10);
            // köllum á fall sem að lækkar líf leikmanns up 10
            gameObject.SetActive(false);
            // óvinurinn hverfur
        }
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("health er núna" + (health).ToString());
        // skilaboð sem segja hversu mörg líf leikmaður hefur núna
        health -= damage;
        // líf leikmanns lækka um jafn mikið og við settum inn í fallið (lækka um 10 í)
        texti.text = "Líf " + health.ToString();
        // uppfærum textan sem að segir hve mörg líf leikmaður hefur
        if (health <= 0)
        // ef að leikmaður hefur 0 eða færri líf
        {
            SceneManager.LoadScene(0);
            // förum yfir á senu 0 (byrjunarsenuna)
            health = 70;
            // líf leikmanns endurstillast yfir á 70
            Kassi.count = 0;
            // stig leikmanns núllstillum 
            texti.text = "Líf " + health.ToString();
            // uppfærum textan sem að birtir á skjánum hve mörg líf leikmaður hefur
        }

    }
    

}
