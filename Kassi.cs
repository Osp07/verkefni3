using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{
 
    public static int count=0;
    // breyta sem heldur utan um hversu mörg stig leikmaður hefur
    public GameObject sprenging;
    // sprengingin sem að við ætlum að nota kemur hérna (við sitjum hana inn í unity)
    private TextMeshProUGUI countText;
    // textin sem að kemur upp og segir leikmanni hve mörg stig hann hefur

    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        // setjum inn virkni textans
        count = 0;
        // núllstillum stigin
        SetCountText();
        // köllum í breytuna sem að setur textan á skjáin
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            // ef að kassinn í leiknum fellur út af borðinu eyðist hann
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // það sem að kemur við kassan
        if (collision.collider.tag == "kula")
        // ef að það sem kemur við kassann er kúla
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            // eyðum við kassanum
            Debug.Log("varð fyrir kúlu");
            // koma upp skilaboð sem segja að kassinn hafi orðið fyrir kúlu
            count = count + 1;
            // leikmaður fær eitt stig
            SetCountText();
            // köllum í fallið sem að setur stigafjöldan á skjáin
            Sprengin();
            // köllum í fallið sem að gerir sprengingu
        }
    }
    void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + count.ToString();
        // uppfærum stigafjöldan á skjánum
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
        // setjum inn sprenginguna
    }
}
