using Main.Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
	public class Registrado : MonoBehaviour {

		void Start ()
		{
			var messageBox = Helpers.BringMessageBox();
			
			messageBox.SetMessage("Registro efetuado!");


			messageBox.onOutOfMessage = () =>
			{
				messageBox.Dissapear();
			};
		}
	}
}
