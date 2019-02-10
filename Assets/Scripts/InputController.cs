using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Vector3 InputVector { get; private set; }

    public event Action OnFire = delegate { };

    private void Update()
    {
        InputVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (Input.GetKey(KeyCode.Space))
        {
            OnFire();
        }
    }
}