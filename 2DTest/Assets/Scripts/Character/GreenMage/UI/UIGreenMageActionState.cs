using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using green_mage.action;

namespace green_mage.ui {
    public class UIGreenMageActionState : MonoBehaviour {
        private Text _text = null;
        private green_mage.action.GreenMageRootAction _action;

        UIGreenMageActionState() {
        }
        // Start is called before the first frame update
        void Start() {
            var canvas = GameObject.Find("Canvas");
            var ui_panel = canvas.transform.Find("UIPlayerActionState");
            _action = this.GetComponent<green_mage.action.GreenMageRootAction>();
            _text = ui_panel.GetComponent<Text>();
            _text.transform.SetPositionAndRotation(new Vector3(100.0f, 200.0f, 0.0f), this.transform.rotation);
        }

        // Update is called once per frame
        void Update() {
            var state = _action.GetCurrentState().name.ToString();
            _text.text = state;
        }
    }
}