using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.creational;

namespace green_mage.input {
    public class GreenMagePlayerInput : MonoBehaviour {
        private green_mage.command.GreenMageActionCommand _command;
        private green_mage.creational.GreenMageWalkActionCommandFactory _walk_command_factory = null;

        /// <summary>
        /// アクセッサ
        /// </summary>
        public green_mage.command.GreenMageActionCommand command {
            get {
                return this._command;
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GreenMagePlayerInput() {
        }

        public void Register(green_mage.action.GreenMageWalkAction action) {
            _walk_command_factory = new creational.GreenMageWalkActionCommandFactory(action);
        }

        // Start is called before the first frame update
        void Start() {
        }


        public green_mage.command.GreenMageActionCommand InputHandler() {
            GreenMageActionCommand command = null;
            
            var action = this.GetComponent<green_mage.action.GreenMageRootAction>();

            switch(action.GetCurrentState().name) {
                case green_mage.action.ActionTypeName.Walk:
                    var temp = _walk_command_factory.Create();
                    float speed = 0.0f;
                    var direction = GreenMageWalkActionParameter.Direction.None;

                    if(Input.GetKey(KeyCode.RightArrow)) {
                        speed = 2.0f;
                        direction = GreenMageWalkActionParameter.Direction.Right;
                    } // if
                    else if(Input.GetKey(KeyCode.LeftArrow)) {
                        speed = 2.0f;
                        direction = GreenMageWalkActionParameter.Direction.Left;
                    } // else
                    temp.GenerateParameter(speed, direction);
                    command = temp;
                    break;

                default:
                    break;
            } // switch

            return command;
        }

        // Update is called once per frame
        void Update() {
            var command = this.InputHandler();
            _command = command;
        }
    }
}