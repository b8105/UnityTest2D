using green_mage.action;


namespace green_mage.state {
    public class GreenMageActionState {
        //! ���O
        action.ActionTypeName _name ;
        //! �A�N�V����
        green_mage.action.GreenMageAction _action ;

        public GreenMageActionState(green_mage.action.GreenMageAction action) {
            this._action = action;
            this._name = this._action.GetTypeName();
        }

        /// <summary>
        /// �A�N�Z�b�T
        /// </summary>
        public action.ActionTypeName name {
            get {
                return this._name;
            }
        }
        /// <summary>
        /// �A�N�Z�b�T
        /// </summary>
        public green_mage.action.GreenMageAction action {
            get {
                return this._action;
            }
        }
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageActionState() {
        }

        /// <summary>
        /// �J�n
        /// </summary>
        public void Enter() {
            this.action.Enter();
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
            this.action.Exit();
        }
    }
}