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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(1)]
    [uFrame.Attributes.uFrameIdentifier("b2748441-b821-471b-b471-d73c690950a6")]
    public partial class SpawnComponent : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private GameObject[] _Spawnables;
        
        private ReactiveCollection<GameObject> _SpawnablesReactive;
        
        public override int ComponentId {
            get {
                return 1;
            }
        }
        
        public ReactiveCollection<GameObject> Spawnables {
            get {
                if (_SpawnablesReactive == null) {
                    _SpawnablesReactive = new ReactiveCollection<GameObject>(_Spawnables ?? new GameObject[] { });
                }
                return _SpawnablesReactive;
            }
        }
    }
}
