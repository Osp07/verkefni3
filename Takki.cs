using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Takki : MonoBehaviour
{
    public TextMeshProUGUI texti;
   
    public void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex==2)
        // ef að sena 2 er í gangi
        {
            texti.text = "Lokastig " + Kassi.count.ToString();
            //IÖ - þegar leikmaður er komin á senu númer þrjú kemur upp texti sem birtir lokastig
        }
        
    }
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Byrja()
    {
        SceneManager.LoadScene(1);
        // ef að kallað er á fallið Byrja() hleðst sena 1
    }
    public void Endir()
    {
        SceneManager.LoadScene(0);
        // ef að kallað er á fallið Endir() hleðst sena 0
       
    }
    
}
