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
    using Leap;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GestureInputSystemGestureUpdateEventHandler {
        
        private TetrisDB.GestureUpdateEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private int ActionNode82_Minutes = default( System.Int32 );
        
        private int ActionNode82_Seconds = default( System.Int32 );
        
        private int IntNode83 = 1;
        
        private uFrame.Actions.Timer ActionNode82 = new uFrame.Actions.Timer();
        
        private TetrisDB.GestureUpdateEvent PublishEventNode84_Result = default( TetrisDB.GestureUpdateEvent );
        
        private object ActionNode86_message = default( System.Object );
        
        private string StringNode87 = "publish event";
        
        private Leap.Frame ActionNode74_Result = default( Leap.Frame );
        
        private Leap.Frame ActionNode75_frame = default( Leap.Frame );
        
        private Leap.Hand ActionNode75_left = default( Leap.Hand );
        
        private object ActionNode76_toCheck = default( System.Object );
        
        private object ActionNode77_key = default( System.Object );
        
        private int IntNode85 = 0;
        
        private Leap.Hand ActionNode77_hand = default( Leap.Hand );
        
        private TetrisDB.ActiveGroupMoveLeftEvent PublishEventNode79_Result = default( TetrisDB.ActiveGroupMoveLeftEvent );
        
        public TetrisDB.GestureUpdateEvent Event {
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
            ActionNode82_Seconds = IntNode83;
            // ActionNode
            while (this.DebugInfo("e3f5e492-b904-4a14-8c5a-b773be0bbca3","725c53c0-7ed2-4043-a83e-4a6ab798f094", this) == 1) yield return null;
            // Visit uFrame.Actions.Timer
            ActionNode82.Seconds = ActionNode82_Seconds;
            ActionNode82.System = System;
            ActionNode82.Complete = ()=> { System.StartCoroutine(ActionNode82_Complete()); };
            ActionNode82.Execute();
            // ActionNode
            while (this.DebugInfo("4a81c007-258f-4e34-a704-bac911459a04","730a328a-620a-408f-b020-1ec2c12ed328", this) == 1) yield return null;
            // Visit FrameUtils.getFrame
            ActionNode74_Result = FrameUtils.getFrame();
            ActionNode75_frame = ActionNode74_Result;
            // ActionNode
            while (this.DebugInfo("730a328a-620a-408f-b020-1ec2c12ed328","b83a3922-04bf-45ae-86ef-4cf556cad129", this) == 1) yield return null;
            // Visit FrameUtils.getLeftHandFromFrame
            FrameUtils.getLeftHandFromFrame(ActionNode75_frame, out ActionNode75_left);
            ActionNode76_toCheck = ActionNode75_left;
            // ActionNode
            while (this.DebugInfo("b83a3922-04bf-45ae-86ef-4cf556cad129","222aae32-7144-4f27-8cfc-34f6ccaad846", this) == 1) yield return null;
            // Visit ConditionsUtils.isNull
            ConditionsUtils.isNull(ActionNode76_toCheck, ()=> { System.StartCoroutine(ActionNode76_yes()); }, ()=> { System.StartCoroutine(ActionNode76_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode82_Complete() {
            // PublishEventNode
            while (this.DebugInfo("725c53c0-7ed2-4043-a83e-4a6ab798f094","9fe12bc1-ff95-4ca9-87af-04bf3d20f34d", this) == 1) yield return null;
            var PublishEventNode84_Event = new GestureUpdateEvent();
            System.Publish(PublishEventNode84_Event);
            PublishEventNode84_Result = PublishEventNode84_Event;
            ActionNode86_message = StringNode87;
            // ActionNode
            while (this.DebugInfo("9fe12bc1-ff95-4ca9-87af-04bf3d20f34d","4a81c007-258f-4e34-a704-bac911459a04", this) == 1) yield return null;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode86_message);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode76_yes() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode77_yes() {
            // PublishEventNode
            while (this.DebugInfo("2e85193b-7f96-4150-a0cd-ed5a3e0a5015","b650c064-1158-4d64-b429-56d62b2c1f71", this) == 1) yield return null;
            var PublishEventNode79_Event = new ActiveGroupMoveLeftEvent();
            System.Publish(PublishEventNode79_Event);
            PublishEventNode79_Result = PublishEventNode79_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode77_no() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode76_no() {
            ActionNode77_key = IntNode85;
            ActionNode77_hand = ActionNode75_left;
            // ActionNode
            while (this.DebugInfo("222aae32-7144-4f27-8cfc-34f6ccaad846","2e85193b-7f96-4150-a0cd-ed5a3e0a5015", this) == 1) yield return null;
            // Visit GestureUtils.isGestureSatisified
            GestureUtils.isGestureSatisified(ActionNode77_key, ActionNode77_hand, ()=> { System.StartCoroutine(ActionNode77_yes()); }, ()=> { System.StartCoroutine(ActionNode77_no()); });
            yield break;
        }
    }
}