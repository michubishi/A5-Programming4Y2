using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class CheckBlueCT : ConditionTask {

        public BBParameter<Vector3> blueLocation;
        public BBParameter<GameObject> cube;

        protected override string OnInit(){
			return null;
		}

        protected override bool OnCheck()
        {
            if (cube.value.transform.position == blueLocation.value)
            {
                return true;
            }
            return false;
        }
	}
}