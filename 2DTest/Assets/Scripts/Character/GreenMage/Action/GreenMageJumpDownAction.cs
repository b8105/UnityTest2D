using green_mage.action;


namespace green_mage.action {
    public class GreenMageJumpDownActionParameter {
    };
    /// <summary>
    /// �N���X
    /// </summary>
    public class GreenMageJumpDownAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageJumpDownAction(in GreenMageRootAction root) :
            base(root) {
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="param"></param>
        public void SetParameter(in GreenMageJumpDownActionParameter param) {
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.JumpDown;
        }
        /// <summary>
        /// ���s
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();
            return result;
        }
        /// <summary>
        /// �J�n
        /// </summary>
        public void Enter() {
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
        }
    }
}