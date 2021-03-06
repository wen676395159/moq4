﻿using Moq.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Moq
{
	using Moq.Proxy;

	/// <summary>
	/// Provides additional methods on mocks.
	/// </summary>
	/// <remarks>
	/// Those methods are useful for Testeroids support.
	/// </remarks>
	public static class MockExtensions
	{
		/// <summary>
		/// Resets the calls previously made on the specified mock.
		/// </summary>
		/// <param name="mock">The mock whose calls need to be reset.</param>
		public static void ResetCalls(this Mock mock)
		{
			mock.Interceptor.InterceptionContext.ClearInvocations();
		}

		/// <summary>
		/// Resets mock state, including setups and any previously made calls.
		/// </summary>
		/// <param name="mock">The mock that needs to be reset.</param>
		public static void Reset(this Mock mock)
		{
			mock.Interceptor.InterceptionContext.ClearOrderedCalls();
			mock.Interceptor.InterceptionContext.ClearEventHandlers();
			mock.Interceptor.ClearCalls();
			mock.ResetCalls();
		}
	}
}
