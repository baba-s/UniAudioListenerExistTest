using NUnit.Framework;
using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class AudioListenerExistTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void Audio_Listener_が存在しない()
		{
			AllGameObjectTester.Test( gameObject => gameObject.GetComponent<AudioListener>() == null );
		}
	}
}