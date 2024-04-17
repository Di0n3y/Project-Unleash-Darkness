using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float Loading = 3f;
    [SerializeField] private string sceneToLoad = default;

    private void Start()
    {
        Invoke("LoadScene", Loading);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
