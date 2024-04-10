using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Light : MonoBehaviour
{
    [SerializeField] public bool _isOn = false;
    [SerializeField] MeshRenderer _floorBulb = null;
    [HideInInspector] public Door_light counter;
    public int resettingFloor = 0;

    [SerializeField] private Material _onMaterial, _offMaterial;

    public void Start()
    {
        _isOn = false;
        _floorBulb.material = _offMaterial;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_isOn)

        {
            counter = Object.FindFirstObjectByType<Door_light>();
            counter.floorLights += 1;
            _isOn = true;
            if (_isOn)
            {
                _floorBulb.material = _onMaterial;
            }
            else if (_isOn == false)

            {
                _floorBulb.material = _offMaterial;

            }


        }
        if (resettingFloor == 1)
        {
            _isOn = false;
            resettingFloor = 0;
        }
                
    }
   

}
