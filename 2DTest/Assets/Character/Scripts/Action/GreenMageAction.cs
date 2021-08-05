using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace green_mage.action {
    public enum ActionTypeName {
        None,
        Walk,
        Root,
    }
    public class ActionResult {
        public bool change = false;
        public ActionTypeName next = ActionTypeName.None;
    }

    public interface GreenMageAction {
        public ActionTypeName GetTypeName();
        public ActionResult Execute(float delta_time);
        public void Enter();
        public void Exit();
    }
}