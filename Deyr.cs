using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deyr : MonoBehaviour
{
    private AudioSource playerAudio;
    // skilgreinum það að við erum að nota hljóð
    public AudioClip deyrHljod;
    // breyta sem skilgreynir hvaða hljóð við ætlum að nota
    private static int spilun = 0;
    // teljari sem ég setti inn til að passa að hljóðið spilist aðeins einu sinni

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        // sækjum hljóðið
    }

    // Update is called once per frame
    void Update()
    {
            if (transform.position.y <= -1)
            // ef að leikmaður er komin niður fyrir heimin (semsagt ef hann dettur út af)
        {
            spilun += 1;
            // hækkum gildi teljarans
            if (spilun == 1)
            // ef að við erum búin að fara í gegnum þessa lykkju aðeins einu sinni
            {
                playerAudio.PlayOneShot(deyrHljod);
                // spilum hljóðið
                Invoke("Endurræsa", 1.5f);
                // eftir eina og hálfa sekúndu köllum við á fallið Endurræsa()
            }
        }
        
    }
    public void Endurræsa()
    {
         //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Level_1
         SceneManager.LoadScene(0);
         // vörum yfir á senu 0 (byrjunarsenuna)
         Ovinur.health = 70;
         // líf sem skilgreind eru í Ovinur skriftunni endurstillast á 70
         Kassi.count = 0;
         // stig sem skilgreind eru í Kassi sktiftunni endurstillast á 0
    }
}
