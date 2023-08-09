using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playa : MonoBehaviour {
    [SerializeField] private float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    private void Update() {
        Vector3 inputVector = new Vector3(0.0f, 0.0f, 0.0f);
        float dx = 0;
        float dz = 0;

        if (Input.GetKey(KeyCode.W)) { dz += 1; }
        if (Input.GetKey(KeyCode.A)) { dx -= 1; }
        if (Input.GetKey(KeyCode.S)) { dz -= 1; }
        if (Input.GetKey(KeyCode.D)) { dx += 1; }

        inputVector.x = dx;
        inputVector.z = dz;

        inputVector = inputVector.normalized * moveSpeed * Time.deltaTime;

        transform.position += inputVector;
    }
}
