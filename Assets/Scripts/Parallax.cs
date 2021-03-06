﻿// Reference/Source: https://www.youtube.com/watch?v=zit45k6CUMk&t=411s
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    
    [SerializeField] private float _parallaxEffect = default;
    private GameObject _camera = default;
    private float _startPosition = default;


    void Start()
    {
        _startPosition = transform.position.x;
        _camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (_camera == null)
        {
            // if we dont have the camera try again
            _camera = GameObject.FindGameObjectWithTag("MainCamera");
        }

        // if it is still null dont do the calculations
        if (_camera == null) return;

        float distance = (_camera.transform.position.x * _parallaxEffect);

        transform.position = new Vector3(_startPosition + distance, transform.position.y, transform.position.z);
    }
}
