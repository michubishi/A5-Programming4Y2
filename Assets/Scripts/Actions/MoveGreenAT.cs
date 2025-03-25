using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MoveGreenAT : ActionTask {
        /*
        * Author: Michelle Vuong
        * Description: Moves the blob to the green paint area.
        */
        public BBParameter<GameObject> blob;
        public BBParameter<Vector3> greenLocation;
        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {

		}

		protected override void OnUpdate() {
            blob.value.transform.position = Vector3.MoveTowards(blob.value.transform.position, greenLocation.value, Time.deltaTime * 2f);

            if (blob.value.transform.position == greenLocation.value)
            {
                EndAction(true);
            }
        }

	}
}