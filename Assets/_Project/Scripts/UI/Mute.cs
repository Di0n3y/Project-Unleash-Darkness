using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    private bool isMuted = false;

    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0 : 1;
    }
}
