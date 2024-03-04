using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraBehavior : MonoBehaviour
{
    public CinemachineVirtualCamera VirtualCamera_1, VirtualCamera_2, VirtualCamera_3;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            VirtualCamera_1.Priority = 15;
            VirtualCamera_2.Priority = 10;
            VirtualCamera_3.Priority = 10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            VirtualCamera_1.Priority = 10;
            VirtualCamera_2.Priority = 15;
            VirtualCamera_3.Priority = 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            VirtualCamera_1.Priority = 10;
            VirtualCamera_2.Priority = 10;
            VirtualCamera_3.Priority = 15;
        }
    }
}
