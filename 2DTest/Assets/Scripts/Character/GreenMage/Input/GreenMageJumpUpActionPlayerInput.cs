using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageJumpUpActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! �A�N�V����
        public green_mage.action.GreenMageJumpUpAction _action;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageJumpUpActionPlayerInput() {
        }
        /// <summary>
        /// �o�^
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageJumpUpAction action) {
            this._action = action;
        }
        /// <summary>
        /// �n���h��
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            var command = new GreenMageJumpUpCommand(this._action);
            if(Input.GetKey(KeyCode.UpArrow)) {
            } // if
            command.GenerateParameter();
            return command;
        }
    }
}