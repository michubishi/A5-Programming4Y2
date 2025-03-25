using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class RandomizerAT : ActionTask
	{

		public BBParameter<int> randomizer;

		protected override string OnInit()
		{
			return null;
		}


		protected override void OnExecute()
		{
			randomizer.value = Random.Range(1, 3);
			EndAction(true);
		}


		protected override void OnUpdate()
		{

		}
	}

}