// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TetrisDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GUISystemHandInvisibleRedEventHandler {
        
        public RedLightComponent Group;
        
        private TetrisDB.HandInvisibleEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode180_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode180_state = default( System.Boolean );
        
        private bool BoolNode181 = true;
        
        public TetrisDB.HandInvisibleEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode180_obj = Group.gameObject;
            ActionNode180_state = BoolNode181;
            // ActionNode
            while (this.DebugInfo("b2ad6fce-fbce-434c-85b3-e9976fbed7a4","fa8d044e-dfc4-489d-a365-7c4b08bc0a19", this) == 1) yield return null;
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode180_obj, ActionNode180_state);
            yield break;
        }
    }
}