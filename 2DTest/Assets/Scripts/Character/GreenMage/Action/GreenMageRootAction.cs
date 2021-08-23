using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using green_mage.input;
using green_mage.action;
using green_mage.state;


namespace green_mage.action {
    public class GreenMageRootAction : MonoBehaviour {
        //! 要素
        state.GreenMageStateMachine _state_machine;

        /// <summary>
        /// コンストラクタ
        /// </summary>
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
        // Start is called before the first frame update
        void Start() {
            var idle = new GreenMageIdleAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(idle));

            var walk = new GreenMageWalkAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(walk));

            var basic_magic_attack = new GreenMageBasicMagicAttackAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(basic_magic_attack));

            var basic_magic_attack_reserve = new GreenMageBasicMagicAttackReserveAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(basic_magic_attack_reserve));

            var basic_magic_attack_charge = new GreenMageBasicMagicAttackChargeAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(basic_magic_attack_charge));

            var basic_magic_charge_attack = new GreenMageBasicMagicChargeAttackAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(basic_magic_charge_attack));


            var jump_up = new GreenMageJumpUpAction(this);
            _state_machine.RegisterState(new state.GreenMageActionState(jump_up));


            this.GetComponent<input.GreenMagePlayerInput>().Register(idle);
            this.GetComponent<input.GreenMagePlayerInput>().Register(walk);
            this.GetComponent<input.GreenMagePlayerInput>().Register(basic_magic_attack);
            this.GetComponent<input.GreenMagePlayerInput>().Register(basic_magic_attack_reserve);
            this.GetComponent<input.GreenMagePlayerInput>().Register(basic_magic_attack_charge);
            this.GetComponent<input.GreenMagePlayerInput>().Register(jump_up);

            _state_machine.ChangeState(action.ActionTypeName.Idle);
        }
        // Update is called once per frame
        void Update() {
            Debug.Log(_state_machine.current_state.name.ToString());

            float delta_time = 0.01667f;
            var command = this.GetComponent<GreenMagePlayerInput>().command;
            if(command != null) {
                var result = command.Execute(delta_time);
                if(result.change) {
                    _state_machine.ChangeState(result.next);
                } // if
            } // if
        }
    }
}