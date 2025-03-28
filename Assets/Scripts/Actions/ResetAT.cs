using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ResetAT : ActionTask {
        /*
        * Author: Michelle Vuong
        * Description: Resets scale back to normal. 
        */

        public BBParameter<GameObject> blob;
        public Vector3 resetScale;
        public Material material;
        public Color greenColor;

        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			resetScale = new Vector3(1, 1, 1);
		}

		protected override void OnUpdate() {
            material.color = greenColor; //change colour to green
            blob.value.transform.localScale += resetScale * Time.deltaTime; //scale blob back up to it's original scale

            if (blob.value.transform.localScale.x >= 1) //if it has reached the default scale
                EndAction(true);  //end the action task
        }
        }
        

	}
