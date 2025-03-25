using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveBlueAT : ActionTask {

		public BBParameter<GameObject> cube;
		public BBParameter<Vector3> blueLocation;
		

		protected override string OnInit() {
			return null;
		}

		protected override void OnUpdate() {
			cube.value.transform.position = Vector3.MoveTowards(cube.value.transform.position, blueLocation.value, Time.deltaTime * 2f);

			if (cube.value.transform.position == blueLocation.value) 
			{
                EndAction(true);
            }

        }
		
	}
}