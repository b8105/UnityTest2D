namespace green_mage.action {
    public enum ActionTypeName {
        None,
        Idle,
        Walk,
        JumpUp,
        JumpDown,
        BasicMagicAttack,
        BasicMagicAttackReserve,
        BasicMagicAttackCharge,
        BasicMagicChargeAttack,
        Root,
    }
    public class ActionResult {
        public bool change = false;
        public ActionTypeName next = ActionTypeName.None;
    }

    public interface GreenMageActionable {
        public ActionTypeName GetTypeName();
        public ActionResult Execute(float delta_time);
        public void Enter();
        public void Exit();
    }
}