using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSave : MonoBehaviour
{
    private Vector3 playerPos = Vector3.zero;
        public GameObject playerGameObject;
    public Vector3 PLAYER => playerPos;

    // Start is called before the first frame update
    void Start()
    {
        var tempPos = PlayerPrefs.GetString("Position", "Error");
        if (tempPos.Equals ("Error")) 
        { 
            playerPos = playerGameObject.transform.position; 
            PlayerPrefs.SetString("Position", JsonUtility.ToJson(playerPos));
            Debug.Log("No pudo encontrar ubicacion");

        }else
        {
            playerPos = JsonUtility.FromJson<Vector3>(tempPos);
            playerGameObject.transform.position = playerPos;
            Debug.Log("Date cargada la posicion es: " + playerPos);
        }
    }
    public void SaveData()
    {
        playerPos = playerGameObject.transform.position;
        PlayerPrefs.SetString("Posicion", JsonUtility.ToJson(playerPos));
        Debug.Log("La posicion es: " + playerPos);


    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }
       
    
}
