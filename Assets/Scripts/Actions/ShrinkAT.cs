using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.UIElements;


namespace NodeCanvas.Tasks.Actions {

	public class ShrinkAT : ActionTask {

        /*
         * Author: Michelle Vuong
         * Description: Blob changes colour and scales up by a fixed amount. 
         */

        public BBParameter<GameObject> blob;
        public Vector3 shrink;
        public Material material;
        public Color pinkColor;

        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
            shrink = new Vector3(1, 1, 1);
		}

		protected override void OnUpdate() {
            material.color = pinkColor;
            blob.value.transform.localScale -= shrink * Time.deltaTime;

            if (blob.value.transform.localScale.x <= 0.5)
            {
                EndAction(true);
            }
        }

	}
}