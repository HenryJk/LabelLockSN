using System.Collections.Generic;
using UnityEngine;

namespace LabelLockSN {
    class Toggler {
        private static Toggler gInstance = new Toggler();
        public static Toggler Instance() {
            return gInstance;
        }

        public HashSet<uGUI_SignInput> trackedSigns = new HashSet<uGUI_SignInput>();

        public void SetState(bool state) {
            foreach(var sign in trackedSigns) {
                var obj = sign.gameObject;
                while (obj) {
                    var colliders = obj.GetComponents<Collider>();
                    if (colliders.Length > 0) {
                        foreach (var collider in colliders) collider.enabled = state;
                        break;
                    }
                    obj = obj?.transform?.parent?.gameObject;
                }
            }
        }
    }
}
