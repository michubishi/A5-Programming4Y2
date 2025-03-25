using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MovePinkAT : ActionTask {
        public BBParameter<GameObject> cube;
        public BBParameter<Vector3> pinkLocation;
		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            cube.value.transform.position = Vector3.MoveTowards(cube.value.transform.position, pinkLocation.value, Time.deltaTime * 2f);

			if (cube.value.transform.position == pinkLocation.value)
			{
                EndAction(true);
            }
        }

	}
}