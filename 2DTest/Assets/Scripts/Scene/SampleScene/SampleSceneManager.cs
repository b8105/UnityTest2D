using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleSceneManager : MonoBehaviour {


    // Start is called before the first frame update
    void Start() {
        //// Cube�v���n�u��GameObject�^�Ŏ擾
        //GameObject obj = (GameObject)Resources.Load("GreenMage");
        //// Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        //Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        } // if

    }
}
