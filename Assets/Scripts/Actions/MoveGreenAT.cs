using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MoveGreenAT : ActionTask {

        public BBParameter<GameObject> cube;
        public BBParameter<Vector3> greenLocation;
        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {

		}

		protected override void OnUpdate() {
            cube.value.transform.position = Vector3.MoveTowards(cube.value.transform.position, greenLocation.value, Time.deltaTime * 2f);

            if (cube.value.transform.position == greenLocation.value)
            {
                EndAction(true);
            }
        }

	}
}