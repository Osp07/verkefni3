using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Lokahlutur : MonoBehaviour
{
    private TextMeshProUGUI countText;
    // textinn sem að heldur utan um stigafjöldann
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        // setjum inn virknina á textanum
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Þegar eitthvað kemur við triggerinn
            if (other.tag=="Player")
            // ef að það sem að kemur við triggerinn er leikmaður
            {
            Debug.Log("Leikmaður nær kórónunni");
            // koma skilaboð sem segja að leikmaður hafi náð kórónunni
            Destroy(gameObject);
            gameObject.SetActive(false);
            // kórónan eyðist úr leiknum
            SetCountText();
            // köllum á fallið sem að uppfærir stigafjöldan á skjánum
            SceneManager.LoadScene(2);
            // förum yfir á senu 2 (endasenuna)
            }
    }
        void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + Kassi.count.ToString();
        // uppfærum stigafjöldan á skjánum
    }

}
