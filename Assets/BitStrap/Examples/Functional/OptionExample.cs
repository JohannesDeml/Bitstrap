﻿using UnityEngine;

namespace BitStrap.Examples
{
	public class OptionExample : MonoBehaviour
	{
		[Button]
		public void TestNoOption()
		{
			var a = 1;
			var b = 2;

			var r = a + b;

			Debug.Log( r );
		}

		[Button]
		public void TestWithOption()
		{
			Option<int> a = 1;
			Option<int> b = 2;

			var r = from x in a
					from y in b
					select x + y;

			int rValue;
			if( r.TryGet( out rValue ) )
				Debug.Log( rValue );
			else
				Debug.Log( "No Value" );
		}

		[Button]
		public void TestWithOptionAndNone()
		{
			Option<int> a = 1;
			Option<int> b = Functional.None;

			var r = from x in a
					from y in b
					select x + y;

			int rValue;
			if( r.TryGet( out rValue ) )
				Debug.Log( rValue );
			else
				Debug.Log( "No Value" );
		}

		[Button]
		public void TestWithNull()
		{
			Option<object> a = null;
			Debug.Log( "Has value? " + a.IsSome );
		}
	}
}