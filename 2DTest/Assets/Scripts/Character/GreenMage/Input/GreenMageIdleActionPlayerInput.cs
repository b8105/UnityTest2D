using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageIdleActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! �A�N�V����
        public green_mage.action.GreenMageIdleAction _action;
        //! �W�����v
        public green_mage.input.GreenMageJumpUpActionPlayerInput _jump_up;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageIdleActionPlayerInput() {
        }
        /// <summary>
        /// �o�^
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageIdleAction action) {
            this._action = action;
        }
        /// <summary>
        /// �o�^
        /// </summary>
        /// <param name="input"></param>
        public void RegisterInput(in green_mage.input.GreenMageJumpUpActionPlayerInput input) {
            this._jump_up = input;
        }
        /// <summary>
        /// �n���h��
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            green_mage.command.GreenMageActionCommand command = null;

            if(Input.GetKey(KeyCode.RightArrow)) {
                command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.Walk);
            } // if
            else if(Input.GetKey(KeyCode.LeftArrow)) {
                command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.Walk);
            } // else
            else if(Input.GetKeyDown(KeyCode.Space)) {
                //command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.BasicMagicAttack);
                command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.BasicMagicAttackReserve);
            } // else
            return command;
        }
    }
}