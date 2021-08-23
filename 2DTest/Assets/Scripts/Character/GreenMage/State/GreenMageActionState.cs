using green_mage.action;


namespace green_mage.state {
    public class GreenMageActionState {
        //! ���O
        private action.ActionTypeName _name;
        //! �A�N�V����
        private green_mage.action.GreenMageActionable _action;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageActionState() {
        }
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="action"></param>
        public GreenMageActionState(in green_mage.action.GreenMageActionable action) {
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
        public green_mage.action.GreenMageActionable action {
            get {
                return this._action;
            }
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