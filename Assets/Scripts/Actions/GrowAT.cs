using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

    public class GrowAT : ActionTask {

        /*
         * Author: Michelle Vuong
         * Description: Blob changes colour and scales up by a fixed amount. 
         */

        public BBParameter<GameObject> blob;
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
            material.color = blueColor; //change colour to blue
            blob.value.transform.localScale += scale * Time.deltaTime; //Scale up blob overtime

            if (blob.value.transform.localScale.x >= 3) //once the scale has reached to 3 
            {
                EndAction(true);   //end the action task
            }
        }

	}
}