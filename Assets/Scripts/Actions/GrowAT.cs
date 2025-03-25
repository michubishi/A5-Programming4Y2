using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

    public class GrowAT : ActionTask {
        public BBParameter<GameObject> cube;
        public BBParameter<Vector3> blueLocation;
        public Vector3 scale;
        public Material material;
        public Color blueColor;

        protected override string OnInit() {
            return null;
        }

        protected override void OnExecute() {
            scale = new Vector3(1, 1, 1);
        }

        protected override void OnUpdate() {
            material.color = blueColor;
            cube.value.transform.localScale += scale * Time.deltaTime;

            if (cube.value.transform.localScale.x >= 3)
            {
                EndAction(true);
            }
        }

	}
}