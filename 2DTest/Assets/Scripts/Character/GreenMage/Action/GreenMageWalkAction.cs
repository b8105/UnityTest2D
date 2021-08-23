using UnityEngine;
using green_mage.action;


namespace green_mage.action {
    public class GreenMageWalkActionParameter {
        public enum Direction {
            None,
            Right,
            Left,
        }
        public float speed;
        public Direction direction = Direction.None;
    };

    /// <summary>
    /// �N���X
    /// </summary>
    public class GreenMageWalkAction :
        green_mage.action.GreenMageAction,
        green_mage.action.GreenMageActionable {
        //! ����
        private float _speed;
        //! ����
        GreenMageWalkActionParameter.Direction _direction;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public GreenMageWalkAction(in GreenMageRootAction root) : 
            base(root) {
            base._sprite_controller.AddActionSprite(this.GetTypeName(), MageSpritePack.SpriteType.Run);
            _speed = 2.0f;
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="param"></param>
        public void SetSpeed(float speed) {
            this._speed = speed;
        }
        /// <summary>
        /// �Z�b�^�[
        /// </summary>
        /// <param name="direction"></param>
        public void SetDirection(GreenMageWalkActionParameter.Direction direction) {
            this._direction = direction;
        }
        /// <summary>
        /// �Q�b�^�[
        /// </summary>
        /// <returns></returns>
        public ActionTypeName GetTypeName() {
            return ActionTypeName.Walk;
        }
        /// <summary>
        /// ���s
        /// </summary>
        public ActionResult Execute(float delta_time) {
            var result = new ActionResult();


            if(_sprite_controller.IsFacingRight() && _direction == GreenMageWalkActionParameter.Direction.Left) {
                _sprite_controller.FlipX();
            } // if
            else if(!_sprite_controller.IsFacingRight() && _direction == GreenMageWalkActionParameter.Direction.Right) {
                _sprite_controller.FlipX();
            } // else if


            float speed = 0.0f;
            if(_direction == GreenMageWalkActionParameter.Direction.Right) {
                speed = _speed;
            } // if
            else if(_direction == GreenMageWalkActionParameter.Direction.Left) {
                speed = -_speed;
            } // if

            var velocity = new Vector3(speed, 0.0f, 0.0f);
            _rigidbody.velocity = velocity;
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