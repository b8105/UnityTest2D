using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.input;
using green_mage.action;
using green_mage.state;


namespace green_mage.action {
    public class GreenMageRootAction : MonoBehaviour, green_mage.action.GreenMageAction {
        //! 要素
        state.GreenMageStateMachine _state_machine;

        public GreenMageRootAction() {
            _state_machine = new state.GreenMageStateMachine();
        }

        /// <summary>
        /// ゲッター
        /// </summary>
        /// <returns></returns>
        public green_mage.state.GreenMageActionState GetCurrentState() {
            return this._state_machine.current_state;
        }
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Root;
        }
        /// <summary>
        /// 実行
        /// </summary>
        public ActionResult Execute(float delta_time) {
            return new ActionResult();
        }
        public void Enter() {
        }

        public void Exit() {
        }


        // Start is called before the first frame update
        void Start() {
            var walk = new GreenMageWalkAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(walk));
            _state_machine.ChangeState(action.ActionTypeName.Walk);

            this.GetComponent<input.GreenMagePlayerInput>().Register(walk);
        }

        // Update is called once per frame
        void Update() {
            float delta_time = 0.01667f;
            var command = this.GetComponent<GreenMagePlayerInput>().command;
            if(command != null) {
                command.Execute(delta_time);
            } // if
        }
    }
}