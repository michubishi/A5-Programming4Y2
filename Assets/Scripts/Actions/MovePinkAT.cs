using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MovePinkAT : ActionTask {

        /*
        * Author: Michelle Vuong
        * Description: Moves the blob to the pink paint area.
        */


        public BBParameter<GameObject> blob;
        public BBParameter<Vector3> pinkLocation;
		protected override string OnInit() {
			return null;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            blob.value.transform.position = Vector3.MoveTowards(blob.value.transform.position, pinkLocation.value, Time.deltaTime * 2f); //move blob to the center of the pink paint

			if (blob.value.transform.position == pinkLocation.value) //when the blob reaches the center of the pink paint
			{
                EndAction(true);  //end the action task
            }
        }

	}
}