using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageBasicMagicAttackReserveActionParameter {
        public enum Direction {
            None,
            Right,
            Left,
        }
        public Direction direction = Direction.None;
    };
    /// <summary>
    /// �N���X
    /// </summary>
    public class GreenMageBasicMagicAttackReserveAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! ����
        [SerializeField]
        private float _attack_time = 0.0f;
        //! ����
        [SerializeField]
        private float _attack_time_set = 0.0f;
        //! ����
        [SerializeField]
        private float _attack_time_max = 3.0f;


        //! ����
        GreenMageBasicMagicAttackReserveActionParameter.Direction _direction;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageBasicMagicAttackReserveAction(in GreenMageRootAction root) :
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Idle);
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageBasicMagicAttackReserveActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.BasicMagicAttackReserve;
        }
        /// <summary>
        /// ���s
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();

            _attack_time += delta_time;

            if(_attack_time > _attack_time_max) {
                result.change = true;
                result.next = ActionTypeName.BasicMagicAttackCharge;
                _attack_time = 0.0f;
            } // if
            return result;
        }
        /// <summary>
        /// �J�n
        /// </summary>
        public void Enter() {
            _sprite_controller.ChangeSprite(this.GetTypeName());
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
        }
    }
}