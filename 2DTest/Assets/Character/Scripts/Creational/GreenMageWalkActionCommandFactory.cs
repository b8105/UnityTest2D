using green_mage.action;
using green_mage.command;


namespace green_mage.creational {
    public class GreenMageWalkActionCommandFactory {
        //! �A�N�V����
        public green_mage.action.GreenMageWalkAction _action;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageWalkActionCommandFactory(green_mage.action.GreenMageWalkAction action) {
            this._action = action;
        }
        /// <summary>
        /// �쐬
        /// </summary>
        /// <returns></returns>
        public GreenMageWalkCommand Create() {
            return new GreenMageWalkCommand(this._action);
        }
    }
}