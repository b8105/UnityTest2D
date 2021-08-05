using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGreenMageStageBoundary : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        var pos = this.GetComponent<Transform>().position;
        if(pos.y < 0) {
                        this.GetComponent<Transform>().SetPositionAndRotation(
                            new Vector3(pos.x, 0.0f, pos.z), new Quaternion());
        } // if
    }
}
