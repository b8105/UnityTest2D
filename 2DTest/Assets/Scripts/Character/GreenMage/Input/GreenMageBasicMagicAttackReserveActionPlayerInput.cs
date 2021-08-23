using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageBasicMagicAttackReserveActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! �A�N�V����
        public green_mage.action.GreenMageBasicMagicAttackReserveAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageBasicMagicAttackReserveActionPlayerInput() {
        }
        /// <summary>
        /// �o�^
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageBasicMagicAttackReserveAction action) {
            this._action = action;
        }
        /// <summary>
        /// �n���h��
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            green_mage.command.GreenMageActionCommand command = null;
            command = new GreenMageBasicMagicAttackReserveCommand(_action);
            
            if(Input.GetKeyUp(KeyCode.Space)) {
                command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.BasicMagicAttack);
            } // if

            return command;
        }
    }
}