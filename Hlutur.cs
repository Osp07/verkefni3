using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hlutur : MonoBehaviour
{
    private TextMeshProUGUI countText;
    public Transform player;
    private AudioSource playerAudio;
    // við erum að notast við hljóð
    public AudioClip peningurHljod;
    // breyta sem skilgreinir hvaða hljóð við erum að nota

    // Start is called before the first frame update
    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        // setjum inn texta
        playerAudio = GetComponent<AudioSource>();
        // setjum inn virkni fyrir hljóð
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // þegar eitthvað kemur við gullteninginn
        if (collision.collider.tag=="Player")
        // ef að það sem kemur við gullteninginn er leikmaður
        {
            playerAudio.PlayOneShot(peningurHljod);
            // spilast hljóðið
            Invoke("Eyda", 0.75f);
            // bíðum í 0.75 sekúndur áður en við köllum á fallið Eyda()
        }
    }
        void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + Kassi.count.ToString();
        // uppfærum stigatextan á skjánum
    }
    void Eyda()
    {
        Destroy(gameObject);
        gameObject.SetActive(false);
        // eyðum út gullteningnum
        Kassi.count += 5;
        // leikmaður fær 5 stig
        SetCountText();
        // uppfærum stigafjöldan á skjánum
        Debug.Log("Leikmaður safnar hlut");
        // upp koma skilaboð sem segja að leikmaður hafi safnað hlut
    }
}
