using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageJumpUpActionParameter {
    };
    /// <summary>
    /// �N���X
    /// </summary>
    public class GreenMageJumpUpAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        private float _speed;
        private float _speed_max;
        private float _speed_decrease;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageJumpUpAction(in GreenMageRootAction root) :
            base(root) {
            _speed = 0.0f;
            _speed_max = 8.0f;
            _speed_decrease = 0.1f;
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="param"></param>
        public void SetParameter(in GreenMageJumpUpActionParameter param) {
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.JumpUp;
        }
        /// <summary>
        /// ���s
        /// </summary>
        public ActionResult Execute(float delta_time) {
            _speed -= _speed_decrease;
            var result = new ActionResult();
            var velocity = new Vector3(0.0f, _speed, 0.0f);
            base._rigidbody.velocity = velocity;

            return result;
        }
        /// <summary>
        /// �J�n
        /// </summary>
        public void Enter() {
            _speed = _speed_max;
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
        }
    }
}