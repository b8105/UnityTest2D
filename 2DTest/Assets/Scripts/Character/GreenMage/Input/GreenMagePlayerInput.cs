using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using green_mage.action;
using green_mage.command;


namespace green_mage.input {
    public class GreenMagePlayerInput : MonoBehaviour {
        //! コマンド
        private green_mage.command.GreenMageActionCommand _command;
        GreenMageIdleActionPlayerInput _idle_input;
        GreenMageWalkActionPlayerInput _walk_input;
        GreenMageBasicMagicAttackActionPlayerInput _basic_magic_attack_input;
        GreenMageBasicMagicAttackReserveActionPlayerInput _basic_magic_attack_reserve_input;
        GreenMageBasicMagicAttackChargeActionPlayerInput _basic_magic_attack_charge_input;
        GreenMageJumpUpActionPlayerInput _jump_up_input;

        //! マップ
        Dictionary<green_mage.action.ActionTypeName, GreenMageActionPlayerInput> _player_input_dictionary = new Dictionary<ActionTypeName, GreenMageActionPlayerInput>();
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
            _idle_input = new GreenMageIdleActionPlayerInput();
            _walk_input = new GreenMageWalkActionPlayerInput();
            _basic_magic_attack_input = new GreenMageBasicMagicAttackActionPlayerInput();
            _basic_magic_attack_reserve_input = new GreenMageBasicMagicAttackReserveActionPlayerInput();
            _basic_magic_attack_charge_input = new GreenMageBasicMagicAttackChargeActionPlayerInput();
            _jump_up_input = new GreenMageJumpUpActionPlayerInput();                   
        }

        public void Register(in green_mage.action.GreenMageIdleAction action) {
            _idle_input.RegisterAction(action);
            _player_input_dictionary.Add(_idle_input._action.GetTypeName(), _idle_input);
        }
        public void Register(in green_mage.action.GreenMageWalkAction action) {
            _walk_input.RegisterAction(action);
            _player_input_dictionary.Add(_walk_input._action.GetTypeName(), _walk_input);
        }
        public void Register(in green_mage.action.GreenMageBasicMagicAttackAction action) {
            _basic_magic_attack_input.RegisterAction(action);
            _player_input_dictionary.Add(_basic_magic_attack_input._action.GetTypeName(), _basic_magic_attack_input);
        }
        public void Register(in green_mage.action.GreenMageBasicMagicAttackReserveAction action) {
            _basic_magic_attack_reserve_input.RegisterAction(action);
            _player_input_dictionary.Add(_basic_magic_attack_reserve_input._action.GetTypeName(), _basic_magic_attack_reserve_input);
        }
        public void Register(in green_mage.action.GreenMageBasicMagicAttackChargeAction action) {
            _basic_magic_attack_charge_input.RegisterAction(action);
            _player_input_dictionary.Add(_basic_magic_attack_charge_input._action.GetTypeName(), _basic_magic_attack_charge_input);
        }
        public void Register(in green_mage.action.GreenMageJumpUpAction action) {
            _jump_up_input.RegisterAction(action);
            _player_input_dictionary.Add(_jump_up_input._action.GetTypeName(), _jump_up_input);
        }
        /// <summary>
        /// ハンドラ
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            GreenMageActionCommand command = null;
            var action = this.GetComponent<green_mage.action.GreenMageRootAction>();
            command = _player_input_dictionary[action.GetCurrentState().name].InputHandler();
            return command;
        }
        // Start is called before the first frame update
        void Start() {
            //! 依存関係を持つ同士
            _walk_input.RegisterInput(_jump_up_input);
        }
        // Update is called once per frame
        void Update() {
            _command = this.InputHandler();
        }
    }
}