using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveBlueAT : ActionTask {
        /*
        * Author: Michelle Vuong
        * Description: Moves the blob to the blue paint area.
        */
        public BBParameter<GameObject> blob;
		public BBParameter<Vector3> blueLocation;
		

		protected override string OnInit() {
			return null;
		}

		protected override void OnUpdate() {
            blob.value.transform.position = Vector3.MoveTowards(blob.value.transform.position, blueLocation.value, Time.deltaTime * 2f); //move to the center of the blue paint

			if (blob.value.transform.position == blueLocation.value) //once blob has reached it's location
			{
                EndAction(true);   //end the action task
            }

        }
		
	}
}