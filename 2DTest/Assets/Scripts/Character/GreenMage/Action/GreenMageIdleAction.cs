using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageIdleActionParameter {
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
    public class GreenMageIdleAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! ����
        GreenMageIdleActionParameter.Direction _direction;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageIdleAction(in GreenMageRootAction root) :
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Idle);
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageIdleActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Idle;
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
            _sprite_controller.ChangeSprite(this.GetTypeName());
        }
        /// <summary>
        /// �I��
        /// </summary>
        public void Exit() {
        }
    }
}