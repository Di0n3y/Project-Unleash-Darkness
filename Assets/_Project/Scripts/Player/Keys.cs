using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using MagasLib.StateMachine;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{

    [SerializeField] private GameObject KeyImage;
    [SerializeField] private GameObject Door1;
    [SerializeField] private GameObject Door2;

    public AudioClip keyPickupSound; 
    public AudioClip doorOpenSound;  
    private AudioSource audioSource;


    public bool hasKey = false;
    public int keyCount;
    public bool moveDoor1 = false;
    public bool moveDoor2 = false;

    [SerializeField] private GameObject KeyAlertPanel;




    // Start is called before the first frame update
    void Start()
    {
       HideKeyAlertPanel();
        KeyImage.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        hasKey = false;
        moveDoor1 = false;
        moveDoor2 = false;
        
    }

    // Update is called once per frame
    void Update()

    {
       
       if(keyCount >=1)
        {
            hasKey=true;
            ShowKeyAlertPanel();
            KeyImage.SetActive(true);

        }
        if(keyCount == 0) 
        {
            hasKey = false;
        }else if(keyCount < 0) 
        {
            keyCount = 0;
        }
        
    }

    private void ShowKeyAlertPanel()
    {
        if (KeyAlertPanel != null)
        {
            KeyAlertPanel.SetActive(true);
           
        
        }
    }

    private void HideKeyAlertPanel()
    {
        if (KeyAlertPanel != null)
        {
            KeyAlertPanel.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            keyCount++;
            audioSource.PlayOneShot(keyPickupSound);
        }
        if ((collision.gameObject.tag == "Door") && (hasKey == true))
        {
            KeyImage.SetActive(false);
            HideKeyAlertPanel();
            audioSource.PlayOneShot(doorOpenSound);
            keyCount--;
            moveDoor1 = true;
           


        }
        if (moveDoor1 == true)
        {
            Door1.transform.Rotate(0, 90, 0);
            Door1.transform.Translate(0, 0, -1);
            moveDoor1 = false;
        }

        if ((collision.gameObject.tag == "Door2") && (hasKey == true))
        {
            KeyImage.SetActive(false);
            HideKeyAlertPanel();
            audioSource.PlayOneShot(doorOpenSound);
            keyCount--;
            moveDoor2 = true;



        }
        if (moveDoor2 == true)
        {
            
            Door2.transform.Rotate(0, 0, -90);
            Door2.transform.Translate(-1, 0, 0);
            moveDoor2 = false;
        }

    }


}
