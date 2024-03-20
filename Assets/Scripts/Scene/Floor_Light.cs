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
    public void Update()
    {
        if (_isOn)
        {
            _floorBulb.material = _onMaterial;

            counter = Object.FindFirstObjectByType<Door_light>();
            counter.floorLights = +1;




        }else if (_isOn==false) 
               
        {
            _floorBulb.material = _offMaterial;

        }if (resettingFloor == 1) 
        {
        _isOn=false;
            resettingFloor = 0;
        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            _isOn = true;
            
        }
    }

}
