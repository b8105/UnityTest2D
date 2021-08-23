using UnityEngine;
using green_mage.action;
using green_mage.command;
using green_mage.input;


namespace green_mage.input {
    public class GreenMageBasicMagicAttackChargeActionPlayerInput : green_mage.input.GreenMageActionPlayerInput {
        //! �A�N�V����
        public green_mage.action.GreenMageBasicMagicAttackChargeAction _action;
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageBasicMagicAttackChargeActionPlayerInput() {
        }
        /// <summary>
        /// �o�^
        /// </summary>
        /// <param name="action"></param>
        public void RegisterAction(in green_mage.action.GreenMageBasicMagicAttackChargeAction action) {
            this._action = action;
        }
        /// <summary>
        /// �n���h��
        /// </summary>
        /// <returns></returns>
        public green_mage.command.GreenMageActionCommand InputHandler() {
            green_mage.command.GreenMageActionCommand command = null;
            command = new GreenMageBasicMagicAttackChargeCommand(_action);

            if(Input.GetKeyUp(KeyCode.Space)) {
                command = new GreenMageChangeStateCommand(green_mage.action.ActionTypeName.BasicMagicChargeAttack);
            } // if

            return command;
        }
    }
}